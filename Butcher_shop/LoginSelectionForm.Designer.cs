namespace Butcher_shop
{
    partial class LoginSelectionForm
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Button btnOwnerLogin;
        private System.Windows.Forms.Button btnEmployeeLogin;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel pnlCard;
        private System.Windows.Forms.Label lblSubtitle;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.btnOwnerLogin = new System.Windows.Forms.Button();
            this.btnEmployeeLogin = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.pnlCard = new System.Windows.Forms.Panel();
            this.lblSubtitle = new System.Windows.Forms.Label();
            this.pnlCard.SuspendLayout();
            this.SuspendLayout();

            // pnlCard
            this.pnlCard.BackColor = System.Drawing.Color.White;
            this.pnlCard.Controls.Add(this.label1);
            this.pnlCard.Controls.Add(this.lblSubtitle);
            this.pnlCard.Controls.Add(this.btnOwnerLogin);
            this.pnlCard.Controls.Add(this.btnEmployeeLogin);
            this.pnlCard.Location = new System.Drawing.Point(85, 60);
            this.pnlCard.Name = "pnlCard";
            this.pnlCard.Size = new System.Drawing.Size(430, 380);

            // label1
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Georgia", 26F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(40, 50);
            this.label1.Text = "System Access";

            // lblSubtitle
            this.lblSubtitle.AutoSize = true;
            this.lblSubtitle.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblSubtitle.ForeColor = System.Drawing.Color.FromArgb(100, 100, 100);
            this.lblSubtitle.Location = new System.Drawing.Point(45, 95);
            this.lblSubtitle.Text = "Please select your login type to continue";

            // btnOwnerLogin
            this.btnOwnerLogin.BackColor = System.Drawing.Color.FromArgb(255, 128, 0); // Orange
            this.btnOwnerLogin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnOwnerLogin.FlatAppearance.BorderSize = 0;
            this.btnOwnerLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOwnerLogin.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.btnOwnerLogin.ForeColor = System.Drawing.Color.White;
            this.btnOwnerLogin.Location = new System.Drawing.Point(45, 170);
            this.btnOwnerLogin.Size = new System.Drawing.Size(340, 50);
            this.btnOwnerLogin.Text = "Owner Login";
            this.btnOwnerLogin.UseVisualStyleBackColor = false;
            this.btnOwnerLogin.Click += new System.EventHandler(this.btnOwnerLogin_Click);
            this.btnOwnerLogin.Paint += new System.Windows.Forms.PaintEventHandler(this.PillButton_Paint);

            // btnEmployeeLogin
            this.btnEmployeeLogin.BackColor = System.Drawing.Color.FromArgb(0, 128, 96); // Dark Green
            this.btnEmployeeLogin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEmployeeLogin.FlatAppearance.BorderSize = 0;
            this.btnEmployeeLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEmployeeLogin.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.btnEmployeeLogin.ForeColor = System.Drawing.Color.White;
            this.btnEmployeeLogin.Location = new System.Drawing.Point(45, 240);
            this.btnEmployeeLogin.Size = new System.Drawing.Size(340, 50);
            this.btnEmployeeLogin.Text = "Employee Login";
            this.btnEmployeeLogin.UseVisualStyleBackColor = false;
            this.btnEmployeeLogin.Click += new System.EventHandler(this.btnEmployeeLogin_Click);
            this.btnEmployeeLogin.Paint += new System.Windows.Forms.PaintEventHandler(this.PillButton_Paint);

            // LoginSelectionForm
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(246, 246, 244);
            this.ClientSize = new System.Drawing.Size(600, 500);
            this.Controls.Add(this.pnlCard);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Butcher Shop Management";
            this.pnlCard.ResumeLayout(false);
            this.pnlCard.PerformLayout();
            this.ResumeLayout(false);
        }
    }
}