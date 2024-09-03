using BuisnessLayer;
using BuisnessLayer.Services;
using EntitiesLayer.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EventManager
{
    public partial class FrmRateEvent : Form
    {
        private User loginUser;
        private Event selectedEvent;
        private ReviewService reviewService;
        public FrmRateEvent(Event selectedEvent, User user)
        {
            InitializeComponent();
            loginUser = user;
            this.selectedEvent = selectedEvent;
            reviewService = new ReviewService();
        }

        private void FrmRateEvent_Load(object sender, EventArgs e)
        {
            lblEventName.Text = selectedEvent.Name;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnDone_Click(object sender, EventArgs e)
        {
            var comment = txtComment.Text;
            int questionOne = GetQuestionOneAnswear();
            int questionTwo = GetQuestionTwoAnswear();

            if(questionOne == 0 || questionTwo == 0)
            {
                MessageBox.Show("Please answer all questions!", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            var review = new Review
            {
                Comment = comment,
                Rate = questionOne,
                Recommend = questionTwo,
                Event = selectedEvent,
                User = loginUser
            };

            reviewService.AddReview(review);

            Close();
        }

        private int GetQuestionTwoAnswear()
        {
            var questionOne = gbQuestionOne.Controls.OfType<RadioButton>().FirstOrDefault(r => r.Checked);

            if (questionOne == rbOneQ1) return 1;

            if (questionOne == rbTwoQ1) return 2;

            if (questionOne == rbThreeQ1) return 3;

            if (questionOne == rbFourQ1) return 4;

            if (questionOne == rbFiveQ1) return 5;

            return 0;
        }

        private int GetQuestionOneAnswear()
        {
            var questionTwo = gbQuestionTwo.Controls.OfType<RadioButton>().FirstOrDefault(r => r.Checked);

            if (questionTwo == rbOneQ2) return 1;

            if (questionTwo == rbTwoQ2) return 2;

            if (questionTwo == rbThreeQ2) return 3;

            if (questionTwo == rbFourQ2) return 4;

            if (questionTwo == rbFiveQ2) return 5;

            if (questionTwo == rbSixQ2) return 6;

            if (questionTwo == rbSevenQ2) return 7;

            if (questionTwo == rbEightQ2) return 8;

            if (questionTwo == rbNineQ2) return 9;

            if (questionTwo == rbTenQ2) return 10;


            return 0;
        }
    }
}
