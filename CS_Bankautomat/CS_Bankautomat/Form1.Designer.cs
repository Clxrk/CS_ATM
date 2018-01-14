namespace CS_Bankautomat
{
    partial class Form1
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.tabControl = new System.Windows.Forms.TabControl();
            this.tabLogin = new System.Windows.Forms.TabPage();
            this.lblWrong = new System.Windows.Forms.Label();
            this.btLogin = new System.Windows.Forms.Button();
            this.lblPin = new System.Windows.Forms.Label();
            this.txtPin = new System.Windows.Forms.TextBox();
            this.tabLogout = new System.Windows.Forms.TabPage();
            this.btExit = new System.Windows.Forms.Button();
            this.btLogout = new System.Windows.Forms.Button();
            this.lblLogout = new System.Windows.Forms.Label();
            this.tabMain = new System.Windows.Forms.TabPage();
            this.label1 = new System.Windows.Forms.Label();
            this.lblUpdate = new System.Windows.Forms.Label();
            this.lbl500er = new System.Windows.Forms.Label();
            this.lbl200er = new System.Windows.Forms.Label();
            this.lbl100er = new System.Windows.Forms.Label();
            this.lbl50er = new System.Windows.Forms.Label();
            this.lbl20er = new System.Windows.Forms.Label();
            this.lbl10er = new System.Windows.Forms.Label();
            this.lblType500 = new System.Windows.Forms.Label();
            this.lblType200 = new System.Windows.Forms.Label();
            this.lblType100 = new System.Windows.Forms.Label();
            this.lblType50 = new System.Windows.Forms.Label();
            this.lblType20 = new System.Windows.Forms.Label();
            this.lblType10 = new System.Windows.Forms.Label();
            this.lblType5 = new System.Windows.Forms.Label();
            this.lbl5er = new System.Windows.Forms.Label();
            this.lblBanknotes = new System.Windows.Forms.Label();
            this.txtCurrent = new System.Windows.Forms.TextBox();
            this.lblCurrent = new System.Windows.Forms.Label();
            this.btWithdraw = new System.Windows.Forms.Button();
            this.txtWithdraw = new System.Windows.Forms.TextBox();
            this.lblWithdraw = new System.Windows.Forms.Label();
            this.btDeposit = new System.Windows.Forms.Button();
            this.txtDeposit = new System.Windows.Forms.TextBox();
            this.lblDeposit = new System.Windows.Forms.Label();
            this.lbBalance = new System.Windows.Forms.Label();
            this.btKontostand = new System.Windows.Forms.Button();
            this.txtKontostand = new System.Windows.Forms.TextBox();
            this.tabAdmin = new System.Windows.Forms.TabPage();
            this.listUsers = new System.Windows.Forms.ListBox();
            this.btDelete = new System.Windows.Forms.Button();
            this.txtDelete = new System.Windows.Forms.TextBox();
            this.lblDelete = new System.Windows.Forms.Label();
            this.lblCreate = new System.Windows.Forms.Label();
            this.txtCreate = new System.Windows.Forms.TextBox();
            this.btCreate = new System.Windows.Forms.Button();
            this.lblAccounts = new System.Windows.Forms.Label();
            this.tabControl.SuspendLayout();
            this.tabLogin.SuspendLayout();
            this.tabLogout.SuspendLayout();
            this.tabMain.SuspendLayout();
            this.tabAdmin.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.tabLogin);
            this.tabControl.Controls.Add(this.tabLogout);
            this.tabControl.Controls.Add(this.tabMain);
            this.tabControl.Controls.Add(this.tabAdmin);
            this.tabControl.Location = new System.Drawing.Point(0, 0);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(306, 288);
            this.tabControl.TabIndex = 0;
            // 
            // tabLogin
            // 
            this.tabLogin.Controls.Add(this.lblWrong);
            this.tabLogin.Controls.Add(this.btLogin);
            this.tabLogin.Controls.Add(this.lblPin);
            this.tabLogin.Controls.Add(this.txtPin);
            this.tabLogin.Location = new System.Drawing.Point(4, 22);
            this.tabLogin.Name = "tabLogin";
            this.tabLogin.Padding = new System.Windows.Forms.Padding(3);
            this.tabLogin.Size = new System.Drawing.Size(298, 262);
            this.tabLogin.TabIndex = 0;
            this.tabLogin.Text = "Login";
            this.tabLogin.UseVisualStyleBackColor = true;
            // 
            // lblWrong
            // 
            this.lblWrong.AutoSize = true;
            this.lblWrong.ForeColor = System.Drawing.Color.Red;
            this.lblWrong.Location = new System.Drawing.Point(70, 151);
            this.lblWrong.Name = "lblWrong";
            this.lblWrong.Size = new System.Drawing.Size(159, 13);
            this.lblWrong.TabIndex = 3;
            this.lblWrong.Text = "Wrong PIN or user doesn\'t exist!";
            this.lblWrong.Visible = false;
            // 
            // btLogin
            // 
            this.btLogin.Location = new System.Drawing.Point(112, 111);
            this.btLogin.Name = "btLogin";
            this.btLogin.Size = new System.Drawing.Size(69, 23);
            this.btLogin.TabIndex = 2;
            this.btLogin.Text = "Ok";
            this.btLogin.UseVisualStyleBackColor = true;
            this.btLogin.Click += new System.EventHandler(this.btLogin_Click);
            // 
            // lblPin
            // 
            this.lblPin.AutoSize = true;
            this.lblPin.Location = new System.Drawing.Point(89, 59);
            this.lblPin.Name = "lblPin";
            this.lblPin.Size = new System.Drawing.Size(113, 13);
            this.lblPin.TabIndex = 1;
            this.lblPin.Text = "Please enter your PIN:";
            // 
            // txtPin
            // 
            this.txtPin.Location = new System.Drawing.Point(92, 75);
            this.txtPin.Name = "txtPin";
            this.txtPin.PasswordChar = '*';
            this.txtPin.Size = new System.Drawing.Size(110, 20);
            this.txtPin.TabIndex = 0;
            this.txtPin.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtPin_KeyDown);
            this.txtPin.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPin_KeyPress);
            // 
            // tabLogout
            // 
            this.tabLogout.Controls.Add(this.btExit);
            this.tabLogout.Controls.Add(this.btLogout);
            this.tabLogout.Controls.Add(this.lblLogout);
            this.tabLogout.Location = new System.Drawing.Point(4, 22);
            this.tabLogout.Name = "tabLogout";
            this.tabLogout.Size = new System.Drawing.Size(298, 262);
            this.tabLogout.TabIndex = 2;
            this.tabLogout.Text = "Logout";
            this.tabLogout.UseVisualStyleBackColor = true;
            // 
            // btExit
            // 
            this.btExit.Location = new System.Drawing.Point(112, 140);
            this.btExit.Name = "btExit";
            this.btExit.Size = new System.Drawing.Size(75, 23);
            this.btExit.TabIndex = 2;
            this.btExit.Text = "Close";
            this.btExit.UseVisualStyleBackColor = true;
            this.btExit.Click += new System.EventHandler(this.btExit_Click);
            // 
            // btLogout
            // 
            this.btLogout.Location = new System.Drawing.Point(112, 95);
            this.btLogout.Name = "btLogout";
            this.btLogout.Size = new System.Drawing.Size(75, 23);
            this.btLogout.TabIndex = 1;
            this.btLogout.Text = "Logout";
            this.btLogout.UseVisualStyleBackColor = true;
            this.btLogout.Click += new System.EventHandler(this.btLogout_Click);
            // 
            // lblLogout
            // 
            this.lblLogout.AutoSize = true;
            this.lblLogout.Location = new System.Drawing.Point(63, 61);
            this.lblLogout.Name = "lblLogout";
            this.lblLogout.Size = new System.Drawing.Size(176, 13);
            this.lblLogout.TabIndex = 0;
            this.lblLogout.Text = "Thank you for using our application.";
            // 
            // tabMain
            // 
            this.tabMain.Controls.Add(this.label1);
            this.tabMain.Controls.Add(this.lblUpdate);
            this.tabMain.Controls.Add(this.lbl500er);
            this.tabMain.Controls.Add(this.lbl200er);
            this.tabMain.Controls.Add(this.lbl100er);
            this.tabMain.Controls.Add(this.lbl50er);
            this.tabMain.Controls.Add(this.lbl20er);
            this.tabMain.Controls.Add(this.lbl10er);
            this.tabMain.Controls.Add(this.lblType500);
            this.tabMain.Controls.Add(this.lblType200);
            this.tabMain.Controls.Add(this.lblType100);
            this.tabMain.Controls.Add(this.lblType50);
            this.tabMain.Controls.Add(this.lblType20);
            this.tabMain.Controls.Add(this.lblType10);
            this.tabMain.Controls.Add(this.lblType5);
            this.tabMain.Controls.Add(this.lbl5er);
            this.tabMain.Controls.Add(this.lblBanknotes);
            this.tabMain.Controls.Add(this.txtCurrent);
            this.tabMain.Controls.Add(this.lblCurrent);
            this.tabMain.Controls.Add(this.btWithdraw);
            this.tabMain.Controls.Add(this.txtWithdraw);
            this.tabMain.Controls.Add(this.lblWithdraw);
            this.tabMain.Controls.Add(this.btDeposit);
            this.tabMain.Controls.Add(this.txtDeposit);
            this.tabMain.Controls.Add(this.lblDeposit);
            this.tabMain.Controls.Add(this.lbBalance);
            this.tabMain.Controls.Add(this.btKontostand);
            this.tabMain.Controls.Add(this.txtKontostand);
            this.tabMain.Location = new System.Drawing.Point(4, 22);
            this.tabMain.Name = "tabMain";
            this.tabMain.Padding = new System.Windows.Forms.Padding(3);
            this.tabMain.Size = new System.Drawing.Size(298, 262);
            this.tabMain.TabIndex = 1;
            this.tabMain.Text = "Home";
            this.tabMain.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(207, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(30, 13);
            this.label1.TabIndex = 27;
            this.label1.Text = "Last:";
            // 
            // lblUpdate
            // 
            this.lblUpdate.AutoSize = true;
            this.lblUpdate.Location = new System.Drawing.Point(243, 58);
            this.lblUpdate.Name = "lblUpdate";
            this.lblUpdate.Size = new System.Drawing.Size(13, 13);
            this.lblUpdate.TabIndex = 26;
            this.lblUpdate.Text = "0";
            this.lblUpdate.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lbl500er
            // 
            this.lbl500er.AutoSize = true;
            this.lbl500er.Location = new System.Drawing.Point(8, 219);
            this.lbl500er.Name = "lbl500er";
            this.lbl500er.Size = new System.Drawing.Size(13, 13);
            this.lbl500er.TabIndex = 25;
            this.lbl500er.Text = "0";
            // 
            // lbl200er
            // 
            this.lbl200er.AutoSize = true;
            this.lbl200er.Location = new System.Drawing.Point(8, 206);
            this.lbl200er.Name = "lbl200er";
            this.lbl200er.Size = new System.Drawing.Size(13, 13);
            this.lbl200er.TabIndex = 24;
            this.lbl200er.Text = "0";
            // 
            // lbl100er
            // 
            this.lbl100er.AutoSize = true;
            this.lbl100er.Location = new System.Drawing.Point(8, 193);
            this.lbl100er.Name = "lbl100er";
            this.lbl100er.Size = new System.Drawing.Size(13, 13);
            this.lbl100er.TabIndex = 23;
            this.lbl100er.Text = "0";
            // 
            // lbl50er
            // 
            this.lbl50er.AutoSize = true;
            this.lbl50er.Location = new System.Drawing.Point(8, 180);
            this.lbl50er.Name = "lbl50er";
            this.lbl50er.Size = new System.Drawing.Size(13, 13);
            this.lbl50er.TabIndex = 22;
            this.lbl50er.Text = "0";
            // 
            // lbl20er
            // 
            this.lbl20er.AutoSize = true;
            this.lbl20er.Location = new System.Drawing.Point(8, 167);
            this.lbl20er.Name = "lbl20er";
            this.lbl20er.Size = new System.Drawing.Size(13, 13);
            this.lbl20er.TabIndex = 21;
            this.lbl20er.Text = "0";
            // 
            // lbl10er
            // 
            this.lbl10er.AutoSize = true;
            this.lbl10er.Location = new System.Drawing.Point(8, 154);
            this.lbl10er.Name = "lbl10er";
            this.lbl10er.Size = new System.Drawing.Size(13, 13);
            this.lbl10er.TabIndex = 20;
            this.lbl10er.Text = "0";
            // 
            // lblType500
            // 
            this.lblType500.AutoSize = true;
            this.lblType500.Location = new System.Drawing.Point(42, 219);
            this.lblType500.Name = "lblType500";
            this.lblType500.Size = new System.Drawing.Size(39, 13);
            this.lblType500.TabIndex = 19;
            this.lblType500.Text = "x 500€";
            // 
            // lblType200
            // 
            this.lblType200.AutoSize = true;
            this.lblType200.Location = new System.Drawing.Point(42, 206);
            this.lblType200.Name = "lblType200";
            this.lblType200.Size = new System.Drawing.Size(39, 13);
            this.lblType200.TabIndex = 18;
            this.lblType200.Text = "x 200€";
            // 
            // lblType100
            // 
            this.lblType100.AutoSize = true;
            this.lblType100.Location = new System.Drawing.Point(42, 193);
            this.lblType100.Name = "lblType100";
            this.lblType100.Size = new System.Drawing.Size(39, 13);
            this.lblType100.TabIndex = 17;
            this.lblType100.Text = "x 100€";
            // 
            // lblType50
            // 
            this.lblType50.AutoSize = true;
            this.lblType50.Location = new System.Drawing.Point(42, 180);
            this.lblType50.Name = "lblType50";
            this.lblType50.Size = new System.Drawing.Size(33, 13);
            this.lblType50.TabIndex = 16;
            this.lblType50.Text = "x 50€";
            // 
            // lblType20
            // 
            this.lblType20.AutoSize = true;
            this.lblType20.Location = new System.Drawing.Point(42, 167);
            this.lblType20.Name = "lblType20";
            this.lblType20.Size = new System.Drawing.Size(33, 13);
            this.lblType20.TabIndex = 15;
            this.lblType20.Text = "x 20€";
            // 
            // lblType10
            // 
            this.lblType10.AutoSize = true;
            this.lblType10.Location = new System.Drawing.Point(42, 154);
            this.lblType10.Name = "lblType10";
            this.lblType10.Size = new System.Drawing.Size(33, 13);
            this.lblType10.TabIndex = 14;
            this.lblType10.Text = "x 10€";
            // 
            // lblType5
            // 
            this.lblType5.AutoSize = true;
            this.lblType5.Location = new System.Drawing.Point(42, 141);
            this.lblType5.Name = "lblType5";
            this.lblType5.Size = new System.Drawing.Size(27, 13);
            this.lblType5.TabIndex = 13;
            this.lblType5.Text = "x 5€";
            // 
            // lbl5er
            // 
            this.lbl5er.AutoSize = true;
            this.lbl5er.Location = new System.Drawing.Point(8, 141);
            this.lbl5er.Name = "lbl5er";
            this.lbl5er.Size = new System.Drawing.Size(13, 13);
            this.lbl5er.TabIndex = 12;
            this.lbl5er.Text = "0";
            // 
            // lblBanknotes
            // 
            this.lblBanknotes.AutoSize = true;
            this.lblBanknotes.Location = new System.Drawing.Point(8, 118);
            this.lblBanknotes.Name = "lblBanknotes";
            this.lblBanknotes.Size = new System.Drawing.Size(61, 13);
            this.lblBanknotes.TabIndex = 11;
            this.lblBanknotes.Text = "Banknotes:";
            // 
            // txtCurrent
            // 
            this.txtCurrent.Location = new System.Drawing.Point(210, 27);
            this.txtCurrent.Name = "txtCurrent";
            this.txtCurrent.ReadOnly = true;
            this.txtCurrent.Size = new System.Drawing.Size(75, 20);
            this.txtCurrent.TabIndex = 10;
            // 
            // lblCurrent
            // 
            this.lblCurrent.AutoSize = true;
            this.lblCurrent.Location = new System.Drawing.Point(207, 11);
            this.lblCurrent.Name = "lblCurrent";
            this.lblCurrent.Size = new System.Drawing.Size(86, 13);
            this.lblCurrent.TabIndex = 9;
            this.lblCurrent.Text = "Current Balance:";
            // 
            // btWithdraw
            // 
            this.btWithdraw.Location = new System.Drawing.Point(8, 53);
            this.btWithdraw.Name = "btWithdraw";
            this.btWithdraw.Size = new System.Drawing.Size(75, 23);
            this.btWithdraw.TabIndex = 8;
            this.btWithdraw.Text = "Ok";
            this.btWithdraw.UseVisualStyleBackColor = true;
            this.btWithdraw.Click += new System.EventHandler(this.btWithdraw_Click);
            // 
            // txtWithdraw
            // 
            this.txtWithdraw.Location = new System.Drawing.Point(8, 27);
            this.txtWithdraw.Name = "txtWithdraw";
            this.txtWithdraw.Size = new System.Drawing.Size(75, 20);
            this.txtWithdraw.TabIndex = 7;
            this.txtWithdraw.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtWithdraw_KeyPress);
            // 
            // lblWithdraw
            // 
            this.lblWithdraw.AutoSize = true;
            this.lblWithdraw.Location = new System.Drawing.Point(5, 11);
            this.lblWithdraw.Name = "lblWithdraw";
            this.lblWithdraw.Size = new System.Drawing.Size(55, 13);
            this.lblWithdraw.TabIndex = 6;
            this.lblWithdraw.Text = "Withdraw:";
            // 
            // btDeposit
            // 
            this.btDeposit.Location = new System.Drawing.Point(109, 53);
            this.btDeposit.Name = "btDeposit";
            this.btDeposit.Size = new System.Drawing.Size(75, 23);
            this.btDeposit.TabIndex = 5;
            this.btDeposit.Text = "Ok";
            this.btDeposit.UseVisualStyleBackColor = true;
            this.btDeposit.Click += new System.EventHandler(this.btDeposit_Click);
            // 
            // txtDeposit
            // 
            this.txtDeposit.Location = new System.Drawing.Point(109, 27);
            this.txtDeposit.Name = "txtDeposit";
            this.txtDeposit.Size = new System.Drawing.Size(75, 20);
            this.txtDeposit.TabIndex = 4;
            this.txtDeposit.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtDeposit_KeyPress);
            // 
            // lblDeposit
            // 
            this.lblDeposit.AutoSize = true;
            this.lblDeposit.Location = new System.Drawing.Point(106, 11);
            this.lblDeposit.Name = "lblDeposit";
            this.lblDeposit.Size = new System.Drawing.Size(46, 13);
            this.lblDeposit.TabIndex = 3;
            this.lblDeposit.Text = "Deposit:";
            // 
            // lbBalance
            // 
            this.lbBalance.AutoSize = true;
            this.lbBalance.Enabled = false;
            this.lbBalance.Location = new System.Drawing.Point(219, 208);
            this.lbBalance.Name = "lbBalance";
            this.lbBalance.Size = new System.Drawing.Size(79, 13);
            this.lbBalance.TabIndex = 2;
            this.lbBalance.Text = "Show Balance:";
            this.lbBalance.Visible = false;
            // 
            // btKontostand
            // 
            this.btKontostand.Enabled = false;
            this.btKontostand.Location = new System.Drawing.Point(218, 243);
            this.btKontostand.Name = "btKontostand";
            this.btKontostand.Size = new System.Drawing.Size(75, 23);
            this.btKontostand.TabIndex = 1;
            this.btKontostand.Text = "Ok";
            this.btKontostand.UseVisualStyleBackColor = true;
            this.btKontostand.Visible = false;
            this.btKontostand.Click += new System.EventHandler(this.btKontostand_Click);
            // 
            // txtKontostand
            // 
            this.txtKontostand.Enabled = false;
            this.txtKontostand.Location = new System.Drawing.Point(218, 224);
            this.txtKontostand.Name = "txtKontostand";
            this.txtKontostand.ReadOnly = true;
            this.txtKontostand.Size = new System.Drawing.Size(75, 20);
            this.txtKontostand.TabIndex = 0;
            this.txtKontostand.Visible = false;
            // 
            // tabAdmin
            // 
            this.tabAdmin.Controls.Add(this.lblAccounts);
            this.tabAdmin.Controls.Add(this.listUsers);
            this.tabAdmin.Controls.Add(this.btDelete);
            this.tabAdmin.Controls.Add(this.txtDelete);
            this.tabAdmin.Controls.Add(this.lblDelete);
            this.tabAdmin.Controls.Add(this.lblCreate);
            this.tabAdmin.Controls.Add(this.txtCreate);
            this.tabAdmin.Controls.Add(this.btCreate);
            this.tabAdmin.Location = new System.Drawing.Point(4, 22);
            this.tabAdmin.Name = "tabAdmin";
            this.tabAdmin.Size = new System.Drawing.Size(298, 262);
            this.tabAdmin.TabIndex = 3;
            this.tabAdmin.Text = "Admin";
            this.tabAdmin.UseVisualStyleBackColor = true;
            // 
            // listUsers
            // 
            this.listUsers.FormattingEnabled = true;
            this.listUsers.Location = new System.Drawing.Point(8, 120);
            this.listUsers.Name = "listUsers";
            this.listUsers.Size = new System.Drawing.Size(279, 134);
            this.listUsers.TabIndex = 6;
            // 
            // btDelete
            // 
            this.btDelete.Location = new System.Drawing.Point(109, 53);
            this.btDelete.Name = "btDelete";
            this.btDelete.Size = new System.Drawing.Size(75, 23);
            this.btDelete.TabIndex = 5;
            this.btDelete.Text = "Ok";
            this.btDelete.UseVisualStyleBackColor = true;
            this.btDelete.Click += new System.EventHandler(this.btDelete_Click);
            // 
            // txtDelete
            // 
            this.txtDelete.Location = new System.Drawing.Point(109, 27);
            this.txtDelete.Name = "txtDelete";
            this.txtDelete.Size = new System.Drawing.Size(75, 20);
            this.txtDelete.TabIndex = 4;
            this.txtDelete.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtDelete_KeyPress);
            // 
            // lblDelete
            // 
            this.lblDelete.AutoSize = true;
            this.lblDelete.Location = new System.Drawing.Point(106, 11);
            this.lblDelete.Name = "lblDelete";
            this.lblDelete.Size = new System.Drawing.Size(66, 13);
            this.lblDelete.TabIndex = 3;
            this.lblDelete.Text = "Delete User:";
            // 
            // lblCreate
            // 
            this.lblCreate.AutoSize = true;
            this.lblCreate.Location = new System.Drawing.Point(8, 11);
            this.lblCreate.Name = "lblCreate";
            this.lblCreate.Size = new System.Drawing.Size(66, 13);
            this.lblCreate.TabIndex = 2;
            this.lblCreate.Text = "Create User:";
            // 
            // txtCreate
            // 
            this.txtCreate.Location = new System.Drawing.Point(8, 27);
            this.txtCreate.Name = "txtCreate";
            this.txtCreate.Size = new System.Drawing.Size(75, 20);
            this.txtCreate.TabIndex = 1;
            this.txtCreate.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCreate_KeyPress);
            // 
            // btCreate
            // 
            this.btCreate.Location = new System.Drawing.Point(8, 53);
            this.btCreate.Name = "btCreate";
            this.btCreate.Size = new System.Drawing.Size(75, 23);
            this.btCreate.TabIndex = 0;
            this.btCreate.Text = "Ok";
            this.btCreate.UseVisualStyleBackColor = true;
            this.btCreate.Click += new System.EventHandler(this.btCreate_Click);
            // 
            // lblAccounts
            // 
            this.lblAccounts.AutoSize = true;
            this.lblAccounts.Location = new System.Drawing.Point(5, 104);
            this.lblAccounts.Name = "lblAccounts";
            this.lblAccounts.Size = new System.Drawing.Size(101, 13);
            this.lblAccounts.TabIndex = 7;
            this.lblAccounts.Text = "Available Accounts:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(303, 288);
            this.Controls.Add(this.tabControl);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ATM";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabControl.ResumeLayout(false);
            this.tabLogin.ResumeLayout(false);
            this.tabLogin.PerformLayout();
            this.tabLogout.ResumeLayout(false);
            this.tabLogout.PerformLayout();
            this.tabMain.ResumeLayout(false);
            this.tabMain.PerformLayout();
            this.tabAdmin.ResumeLayout(false);
            this.tabAdmin.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage tabLogin;
        private System.Windows.Forms.TabPage tabMain;
        private System.Windows.Forms.Button btLogin;
        private System.Windows.Forms.Label lblPin;
        private System.Windows.Forms.TextBox txtPin;
        private System.Windows.Forms.TabPage tabLogout;
        private System.Windows.Forms.Button btLogout;
        private System.Windows.Forms.Label lblLogout;
        private System.Windows.Forms.Label lbBalance;
        private System.Windows.Forms.Button btKontostand;
        private System.Windows.Forms.TextBox txtKontostand;
        private System.Windows.Forms.Button btDeposit;
        private System.Windows.Forms.TextBox txtDeposit;
        private System.Windows.Forms.Label lblDeposit;
        private System.Windows.Forms.Button btWithdraw;
        private System.Windows.Forms.TextBox txtWithdraw;
        private System.Windows.Forms.Label lblWithdraw;
        private System.Windows.Forms.TextBox txtCurrent;
        private System.Windows.Forms.Label lblCurrent;
        private System.Windows.Forms.Button btExit;
        private System.Windows.Forms.Label lblWrong;
        private System.Windows.Forms.Label lblBanknotes;
        private System.Windows.Forms.Label lbl500er;
        private System.Windows.Forms.Label lbl200er;
        private System.Windows.Forms.Label lbl100er;
        private System.Windows.Forms.Label lbl50er;
        private System.Windows.Forms.Label lbl20er;
        private System.Windows.Forms.Label lbl10er;
        private System.Windows.Forms.Label lblType500;
        private System.Windows.Forms.Label lblType200;
        private System.Windows.Forms.Label lblType100;
        private System.Windows.Forms.Label lblType50;
        private System.Windows.Forms.Label lblType20;
        private System.Windows.Forms.Label lblType10;
        private System.Windows.Forms.Label lblType5;
        private System.Windows.Forms.Label lbl5er;
        private System.Windows.Forms.Label lblUpdate;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabPage tabAdmin;
        private System.Windows.Forms.Label lblCreate;
        private System.Windows.Forms.TextBox txtCreate;
        private System.Windows.Forms.Button btCreate;
        private System.Windows.Forms.Button btDelete;
        private System.Windows.Forms.TextBox txtDelete;
        private System.Windows.Forms.Label lblDelete;
        private System.Windows.Forms.ListBox listUsers;
        private System.Windows.Forms.Label lblAccounts;
    }
}

