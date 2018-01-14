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
        #region Global
        string admin_pin = "6988";                                      // Admin PIN 
        Konto konto = new Konto(0);                                     // New Konto Object
        string temp;                                                    // Global temp var for the path
        int login_counter = 0;                                          // Login_counter
        string path = Directory.GetCurrentDirectory();                  // Debug folder
        #endregion

        #region Form1
        public Form1()
        {
            InitializeComponent();
            tabControl.TabPages.Remove(tabMain);                        // Hide Main Tab
            tabControl.TabPages.Remove(tabLogout);                      // Hide Logout Tab
            tabControl.TabPages.Remove(tabAdmin);                       // Hide Admin Tab
        }
        #endregion

        #region Form1_Load
        private void Form1_Load(object sender, EventArgs e)
        {
            string[] files = Directory.GetFiles(path, "*.txt");         // Gets all .txt files in Debug folder
            foreach (var text in files)                                 // for each item in files
            {
                Char delimiter = '\\';                                  // Trennzeichen \
                string[] split = text.Split(delimiter);                 // Split string into individual items at \
                listUsers.Items.Add(split[split.Length-1]);             // Adds last index as name
                txtCreate.MaxLength = 4;
                txtDelete.MaxLength = 4;
                txtWithdraw.MaxLength = 3;
                txtPin.MaxLength = 4;
            }

        }
        #endregion

        #region Login Button
        private void btLogin_Click(object sender, EventArgs e)
        {
            string path = txtPin.Text + ".txt";                         // Variable for Input.txt
            temp = path;

            if (txtPin.Text == "6988")                                // Checks if Input is the same as the global admin PIN
            {                                                           // If so
                tabControl.TabPages.Insert(1, tabMain);                 // Enable Main Tab
                tabControl.TabPages.Insert(2, tabLogout);               // Enable Logout Tab
                tabControl.TabPages.Insert(3, tabAdmin);                // Enable Admin Tab
                tabControl.TabPages.Remove(tabLogin);                   // Hides Login Tab
                login_counter = 0;
                txtCurrent.Text = konto.GetBalance(konto.GetFilePath(txtPin.Text + ".txt")).ToString();
            }
            else if (File.Exists(path))                                 // Checks if Input.txt exists
            {                                                           // If so
                tabControl.TabPages.Insert(1, tabMain);                 // Enable Main Tab
                tabControl.TabPages.Insert(2, tabLogout);               // Enable Logout Tab
                tabControl.TabPages.Remove(tabLogin);                   // Hide Login Tab

                login_counter = 0;                                      // Sets Login Counter to 0
                txtCurrent.Text = konto.GetBalance(konto.GetFilePath(txtPin.Text + ".txt")).ToString();
            }
            else if (!File.Exists(path))                                // If the input is wrong and not the same as the admin PIN
            {
                lblWrong.Visible = true;                                // Wrong PIN entered
                login_counter++;                                        // Counter adds up
                if (login_counter >= 3)                                 // If PIN is entered wrong 3x
                {
                    MessageBox.Show("The program will exit due to security reasons.");
                    Environment.Exit(1);                                // Exit program
                }
            }
        }
        #endregion

        #region Logout Button
        private void btLogout_Click(object sender, EventArgs e)
        {
            tabControl.TabPages.Remove(tabMain);            // Hide Main Tab
            tabControl.TabPages.Remove(tabLogout);          // Hide Logout Ta
            tabControl.TabPages.Remove(tabAdmin);
            tabControl.TabPages.Insert(0, tabLogin);        // Shows Login Tab
            txtPin.Text = "";                               // Clear Textbox
        }
        #endregion

        #region PIN Enter
        private void txtPin_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)                    // If Enter is pressed
            {
                btLogin_Click(this, new EventArgs());       // Simulates btLogin Click
            }
        }
        #endregion

        #region Kontostand Button
        private void btKontostand_Click(object sender, EventArgs e)
        {
            txtKontostand.Text = Convert.ToString(konto.GetBalance(temp));  // Shows balance
        }
        #endregion

        #region Deposit Button
        private void btDeposit_Click(object sender, EventArgs e)
        {
            if (txtDeposit.Text == "")                                  // Checks if Textbox is empty
            {                                                           // If so
                MessageBox.Show("Error. Please verify your input.");    // Show error message
            }
            else
            {
                float balance = float.Parse(konto.GetBalance(temp));    // Variable for storing the balance inside the file
                float deposit = float.Parse(txtDeposit.Text);           // Variable for storing the number from the textbox
                float result = deposit + balance;                       // Adding the balance and number from the textbox
                txtCurrent.Text = result.ToString();                    // Fills the current balance Textbox with the result
                File.WriteAllText(temp, txtCurrent.Text);               // Saves the current balance to the file
                lblUpdate.Text = "+" + txtDeposit.Text + "€";           // Changes the lbl to "+ Input €"
                txtDeposit.Text = "";                                   // Clears the Deposit Textbox
            }
        }
        #endregion

        #region Withdraw Button
        private void btWithdraw_Click(object sender, EventArgs e)
        {
            if (txtWithdraw.Text == "")                                 // Checks if Textbox is empty
            {                                                           // If so
                MessageBox.Show("Error. Please verify your input.");    // Show error message
            }

            if (Convert.ToInt16(txtWithdraw.Text) > 1000)
            {
                MessageBox.Show("Error. You can only withdraw less than 1000€");
            }
            else
            {
                float balance = float.Parse(konto.GetBalance(temp));    // Variable for storing the balance inside the file
                float withdraw = float.Parse(txtWithdraw.Text);         // Variable for storing the number from the textbox
                float result = balance - withdraw;                      // Subtract the withdraw from the balance
                txtCurrent.Text = result.ToString();                    // Fills the current balance Textbox with the result
                File.WriteAllText(temp, txtCurrent.Text);               // Saves the current balance to the file
                lblUpdate.Text = "+" + txtWithdraw.Text + "€";          // Changes the lbl to "- Input €"
                txtWithdraw.Text = "";                                  // Clears the Withdraw Textbox
                #region test
                /*   txtKontostand.Text = Convert.ToString(Convert.ToDecimal(konto.GetBalance(temp)) - Convert.ToDecimal(txtWithdraw.Text));

                   using (StreamWriter sw = new StreamWriter(temp))
                   {
                       sw.WriteLine(txtKontostand.Text);
                   }
                   float balance = konto.GetBalance(temp);
                   txtCurrent.Text = balance.ToString();
                   lblUpdate.Text = "-" + txtWithdraw.Text + "€";
                   txtWithdraw.Text = ""; */
                #endregion
            }
        }
        #endregion

        #region Exit Button
        private void btExit_Click(object sender, EventArgs e)
        {
            Environment.Exit(1);                                         // Closes the program
        }
        #endregion

        #region Create Button
        private void btCreate_Click(object sender, EventArgs e)
        {
            if (File.Exists(txtCreate.Text + ".txt"))                                // Check if file exists
            {                                                                        // If so
                MessageBox.Show("User already exists!");                             // Error if PIN / User exists
            }
             
            using (StreamWriter sw = new StreamWriter(txtCreate.Text + ".txt"))      // Create file with text input as name
            {                                                                   
                sw.WriteLine("0");                                                   // Set balance to 0
            }
            txtCreate.Text = "";                                                     // Clears the Textbox
            MessageBox.Show("User successfully created.");                            // Shows message that user got created

        }
        #endregion

        #region Delete Button
        private void btDelete_Click(object sender, EventArgs e)
        {
            if (File.Exists(txtDelete.Text + ".txt"))
            {
                File.Delete(txtDelete.Text + ".txt");
                MessageBox.Show("User successfully deleted!");
            }
            else if (!File.Exists(txtDelete.Text + ".txt"))
            {
                MessageBox.Show("Account doesn't exist!");
            }
        }
        #endregion

        #region Only Accept Numbers
        private void txtPin_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void txtWithdraw_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void txtDeposit_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void txtCreate_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void txtDelete_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }
        #endregion
    }
}
