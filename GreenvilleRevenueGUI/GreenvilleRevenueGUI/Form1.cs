// Program written by: Erik Johnson, Jake Frasier
//       Program date: 1/28/17
//Program description:  Greenville Revenue Chapter 3, Case Problem 1
// Encountered issues: 
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GreenvilleRevenueGUI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double lastYearContestants, thisYearContestants, expectedRevenue;
            //string lastYearContestantsAsString, thisYearContestantsAsString;
            bool moreThanLastYear;
            
            lastYearContestants = Convert.ToDouble(lastYearTextBox.Text);
            thisYearContestants = Convert.ToDouble(thisYearTextBox.Text);
            expectedRevenue = thisYearContestants * 25; // entrence fee is $25
            expectedRevenueLabel.Text=("This year's projected income is "+ expectedRevenue.ToString("C"));
            moreThanLastYear = thisYearContestants > lastYearContestants;
            greaterLabel.Text="Are there more contestants at this year's event than last year: "+ moreThanLastYear;

            expectedRevenueLabel.Visible = true;
            greaterLabel.Visible = true;



        }
    }
}
