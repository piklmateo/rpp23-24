using BuisnessLayer;
using BuisnessLayer.Services;
using EntitiesLayer.Entities;
using iText.IO.Image;
using iText.Kernel.Pdf;
using iText.Layout;
using iText.Layout.Borders;
using iText.Layout.Element;
using iText.Layout.Properties;
using iText.StyledXmlParser.Jsoup.Nodes;
using iTextSharp.text;
using QRCoder;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using Image = iText.Layout.Element.Image;
using Paragraph = iText.Layout.Element.Paragraph;

namespace EventManager {
    public partial class FrmBuyTicket : Form {
        ///<author>Antonijo Hamzić</author>
        User loginUser;
        TicketCategoryService ticketCategoryService = new TicketCategoryService();
        TransactionServices transactionServices = new TransactionServices();
        TicketService ticketService = new TicketService();
        private EmailService emailService = new EmailService();
        private MessageService messageService = new MessageService();
        int cb1OriginalIndex = 0;
        int cb2OriginalIndex = 1;
        int cb3OriginalIndex = 2;
        Ticket foundTicket1;
        Ticket foundTicket2;
        Ticket foundTicket3;
        Event selectedEvent;
        decimal price1;
        decimal price2;
        decimal price3;
        ///<author>Antonijo Hamzić</author>
        public FrmBuyTicket(Event SelectedEvent, User user) {
            InitializeComponent();
            selectedEvent = SelectedEvent;
            loginUser = user;
            helpProvider1.HelpNamespace = Path.Combine(Path.GetDirectoryName(Application.ExecutablePath), "Resources", "EventManagerPrirucnik.pdf");

        }
        ///<author>Antonijo Hamzić</author>
        private void FrmBuyTicket_Load(object sender, EventArgs e) {

            getTickets();

            lblTicketName.Text = selectedEvent.Name;
            var ticketCategories1 = ticketCategoryService.GetTicketCategories();
            var ticketCategories2 = ticketCategoryService.GetTicketCategories();
            var ticketCategories3 = ticketCategoryService.GetTicketCategories();
            cbTicketType1.DataSource = ticketCategories1;
            cbTicketType2.DataSource = ticketCategories2;
            cbTicketType3.DataSource = ticketCategories3;
            cbTicketType2.SelectedIndex = 1;
            cbTicketType3.SelectedIndex = 2;



            txtFullPrice.Text = "0.0000";

            var tickets = getTickets();
            foundTicket1 = tickets.Find(ticket => ticket.Id_Category == 1);
            if (foundTicket1 != null) {
                txtPrice1.Text = "0.0000";
                nudAmount1.Maximum = Convert.ToDecimal(foundTicket1.Amount);
            } else {
                txtPrice1.Text = "No Tickets";
                nudAmount1.Maximum = 0;
            }

            foundTicket2 = tickets.Find(ticket => ticket.Id_Category == 2);
            if (foundTicket2 != null) {
                txtPrice2.Text = "0.0000";
                nudAmount2.Maximum = Convert.ToDecimal(foundTicket2.Amount);
            } else {
                txtPrice2.Text = "No Tickets";
                nudAmount2.Maximum = 0;
            }

            foundTicket3 = tickets.Find(ticket => ticket.Id_Category == 3);
            if (foundTicket3 != null) {
                txtPrice3.Text = "0.0000";
                nudAmount3.Maximum = Convert.ToDecimal(foundTicket3.Amount);
            } else {
                txtPrice3.Text = "No Tickets";
                nudAmount3.Maximum = 0;
            }

            txtName.Text = loginUser.Name;
            txtSurname.Text = loginUser.Surname;

            cbTicketType1.SelectedIndexChanged += ComboBox_SelectedIndexChanged1;
            cbTicketType2.SelectedIndexChanged += ComboBox_SelectedIndexChanged2;
            cbTicketType3.SelectedIndexChanged += ComboBox_SelectedIndexChanged3;

            nudAmount1.ValueChanged += Nud_ValueChanged1;
            nudAmount2.ValueChanged += Nud_ValueChanged2;
            nudAmount3.ValueChanged += Nud_ValueChanged3;
        }
        ///<author>Antonijo Hamzić</author>
        private void Nud_ValueChanged1(object sender, EventArgs e) {
            price1 = (decimal)(foundTicket1.Price * nudAmount1.Value);
            txtPrice1.Text = price1.ToString();

            changeFullPrice();
        }


        private void Nud_ValueChanged2(object sender, EventArgs e) {
            price2 = (decimal)(foundTicket2.Price * nudAmount2.Value);
            txtPrice2.Text = price2.ToString();
            changeFullPrice();
        }
        private void Nud_ValueChanged3(object sender, EventArgs e) {
            price3 = (decimal)(foundTicket3.Price * nudAmount3.Value);
            txtPrice3.Text = price3.ToString();
            changeFullPrice();
        }


        ///<author>Antonijo Hamzić</author>
        private void changeFullPrice() {
            txtFullPrice.Text = (price1 + price2 + price3).ToString();
        }

        ///<author>Antonijo Hamzić</author>
        private void ComboBox_SelectedIndexChanged1(object sender, EventArgs e) {

            if (cbTicketType1.SelectedIndex == cbTicketType3.SelectedIndex) {
                MessageBox.Show("You cannot choose same ticket type twice");
                cbTicketType1.SelectedIndex = cb1OriginalIndex;
            } else if (cbTicketType1.SelectedIndex == cbTicketType2.SelectedIndex) {
                MessageBox.Show("You cannot choose same ticket type twice");
                cbTicketType1.SelectedIndex = cb1OriginalIndex;
            }

            var categoryId = cbTicketType1.SelectedIndex + 1;
            var tickets = getTickets();
            foundTicket1 = tickets.Find(ticket => ticket.Id_Category == categoryId);
            if (foundTicket1 != null) {
                txtPrice1.Text = foundTicket1.Price.ToString();
                nudAmount1.Maximum = Convert.ToDecimal(foundTicket1.Amount);
            } else {
                txtPrice1.Text = "No Tickets";
                nudAmount1.Maximum = 0;
            }
            cb1OriginalIndex = cbTicketType1.SelectedIndex;


        }
        ///<author>Antonijo Hamzić</author>
        private void ComboBox_SelectedIndexChanged2(object sender, EventArgs e) {
            if (cbTicketType2.SelectedIndex == cbTicketType1.SelectedIndex) {
                MessageBox.Show("You cannot choose same ticket type twice");
                cbTicketType2.SelectedIndex = cb2OriginalIndex;
            } else if (cbTicketType2.SelectedIndex == cbTicketType3.SelectedIndex) {
                MessageBox.Show("You cannot choose same ticket type twice");
                cbTicketType2.SelectedIndex = cb2OriginalIndex;
            }


            var categoryId = cbTicketType2.SelectedIndex + 1;
            var tickets = getTickets();
            foundTicket2 = tickets.Find(ticket => ticket.Id_Category == categoryId);
            if (foundTicket2 != null) {
                txtPrice2.Text = foundTicket2.Price.ToString();
                nudAmount2.Maximum = Convert.ToDecimal(foundTicket2.Amount);
            } else {
                txtPrice2.Text = "No Tickets";
                nudAmount2.Maximum = 0;
            }

            cb2OriginalIndex = cbTicketType2.SelectedIndex;

        }
        ///<author>Antonijo Hamzić</author>
        private void ComboBox_SelectedIndexChanged3(object sender, EventArgs e) {
            if (cbTicketType3.SelectedIndex == cbTicketType1.SelectedIndex) {
                MessageBox.Show("You cannot choose same ticket type twice");
                cbTicketType3.SelectedIndex = cb3OriginalIndex;
            } else if (cbTicketType3.SelectedIndex == cbTicketType2.SelectedIndex) {
                MessageBox.Show("You cannot choose same ticket type twice");
                cbTicketType3.SelectedIndex = cb3OriginalIndex;
            }

            var categoryId = cbTicketType3.SelectedIndex + 1;
            var tickets = getTickets();
            foundTicket3 = tickets.Find(ticket => ticket.Id_Category == categoryId);
            if (foundTicket3 != null) {
                txtPrice3.Text = foundTicket3.Price.ToString();
                nudAmount3.Maximum = Convert.ToDecimal(foundTicket3.Amount);
            } else {
                txtPrice3.Text = "No Tickets";
                nudAmount3.Maximum = 0;
            }
            cb3OriginalIndex = cbTicketType3.SelectedIndex;
        }
        ///<author>Antonijo Hamzić</author>
        private List<Ticket> getTickets() {
            var tickets = ticketService.GetTicketsByEvent(selectedEvent);
            return tickets;
        }
        ///<author>Antonijo Hamzić</author>
        private void btnCancel_Click(object sender, EventArgs e) {
            Close();
        }
        ///<author>Antonijo Hamzić</author>
        private void btnAdd_Click(object sender, EventArgs e) {
            addTransaction();
        }
        ///<author>Antonijo Hamzić</author>
        private void printTicket() {
          

          
            string eventName = selectedEvent.Name;
            string eventDate = selectedEvent.EventDate.Date.ToString();
            string ticketType1 = cbTicketType1.SelectedItem.ToString();
            decimal ticketPrice1 = price1;
            string buyerName = txtName.Text;
            string buyerSurname = txtSurname.Text;
            string ticketType2 = cbTicketType2.SelectedItem.ToString();
            decimal ticketPrice2 = price2;
            string ticketType3 = cbTicketType3.SelectedItem.ToString();
            decimal ticketPrice3 = price3;




           
            string pdfFileName = $"Ticket_{Guid.NewGuid()}.pdf";

        
            using (PdfWriter writer = new PdfWriter(pdfFileName)) {
                using (PdfDocument pdf = new PdfDocument(writer)) {
                    using (iText.Layout.Document document = new iText.Layout.Document(pdf)) {
                        for (int i = 0; i < nudAmount1.Value; i++) {

                            QRCoder.QRCodeGenerator qRCodeGenerator = new QRCoder.QRCodeGenerator();
                            var QrData = qRCodeGenerator.CreateQrCode(eventName + ticketType1 + buyerName + buyerSurname + i, QRCoder.QRCodeGenerator.ECCLevel.H);
                            var Qrcode = new QRCoder.QRCode(QrData);
                            System.Drawing.Bitmap qrCodeBitmap = Qrcode.GetGraphic(2);

                            Table table = new Table(new float[] { 1, 2,3 ,4});

                            table.AddCell(new Cell().Add(new Paragraph($"Event Name"))).SetTextAlignment(TextAlignment.CENTER);
                            table.AddCell(new Cell().Add(new Paragraph($"Ticket Type"))).SetTextAlignment(TextAlignment.CENTER);
                            table.AddCell(new Cell().Add(new Paragraph($"Ticket Price"))).SetTextAlignment(TextAlignment.CENTER);
                      
                            table.AddCell(new Cell().Add(new Paragraph($"Buyer"))).SetTextAlignment(TextAlignment.CENTER);

                            table.AddCell(new Cell().Add(new Paragraph($"{eventName}"))).SetTextAlignment(TextAlignment.CENTER);
                       
                            table.AddCell(new Cell().Add(new Paragraph($"{ticketType1}"))).SetTextAlignment(TextAlignment.CENTER);
                         
                            table.AddCell(new Cell().Add(new Paragraph($"{ticketPrice1}€"))).SetTextAlignment(TextAlignment.CENTER);
                            table.AddCell(new Cell().Add(new Paragraph($"{buyerName} {buyerSurname}"))).SetTextAlignment(TextAlignment.CENTER);


                            using (MemoryStream stream = new MemoryStream()) {
                                qrCodeBitmap.Save(stream, System.Drawing.Imaging.ImageFormat.Png);
                                Image qrCodeImage = new Image(ImageDataFactory.Create(stream.ToArray()));
                                table.AddCell(new Cell().Add(qrCodeImage.SetHorizontalAlignment(iText.Layout.Properties.HorizontalAlignment.RIGHT)));
                            }

                           
                            table.AddCell(new Cell().SetBorderRight(Border.NO_BORDER));
                            table.AddCell(new Cell().SetBorderLeft(Border.NO_BORDER).SetBorderRight(Border.NO_BORDER));
                            table.AddCell(new Cell().SetBorderLeft(Border.NO_BORDER));

                          
                            document.Add(table);

                            if (i>=3 && i%3==0)
                                document.Add(new AreaBreak(AreaBreakType.NEXT_PAGE));

                        }
                        document.Add(new AreaBreak(AreaBreakType.NEXT_PAGE));
                        for (int i = 0; i < nudAmount2.Value; i++) {
     
                            QRCoder.QRCodeGenerator qRCodeGenerator = new QRCoder.QRCodeGenerator();
                            var QrData = qRCodeGenerator.CreateQrCode(eventName + ticketType2 + buyerName + buyerSurname + i, QRCoder.QRCodeGenerator.ECCLevel.H);
                            var Qrcode = new QRCoder.QRCode(QrData);
                            System.Drawing.Bitmap qrCodeBitmap = Qrcode.GetGraphic(2);

                            Table table = new Table(new float[] { 1, 2, 3, 4 });

                            table.AddCell(new Cell().Add(new Paragraph($"Event Name"))).SetTextAlignment(TextAlignment.CENTER);
                            table.AddCell(new Cell().Add(new Paragraph($"Ticket Type"))).SetTextAlignment(TextAlignment.CENTER);
                            table.AddCell(new Cell().Add(new Paragraph($"Ticket Price"))).SetTextAlignment(TextAlignment.CENTER);

                            table.AddCell(new Cell().Add(new Paragraph($"Buyer"))).SetTextAlignment(TextAlignment.CENTER);

                            table.AddCell(new Cell().Add(new Paragraph($"{eventName}"))).SetTextAlignment(TextAlignment.CENTER);

                            table.AddCell(new Cell().Add(new Paragraph($"{ticketType2}"))).SetTextAlignment(TextAlignment.CENTER);

                            table.AddCell(new Cell().Add(new Paragraph($"{ticketPrice2}€"))).SetTextAlignment(TextAlignment.CENTER);
                            table.AddCell(new Cell().Add(new Paragraph($"{buyerName} {buyerSurname}"))).SetTextAlignment(TextAlignment.CENTER);


                            using (MemoryStream stream = new MemoryStream()) {
                                qrCodeBitmap.Save(stream, System.Drawing.Imaging.ImageFormat.Png);
                                Image qrCodeImage = new Image(ImageDataFactory.Create(stream.ToArray()));
                                table.AddCell(new Cell().Add(qrCodeImage.SetHorizontalAlignment(iText.Layout.Properties.HorizontalAlignment.RIGHT)));
                            }


                            table.AddCell(new Cell().SetBorderRight(Border.NO_BORDER));
                            table.AddCell(new Cell().SetBorderLeft(Border.NO_BORDER).SetBorderRight(Border.NO_BORDER));
                            table.AddCell(new Cell().SetBorderLeft(Border.NO_BORDER));


                            document.Add(table);

                            if (i >= 3 && i % 3 == 0)
                                document.Add(new AreaBreak(AreaBreakType.NEXT_PAGE));
                        }
                        document.Add(new AreaBreak(AreaBreakType.NEXT_PAGE));
                        for (int i = 0; i < nudAmount3.Value; i++) {
                            QRCoder.QRCodeGenerator qRCodeGenerator = new QRCoder.QRCodeGenerator();
                            var QrData = qRCodeGenerator.CreateQrCode(eventName + ticketType3 + buyerName + buyerSurname + i, QRCoder.QRCodeGenerator.ECCLevel.H);
                            var Qrcode = new QRCoder.QRCode(QrData);
                            System.Drawing.Bitmap qrCodeBitmap = Qrcode.GetGraphic(2);

                            Table table = new Table(new float[] { 1, 2, 3, 4 });

             
                            table.AddCell(new Cell().Add(new Paragraph($"Event Name"))).SetTextAlignment(TextAlignment.CENTER);
                            table.AddCell(new Cell().Add(new Paragraph($"Ticket Type"))).SetTextAlignment(TextAlignment.CENTER);
                            table.AddCell(new Cell().Add(new Paragraph($"Ticket Price"))).SetTextAlignment(TextAlignment.CENTER);

                            table.AddCell(new Cell().Add(new Paragraph($"Buyer"))).SetTextAlignment(TextAlignment.CENTER);

                            table.AddCell(new Cell().Add(new Paragraph($"{eventName}"))).SetTextAlignment(TextAlignment.CENTER);

                            table.AddCell(new Cell().Add(new Paragraph($"{ticketType3}"))).SetTextAlignment(TextAlignment.CENTER);

                            table.AddCell(new Cell().Add(new Paragraph($"{ticketPrice3}€"))).SetTextAlignment(TextAlignment.CENTER);
                            table.AddCell(new Cell().Add(new Paragraph($"{buyerName} {buyerSurname}"))).SetTextAlignment(TextAlignment.CENTER);


                            using (MemoryStream stream = new MemoryStream()) {
                                qrCodeBitmap.Save(stream, System.Drawing.Imaging.ImageFormat.Png);
                                Image qrCodeImage = new Image(ImageDataFactory.Create(stream.ToArray()));
                                table.AddCell(new Cell().Add(qrCodeImage.SetHorizontalAlignment(iText.Layout.Properties.HorizontalAlignment.RIGHT)));
                            }


                            table.AddCell(new Cell().SetBorderRight(Border.NO_BORDER));
                            table.AddCell(new Cell().SetBorderLeft(Border.NO_BORDER).SetBorderRight(Border.NO_BORDER));
                            table.AddCell(new Cell().SetBorderLeft(Border.NO_BORDER));


                            document.Add(table);

                            if (i >=3 &&  i % 3 == 0)
                                document.Add(new AreaBreak(AreaBreakType.NEXT_PAGE));
                        }
                    }

                }
            }

            MessageBox.Show($"Ticket PDF created successfully: {pdfFileName}");
        }

        ///<author>Toni Leo Modrić Dragičević</author>
        private async Task SendNotificationAsync()
        {
            var eventDate = selectedEvent.EventDate.ToShortDateString();
            var eventTime = selectedEvent.StartTime.ToString();

            string subject = "Don't forget about " + selectedEvent.Name + "!";
            string body = "You have registered " + selectedEvent.Name + " that happens on " +
            eventDate + " at " + eventTime;

            notifyEvent.BalloonTipIcon = ToolTipIcon.Info;
            notifyEvent.Text = "Text";
            notifyEvent.Visible = true;
            notifyEvent.BalloonTipTitle = subject;
            notifyEvent.BalloonTipText = body;
            notifyEvent.ShowBalloonTip(100);

            await SendEmailAsync(subject, body);
            await SendMessageAsync(subject, body);
        }

        ///<author>Toni Leo Modrić Dragičević</author>
        private async Task SendEmailAsync(string subject, string body)
        {
            string recipientEmail = txtEmail.Text;
            if(string.IsNullOrWhiteSpace(recipientEmail))
            {
                MessageBox.Show("Email not send, because it is not filled!");
                return;
            }
            await Task.Run(() =>
           emailService.SendEmail(recipientEmail, body, subject));
        }

        ///<author>Toni Leo Modrić Dragičević</author>
        private async Task SendMessageAsync(string subject, string body) // NEMOJ TESTIRAT!
        {
            //string toNumber = loginUser.Phone;
            //string fromNumber = "+385957504465";
            //string bodyMessage = subject + " " + body;

            //try
            //{
            //    await Task.Run(() =>
            //    {
            //        int isMessageSent = messageService.SendMessage(bodyMessage, toNumber, fromNumber);

            //        if (isMessageSent != 0)
            //        {
            //            MessageBox.Show("SMS failed!");
            //        }
            //    });
            //}
            //catch (ApplicationException ex)
            //{
            //    MessageBox.Show(ex.Message);
            //}
        }
        ///<author>Antonijo Hamzić</author>
        private void addTransaction() {
            bool isSuccses=false;
            if (nudAmount1.Value > 0) {
                var transaction = new Transaction {
                    Id_Events = selectedEvent.Id,
                    Id_Users = loginUser.Id,
                    Type = cbTicketType1.Text.ToString(),
                    Amount = nudAmount1.Value
                };
               isSuccses= transactionServices.AddTransaction(transaction);
            }

            if (nudAmount2.Value > 0) {
                var transaction = new Transaction {
                    Id_Events = selectedEvent.Id,
                    Id_Users = loginUser.Id,
                    Type = cbTicketType2.Text.ToString(),
                    Amount = nudAmount2.Value
                };
                isSuccses = transactionServices.AddTransaction(transaction);

            }
            if (nudAmount3.Value > 0) {
                var transaction = new Transaction {
                    Id_Events = selectedEvent.Id,
                    Id_Users = loginUser.Id,
                    Type = cbTicketType3.Text.ToString(),
                    Amount = nudAmount3.Value
                };
                isSuccses = transactionServices.AddTransaction(transaction);
            }
            if (isSuccses) {
                MessageBox.Show("Transaction is complete");
                SendNotificationAsync();
                printTicket();
                Close();
            } else {
                MessageBox.Show("Transaction isnt complete, try again");
            }
            
        }
    }
}
