using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BuisnessLayer.Services;
using EntitiesLayer.Entities;

namespace EventManager
{
    ///<author>Toni Leo Modrić Dragičević</author>
    public partial class FrmEventCheck : Form
    {
        private Event events;
        TransactionServices transactionServices = new TransactionServices();
        public FrmEventCheck(Event selectedEvent)
        {
            InitializeComponent();
            events = selectedEvent;
            helpProvider1.HelpNamespace = Path.Combine(Path.GetDirectoryName(Application.ExecutablePath), "Resources", "EventManagerPrirucnik.pdf");
        }

        private void FrmEventCheck_Load(object sender, EventArgs e)
        {
            ShowAllEventsTransactions();
        }

        private void ShowAllEventsTransactions()
        {
            List<Transaction> transactionList = new List<Transaction>();
            List<Transaction> transactionList1 = new List<Transaction>();
            transactionList = transactionServices.GetTransactionsEvent(events);
            transactionList1= transactionList.GroupBy(t => t.Id_Users).Select(th => th.FirstOrDefault()).ToList();

            dgvEventCheck.DataSource = transactionList1;
            dgvEventCheck.Columns["Id"].Visible = false;
            dgvEventCheck.Columns["Id_Events"].Visible = false;
            dgvEventCheck.Columns["Id_Users"].Visible = false;
            dgvEventCheck.Columns["Event"].Visible = false;
        }
    }
}
