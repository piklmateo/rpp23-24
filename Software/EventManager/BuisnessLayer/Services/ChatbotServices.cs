using EntitiesLayer.Entities;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace BuisnessLayer.Services
{
    public class ChatbotServices
    {
        private const string apiKey = "";
        private const string assistantId = "";
        private string threadId = "";
        private string runId = "";
        private User user;

        private UserService userService;
        private TicketService ticketService;
        private EventServices eventServices;

        public ChatbotServices(User loggedUser)
        {
            user = loggedUser;
            userService = new UserService();
            ticketService = new TicketService();
            eventServices = new EventServices();
        }

        private List<Event> GetAllUserEvents()
        {
            var userTickets = ticketService.GetTicketsByUser(user);
            var events = eventServices.GetEventsByUser(userTickets);
            return events;
        }

        private async Task<JObject> SendPostRequestAsync(string url, StringContent content)
        {
            var _httpClient = new HttpClient();
            _httpClient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", apiKey);
            _httpClient.DefaultRequestHeaders.Add("OpenAI-Beta", "assistants=v1");
            _httpClient.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
            var response = await _httpClient.PostAsync(url, content);

            if (!response.IsSuccessStatusCode)
            {
                string errorResponse = await response.Content.ReadAsStringAsync();
                throw new Exception($"Error: {errorResponse}");
            }

            var responseContent = await response.Content.ReadAsStringAsync();
            return (JObject)JsonConvert.DeserializeObject(responseContent);
        }

        private async Task CreateThread()
        {
            var requestData = new
            {
                assistant_id = assistantId
            };
            var url = "https://api.openai.com/v1/threads";
            JObject result = await SendPostRequestAsync(url, null);

            threadId = result["id"].ToString();
        }

        public async void DeleteThread()
        {
            var _httpClient = new HttpClient();
            _httpClient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", apiKey);
            _httpClient.DefaultRequestHeaders.Add("OpenAI-Beta", "assistants=v1");
            _httpClient.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
            var response = await _httpClient.DeleteAsync($"https://api.openai.com/v1/threads/{threadId}");

            if (!response.IsSuccessStatusCode)
            {
                string errorResponse = await response.Content.ReadAsStringAsync();
                throw new Exception($"Error: {errorResponse}");
            }

            var responseContent = await response.Content.ReadAsStringAsync();
            JObject result = (JObject)JsonConvert.DeserializeObject(responseContent);
        }   

        private async Task AskQuestion(string message)
        {
            var requestData = new
            {
                role = "user",
                content = message
            };
            var content = new StringContent(JsonConvert.SerializeObject(requestData), Encoding.UTF8, "application/json");
            var url = $"https://api.openai.com/v1/threads/{threadId}/messages";
            JObject result = await SendPostRequestAsync(url, content);

            var userEvents = GetAllUserEvents();

            var runData = new
            {
                assistant_id = assistantId,
                additional_instructions = $"In application is currently logged in user with username: {user.Username}. This user has this events: {userEvents}"
            };
            content = new StringContent(JsonConvert.SerializeObject(runData), Encoding.UTF8, "application/json");
            url = $"https://api.openai.com/v1/threads/{threadId}/runs";
            result = await SendPostRequestAsync(url, content);
            runId = result["id"].ToString();
        }

        private async Task<bool> CheckStatus()
        {
            var _httpClient = new HttpClient();
            _httpClient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", apiKey);
            _httpClient.DefaultRequestHeaders.Add("OpenAI-Beta", "assistants=v1");
            _httpClient.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));


            var response = await _httpClient.GetAsync($"https://api.openai.com/v1/threads/{threadId}/runs/{runId}");

            if (!response.IsSuccessStatusCode)
            {
                string errorResponse = await response.Content.ReadAsStringAsync();
                return false;
            }

            var responseContent = await response.Content.ReadAsStringAsync();
            JObject result = (JObject)JsonConvert.DeserializeObject(responseContent);

            var completedAt = result["completed_at"].ToString();

            if(completedAt != "")
            {
                return true;
            }

            return false;

        }

        public async void SendMessage(string message)
        {
            try
            {
                if (threadId == "") await CreateThread();
                await AskQuestion(message);
            } 
            catch
            {
                  
            }
            
        }

        public async Task<string> GetResponseMessage()
        {   
            if(threadId == "" || runId == "")
            {
                return "Something went wrong! Please try again later.";
            }
            var isReady = await CheckStatus();
            if(!isReady)
            {
                return "Chatbot is currently processing your request please wait few seconds and click again on Answer!";
            }
            var response = "";

            try
            {
                response = await GetAnswer();
            } catch (Exception ex)
            {
                response = "Chatbot is currently unavailable please try again later!";
            }

            return response;
        }

        private async Task<string> GetAnswer()
        {
            var _httpClient = new HttpClient();
            _httpClient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", apiKey);
            _httpClient.DefaultRequestHeaders.Add("OpenAI-Beta", "assistants=v1");
            _httpClient.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

            var response = await _httpClient.GetAsync($"https://api.openai.com/v1/threads/{threadId}/messages");

            if (!response.IsSuccessStatusCode)
            {
                string errorResponse = await response.Content.ReadAsStringAsync();
                throw new Exception($"Error: {errorResponse}");
            }

            var responseContent = await response.Content.ReadAsStringAsync();
            JObject result = (JObject)JsonConvert.DeserializeObject(responseContent);
            var data = result["data"][0];
            var content = data["content"][0];
            var text = content["text"];
            var value = text["value"].ToString();

            return value;
        }
    }
}
