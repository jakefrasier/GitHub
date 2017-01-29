// Program written by: Erik Johnson
//       Program date: 
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
            string lastYearContestantsAsString, thisYearContestantsAsString;
            bool moreThanLastYear;
            
            //Write("Enter the number of contestants at last year's event: ");
            lastYearContestantsAsString = ReadLine();
            lastYearContestants = Convert.ToDouble(lastYearContestantsAsString);

           // Write("Enter the number of contestants at this year's event: ");
            thisYearContestantsAsString = ReadLine();
            thisYearContestants = Convert.ToDouble(thisYearContestantsAsString);

            expectedRevenue = thisYearContestants * 25; // entrence fee is $25

            //WriteLine("This year's projected income is {0}", expectedRevenue.ToString("C"));

            moreThanLastYear = thisYearContestants > lastYearContestants;
            //moreThanLastYear = moreThanLastYear.ToString("C");
            //WriteLine("Are there more contestants at this year's event than last year: {0}", moreThanLastYear);


        }
    }
}
