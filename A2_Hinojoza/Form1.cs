using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
/*Jose Hinojoza
 * Assignment 2
 * Program gives the halflife of item given initial,current amounts, and time elapsed.
 * 
 * 
 */
namespace A2_Hinojoza
{
    public partial class Form1 : Form
    {
       // double time,amountIni,amountCur;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnHalfLifeCal_Click(object sender, EventArgs e)//calculates half time on the click
        {

            double halfTime;
            double elapsedTime = double.Parse(txtTimeElapsed.Text);
            double amountInitial = double.Parse(txtAmountInitial.Text);
            double amountCurrent = double.Parse(txtAmountCurrent.Text);

            if(amountInitial >= 0 && amountCurrent >= 0)
            {
                halfTime = (elapsedTime * Math.Log(2)) / (Math.Log(amountInitial/amountCurrent));
                lblHalfLife.Text = "Half time = " + halfTime.ToString();
            }
            else
            {
                MessageBox.Show("Please enter valid amounts( Greater or equal to 0)");
            }
        
        }

        private void btnIncreaseTime_Click(object sender, EventArgs e)//increases by one the elapsed time every time it is clicked
        {
            double elapsedTime = double.Parse(txtTimeElapsed.Text);
            elapsedTime += 1;
            txtTimeElapsed.Text = elapsedTime.ToString();
        }

        private void btnDecreaseTime_Click(object sender, EventArgs e)
        {
            double elapsedTime = double.Parse(txtTimeElapsed.Text);
            elapsedTime -= 1;
            if(elapsedTime <= 1)
            {
               elapsedTime = 1;  
            }
          
            txtTimeElapsed.Text = elapsedTime.ToString();
        }

        private void btnReset_Click(object sender, EventArgs e)//resets the values in the text boxes
        {
            txtTimeElapsed.Text = "0";
            txtAmountInitial.Text = "0";
            txtAmountCurrent.Text = "0";
        }
    }
}
