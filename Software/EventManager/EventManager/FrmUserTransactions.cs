using BuisnessLayer;
using BuisnessLayer.Services;
using EntitiesLayer.Entities;
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

namespace EventManager
{
    public partial class FrmUserTransactions : Form
    {
        private User loginUser;
        private UserService userService;
        private TransactionServices transactionService;
        public FrmUserTransactions(User user)
        {
            InitializeComponent();
            transactionService = new TransactionServices();
            userService = new UserService();
            loginUser = userService.GetUserById(user);
            helpProvider1.HelpNamespace = Path.Combine(Path.GetDirectoryName(Application.ExecutablePath), "Resources", "EventManagerPrirucnik.pdf");
        }

        private void FrmUserTransactions_Load(object sender, EventArgs e)
        {
            dgvUserTransactions.DataSource = transactionService.GetTransactionsByUser(loginUser);
            dgvUserTransactions.Columns["Id"].Visible = false;
            dgvUserTransactions.Columns["Id_Events"].Visible = false;
            dgvUserTransactions.Columns["Id_Users"].Visible = false;
            dgvUserTransactions.Columns["User"].Visible = false;
        }

        private void imgBack_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
