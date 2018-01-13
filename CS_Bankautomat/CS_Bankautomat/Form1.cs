using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace CS_Bankautomat
{
    public partial class Form1 : Form
    {
        string pin = "1234";
        string admin_pin = "6988";
        Konto konto = new Konto(0);
        string path = @"balance.txt";

        int login_counter = 0;

        #region Form1
        public Form1()
        {
            InitializeComponent();
            tabControl.TabPages.Remove(tabMain);    // Hide Main Tab
            tabControl.TabPages.Remove(tabLogout);  // Hide Logout Tab
            tabControl.TabPages.Remove(tabAdmin);
        }
        #endregion

        #region Form1_Load
        private void Form1_Load(object sender, EventArgs e)
        {
            txtCurrent.Text = Convert.ToString(konto.GetBalance()); // Get Balance at start of the program
        }
        #endregion

        #region Login Button
        private void btLogin_Click(object sender, EventArgs e)
        {
            if (txtPin.Text == pin)
            {
                tabControl.TabPages.Insert(1, tabMain);     // Enable Main Tab
                tabControl.TabPages.Insert(2, tabLogout);   // Enable Logout Tab
                tabControl.TabPages.Remove(tabLogin);       // Hide Login Tab
                login_counter = 0; 
            }
            else if (txtPin.Text == admin_pin)
            {
                tabControl.TabPages.Insert(1, tabMain);     // Enable Main Tab
                tabControl.TabPages.Insert(2, tabLogout);   // Enable Logout Tab
                tabControl.TabPages.Insert(3, tabAdmin);    // Enable Admin Tab
                tabControl.TabPages.Remove(tabLogin);       // Hides Login Tab
            }
            else if (txtPin.Text == pin || txtPin.Text == admin_pin)
            {
                lblWrong.Visible = true;                    // Wrong PIN entered
                login_counter++;                            // Counter adds up
                if(login_counter >= 3)
                {
                    MessageBox.Show("The program will exit due to security reasons.");
                    Environment.Exit(1);
                }
            }
        }
        #endregion

        #region Logout Button
        private void btLogout_Click(object sender, EventArgs e)
        {
            tabControl.TabPages.Remove(tabMain);    // Hide Main Tab
            tabControl.TabPages.Remove(tabLogout);  // Hide Logout Tab
            tabControl.TabPages.Insert(0, tabLogin);
            txtPin.Text = "";
        }
        #endregion

        #region PIN Enter
        private void txtPin_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btLogin_Click(this, new EventArgs());
            }
        }
        #endregion

        #region Kontostand Button
        private void btKontostand_Click(object sender, EventArgs e)
        {
            txtKontostand.Text = Convert.ToString(konto.GetBalance());
        }
        #endregion

        #region Deposit Button
        private void btDeposit_Click(object sender, EventArgs e)
        {
            if (txtDeposit.Text == "")
            {
                MessageBox.Show("Error. Please verify your input.");
            }
            else
            {
                txtKontostand.Text = Convert.ToString(Convert.ToDecimal(txtDeposit.Text) + Convert.ToDecimal(konto.GetBalance()));
                File.WriteAllText(path, txtKontostand.Text);
                txtCurrent.Text = Convert.ToString(konto.GetBalance());
                lblUpdate.Text = "+" + txtDeposit.Text + "€";
                txtDeposit.Text = "";

            }
        }
        #endregion

        #region Withdraw Button
        private void btWithdraw_Click(object sender, EventArgs e)
        {
            if (txtWithdraw.Text == "")
            {
                MessageBox.Show("Error. Please verify your input.");
            }
            else
            {
                txtKontostand.Text = Convert.ToString(Convert.ToDecimal(konto.GetBalance()) - Convert.ToDecimal(txtWithdraw.Text));
                File.WriteAllText(path, txtKontostand.Text);
                txtCurrent.Text = Convert.ToString(konto.GetBalance());
                lblUpdate.Text = "-" + txtWithdraw.Text + "€";
                txtWithdraw.Text = "";

            }
        }
        #endregion

        #region Exit Button
        private void btExit_Click(object sender, EventArgs e)
        {
            Environment.Exit(1);
        }
        #endregion
    }
}
