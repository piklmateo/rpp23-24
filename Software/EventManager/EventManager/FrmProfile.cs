using BuisnessLayer;
using EntitiesLayer.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EventManager
{
    public partial class FrmProfile : Form
    {
        private User loginUser;
        private UserService userService;
        public FrmProfile(User user)
        {
            InitializeComponent();
            userService = new UserService();
            loginUser = userService.GetUserById(user);
            helpProvider1.HelpNamespace = Path.Combine(Path.GetDirectoryName(Application.ExecutablePath), "Resources", "EventManagerPrirucnik.pdf");
        }

        private void FrmProfile_Load(object sender, EventArgs e)
        {
            LoadUserData(loginUser);
        }

        private void LoadUserData(User user)
        {
            txtName.Text = user.Name;
            txtSurname.Text = user.Surname;
            txtAddress.Text = user.Address;
            txtPhone.Text = user.Phone;
            txtUsername.Text = user.Username;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            var name = txtName.Text;
            var surname = txtSurname.Text;
            var address = txtAddress.Text;
            var phone = txtPhone.Text;

            if (InfoIsNotChanged(name, surname, address, phone)) return;

            if(CheckUserInput(name, surname, address, phone))
            {
                User user = new User();
                user.Id = loginUser.Id;
                user.Name = name;
                user.Surname = surname;
                user.Address = address;
                user.Phone = phone;
                user.Username = loginUser.Username;
                user.Password = loginUser.Password;
                user.Id_Roles = loginUser.Id_Roles;

                userService.UpdateUser(user);
                MessageBox.Show("User info is updated!", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                loginUser = userService.GetUserById(user);
                LoadUserData(loginUser);
            }
        }

        private bool InfoIsNotChanged(string name, string surname, string address, string phone)
        {
            if(
                name == loginUser.Name &&
                surname == loginUser.Surname &&
                address == loginUser.Address &&
                phone == loginUser.Phone
            )
            {
                return true;
            }
            return false;
        }

        private bool CheckUserInput(string name, string surname, string address, string phone)
        {
            string namePattern = @"^[a-zA-Z]+(?:[\s\-][a-zA-Z]+)*$";
            Regex nameRegex = new Regex(namePattern);
            if (!nameRegex.IsMatch(name))
            {
                MessageBox.Show("Name is invalid!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            string surnamePattern = @"^[a-zA-Z0-9]+(?:[\s\-][a-zA-Z]+)*$";
            Regex surnameRegex = new Regex(surnamePattern);
            if (!surnameRegex.IsMatch(surname))
            {
                MessageBox.Show("Surname is invalid!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            
            string addressPattern = @"^[a-zA-Z0-9_\- ]+$";
            Regex addressRegex = new Regex(addressPattern);
            if (!addressRegex.IsMatch(address))
            {
                MessageBox.Show("Address is invalid!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            string phonePattern = @"^[0-9+\-]+$";
            Regex phoneRegex = new Regex(phonePattern);
            if (!phoneRegex.IsMatch(phone))
            {
                MessageBox.Show("Phone is invalid!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            return true;
        }

        private void btnEvents_Click(object sender, EventArgs e)
        {
            var form = new FrmUserEvents(loginUser);
            form.ShowDialog();
        }

        private void btnTransactions_Click(object sender, EventArgs e)
        {
            var form = new FrmUserTransactions(loginUser);
            form.ShowDialog();
        }

        private void btnCalendar_Click(object sender, EventArgs e) {
            var form = new FrmCalendar(loginUser);
            form.ShowDialog();
        }
    }
}
