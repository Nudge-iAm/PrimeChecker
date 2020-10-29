/*****************************************************************
 * Name: Dylan Pyles
 * eMail: pylesdn@mail.uc.edu
 * Assignment #: 6
 * Due Date: 10/29/2020
 * Course / Semester / Year: IT3045C / Fall/ 2020
 * Description : Form that uses the PrimeCheckerWithBigInterger project to check inputted numbers and determine if they are prime or not. Different results for each.
 * Citation / References : 
 * Anything else pertinent : 
 * ***************************************************************/
using System;
using System.Drawing;
using System.Windows.Forms;
using PrimeCheckerWithBigInteger;

namespace pylesdn_Assignment06
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        // A button that takes the user inputed number and checks if it is prime by passing it through the PrimeChecker class when it is clicked
        private void btnCheck_Click(object sender, EventArgs e)
        {
            // Convert number so it can be passed through the IsPrime method, which uses BigInteger
            if (PrimeChecker.IsPrime(Convert.ToInt64(nudUserInput.Value)) == true)
            {
                // Displays label for that shows the number is prime
                lblPrime.Show();
                lblNotPrime.Hide();
                // Changes background color to green for prime numbers
                this.BackColor = Color.Green;
                // A happy cat is displayed :)
                picHappyCat.Show();
                picSadCat.Hide();
            }
            else
            {
                // Displays label for that shows the number is not prime
                lblNotPrime.Show();
                lblPrime.Hide();
                // Changes background color to red for non-prime numbers
                this.BackColor = Color.Red;
                // A sad cat is displayed :(
                picSadCat.Show();
                picHappyCat.Hide();
            }
        }

        // A link that leads to a site containing all prime numbers
        private void lblAllPrimeNumbers_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.mathsisfun.com/numbers/prime-numbers-to-10k.html");
        }
    }
}
