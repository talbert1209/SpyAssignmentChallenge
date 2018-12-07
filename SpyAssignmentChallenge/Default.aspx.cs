using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace SpyAssignmentChallenge
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                previousEndDateCalendar.SelectedDate = DateTime.Now.Date;
                newStartDateCalendar.SelectedDate = DateTime.Now.Date.AddDays(14);
                newEndDateCalendar.SelectedDate = DateTime.Now.Date.AddDays(21);
            }
        }

        protected void assignSpyButton_Click(object sender, EventArgs e)
        {
            string codeName = codeNameTextBox.Text;
            string assignmentName = assignmnetNameTextBox.Text;
            decimal budget;
            decimal spyPrice = 500;
            TimeSpan twoWeeks = new TimeSpan(14,0,0,0);
            TimeSpan timeOff = newStartDateCalendar.SelectedDate.Subtract(previousEndDateCalendar.SelectedDate);
            TimeSpan threeWeeks = new TimeSpan(21,0,0,0);
            TimeSpan assignmentLength = newEndDateCalendar.SelectedDate.Subtract(newStartDateCalendar.SelectedDate);
            DateTime previousEndDate = previousEndDateCalendar.SelectedDate.Date;

            if (timeOff < twoWeeks)
            {
                newStartDateCalendar.SelectedDate = previousEndDate.AddDays(14);
                resultsLabel.ForeColor = Color.Red;
                resultsLabel.Text =
                    $"Error: Must allow at least two weeks between previous assignment and next assignment.<br/>" +
                    $"The next available start date is {previousEndDate.AddDays(14).Date.ToLongDateString()}.";
            }
            else
            {
                budget = (decimal)assignmentLength.TotalDays * spyPrice;
                if (assignmentLength > threeWeeks)
                {
                    budget += 1000;
                }
                resultsLabel.ForeColor = Color.Black;
                resultsLabel.Text =
                    $"Assignment of {codeName} to assignment Project: {assignmentName} is authorized. Budget total: {budget:C}";
            }
        }
    }
}