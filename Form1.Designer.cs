namespace ExpenseTrackerApp
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
            LblTitle = new Label();
            walletsControl1 = new WalletsControl();
            walletBalanceControl1 = new WalletBalanceControl();
            panel1 = new Panel();
            SuspendLayout();
            // 
            // LblTitle
            // 
            LblTitle.AutoSize = true;
            LblTitle.Location = new Point(228, 19);
            LblTitle.Name = "LblTitle";
            LblTitle.Size = new Size(262, 30);
            LblTitle.TabIndex = 0;
            LblTitle.Text = "Expense tracker dashboard";
            // 
            // walletsControl1
            // 
            walletsControl1.Location = new Point(12, 51);
            walletsControl1.Name = "walletsControl1";
            walletsControl1.Size = new Size(177, 353);
            walletsControl1.TabIndex = 1;
            // 
            // walletBalanceControl1
            // 
            walletBalanceControl1.BackColor = Color.White;
            walletBalanceControl1.CurrentWallet = 0;
            walletBalanceControl1.Location = new Point(228, 87);
            walletBalanceControl1.Name = "walletBalanceControl1";
            walletBalanceControl1.Size = new Size(442, 247);
            walletBalanceControl1.TabIndex = 2;
            // 
            // panel1
            // 
            panel1.Location = new Point(45, 298);
            panel1.Name = "panel1";
            panel1.Size = new Size(117, 117);
            panel1.TabIndex = 3;
            panel1.Paint += panel1_Paint;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(12F, 30F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(760, 416);
            Controls.Add(panel1);
            Controls.Add(walletBalanceControl1);
            Controls.Add(walletsControl1);
            Controls.Add(LblTitle);
            Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(5, 6, 5, 6);
            Name = "Form1";
            Text = "Expense Tracker";
            TransparencyKey = Color.White;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label LblTitle;
        private WalletsControl walletsControl1;
        private WalletBalanceControl walletBalanceControl1;
        private Panel panel1;
    }
}
