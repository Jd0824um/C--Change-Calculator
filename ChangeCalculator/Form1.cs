using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ChangeCalculator
{
    public partial class formChangeCalculator : Form
    {
        public formChangeCalculator()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            //Variables for the change
            int quarter = 0;
            int dime = 0;
            int nickel = 0;
            int pennies = 0;

            int change = Convert.ToInt16(txtChange.Text); //Gets user input and converts it to an integer

            //Data validation
            if (change < 0 || change > 99 || change.Equals(null))
            {
                change = 0;
                txtChange.Text = "";
                txtQuarters.Text = "";
                txtDimes.Text = "";
                txtNickels.Text = "";
                txtPennies.Text = "";
            }

            while (change != 0) //Nested while loop that reduces the amount owed till zero is reached
            {
                while (change >= 25)
                {
                    quarter++;
                    change -= 25;
                }

                while (change >= 10)
                {
                    dime++;
                    change -= 10;

                }

                while (change >= 5)
                {
                    nickel++;
                    change -= 5;
                }
                
                while (change >= 1)
                {
                    pennies++;
                    change -= 1;
                }
            }

            //Sets textboxes to the variable values declared above
            txtQuarters.Text = quarter.ToString();
            txtDimes.Text = dime.ToString();
            txtNickels.Text = nickel.ToString();
            txtPennies.Text = pennies.ToString();

        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtChange.Text = "";
            txtQuarters.Text = "";
            txtDimes.Text = "";
            txtNickels.Text = "";
            txtPennies.Text = "";
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            //Closes the program
            this.Close();
        }
    }
}
