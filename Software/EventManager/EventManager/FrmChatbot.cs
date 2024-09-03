using BuisnessLayer.Services;
using EntitiesLayer.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Navigation;

namespace EventManager
{
    public partial class FrmChatbot : Form
    {
        private ChatbotServices chatbotServices;

        public FrmChatbot(User loggedUser)
        {
            InitializeComponent();
            chatbotServices = new ChatbotServices(loggedUser);
        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            string userMessage = txtMessage.Text;
            if(userMessage.Length > 0)
            {
                DisplayUserMessage(userMessage);
                chatbotServices.SendMessage(userMessage);
                btnGetResponse.Enabled = true;
            }
        }

        private async void DisplayChatbotMessageAsync(Task<string> chatbotMessage)
        {
            var message = await chatbotMessage;
            txtCommunication.Text += Environment.NewLine + PrepareChatbotMessageForDisplay(message);
            if (!message.Contains("Chatbot is currently processing your request please wait few seconds and click again on Answer!"))
            {
                btnGetResponse.Enabled = false;
            }
        }

        private string PrepareChatbotMessageForDisplay(string chatbotMessage)
        {
            string msg = "Chatbot: " + Environment.NewLine + chatbotMessage;
            return msg;
        }

        private async void DisplayUserMessage(string userMessage)
        {
            if (txtCommunication.Text == "")
            {
                txtCommunication.Text += PrepareUserMessageForDisplay(userMessage);
            } else
            {
                txtCommunication.Text += Environment.NewLine + PrepareUserMessageForDisplay(userMessage);
            }
            txtMessage.Text = "";
        }

        private string PrepareUserMessageForDisplay(string userMessage)
        {
            string msg = "You: " + Environment.NewLine + userMessage;
            return msg;
        }

        private void btnGetResponse_Click(object sender, EventArgs e)
        {
            var chatbotMessage = chatbotServices.GetResponseMessage();
            DisplayChatbotMessageAsync(chatbotMessage);
        }

        private void FrmChatbot_FormClosed(object sender, FormClosedEventArgs e)
        {
            chatbotServices.DeleteThread();
        }

        private void FrmChatbot_Load(object sender, EventArgs e)
        {
            btnGetResponse.Enabled = false;
        }
    }
}
