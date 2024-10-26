namespace Bank_Account_Project_
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            button1 = new Button();
            Deposit = new Button();
            Withdraw = new Button();
            ListBoxTransactions = new ListBox();
            SuspendLayout();
            // 
            // button1
            // 
            button1.AccessibleName = "Amount";
            button1.Location = new Point(264, 247);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 0;
            button1.Text = "Amount";
            button1.UseVisualStyleBackColor = true;
            // 
            // Deposit
            // 
            Deposit.AccessibleDescription = "";
            Deposit.AccessibleName = "Deposit";
            Deposit.Location = new Point(264, 163);
            Deposit.Name = "Deposit";
            Deposit.Size = new Size(94, 29);
            Deposit.TabIndex = 1;
            Deposit.Text = "Deposit";
            Deposit.UseVisualStyleBackColor = true;
            // 
            // Withdraw
            // 
            Withdraw.AccessibleDescription = "Withdraw";
            Withdraw.AccessibleName = "Withdraw";
            Withdraw.Location = new Point(264, 80);
            Withdraw.Name = "Withdraw";
            Withdraw.Size = new Size(94, 29);
            Withdraw.TabIndex = 2;
            Withdraw.Text = "Withdraw";
            Withdraw.UseVisualStyleBackColor = true;
            // 
            // ListBoxTransactions
            // 
            ListBoxTransactions.AccessibleDescription = "ListBoxTransactions";
            ListBoxTransactions.AccessibleName = "ListBoxTransactions";
            ListBoxTransactions.FormattingEnabled = true;
            ListBoxTransactions.Location = new Point(12, 12);
            ListBoxTransactions.Name = "ListBoxTransactions";
            ListBoxTransactions.Size = new Size(140, 324);
            ListBoxTransactions.TabIndex = 3;
            ListBoxTransactions.SelectedIndexChanged += ListBoxTransactions_SelectedIndexChanged;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(ListBoxTransactions);
            Controls.Add(Withdraw);
            Controls.Add(Deposit);
            Controls.Add(button1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
        }

        #endregion

        private Button button1;
        private Button Deposit;
        private Button Withdraw;
        private ListBox ListBoxTransactions;
    }
}
