namespace Activity3_DeDios
{
    partial class SignInForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.RegButton = new System.Windows.Forms.Button();
            this.SignBut = new System.Windows.Forms.Button();
            this.Passbox = new System.Windows.Forms.TextBox();
            this.Userbox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel1.BackColor = System.Drawing.Color.PeachPuff;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.RegButton);
            this.panel1.Controls.Add(this.SignBut);
            this.panel1.Controls.Add(this.Passbox);
            this.panel1.Controls.Add(this.Userbox);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(215, 144);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(878, 669);
            this.panel1.TabIndex = 0;
            // 
            // RegButton
            // 
            this.RegButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.RegButton.BackColor = System.Drawing.Color.PeachPuff;
            this.RegButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.RegButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.RegButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RegButton.Location = new System.Drawing.Point(219, 579);
            this.RegButton.Name = "RegButton";
            this.RegButton.Size = new System.Drawing.Size(478, 59);
            this.RegButton.TabIndex = 8;
            this.RegButton.Text = "Don\'t have a account? Register Here.";
            this.RegButton.UseVisualStyleBackColor = false;
            this.RegButton.Click += new System.EventHandler(this.RegButton_Click);
            // 
            // SignBut
            // 
            this.SignBut.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.SignBut.BackColor = System.Drawing.Color.Coral;
            this.SignBut.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SignBut.Location = new System.Drawing.Point(352, 514);
            this.SignBut.Name = "SignBut";
            this.SignBut.Size = new System.Drawing.Size(201, 59);
            this.SignBut.TabIndex = 7;
            this.SignBut.Text = "Sign In";
            this.SignBut.UseVisualStyleBackColor = false;
            this.SignBut.Click += new System.EventHandler(this.SignBut_Click);
            // 
            // Passbox
            // 
            this.Passbox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Passbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Passbox.Location = new System.Drawing.Point(128, 435);
            this.Passbox.Name = "Passbox";
            this.Passbox.Size = new System.Drawing.Size(635, 53);
            this.Passbox.TabIndex = 6;
            // 
            // Userbox
            // 
            this.Userbox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Userbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Userbox.Location = new System.Drawing.Point(128, 300);
            this.Userbox.Name = "Userbox";
            this.Userbox.Size = new System.Drawing.Size(635, 53);
            this.Userbox.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.PeachPuff;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(120, 371);
            this.label5.Name = "label5";
            this.label5.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label5.Size = new System.Drawing.Size(216, 46);
            this.label5.TabIndex = 4;
            this.label5.Text = "Password:";
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.PeachPuff;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(120, 239);
            this.label4.Name = "label4";
            this.label4.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label4.Size = new System.Drawing.Size(223, 46);
            this.label4.TabIndex = 3;
            this.label4.Text = "Username:";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.PeachPuff;
            this.label3.Font = new System.Drawing.Font("SimSun-ExtG", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(275, 186);
            this.label3.Name = "label3";
            this.label3.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label3.Size = new System.Drawing.Size(362, 28);
            this.label3.TabIndex = 2;
            this.label3.Text = "sign in into your account";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.PeachPuff;
            this.label2.Font = new System.Drawing.Font("SimSun-ExtG", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(342, 78);
            this.label2.Name = "label2";
            this.label2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label2.Size = new System.Drawing.Size(211, 60);
            this.label2.TabIndex = 1;
            this.label2.Text = "System";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.PeachPuff;
            this.label1.Font = new System.Drawing.Font("SimSun-ExtG", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(118, 18);
            this.label1.Name = "label1";
            this.label1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label1.Size = new System.Drawing.Size(645, 60);
            this.label1.TabIndex = 0;
            this.label1.Text = "Inventory Management";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // SignInForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Tan;
            this.ClientSize = new System.Drawing.Size(1311, 943);
            this.Controls.Add(this.panel1);
            this.Name = "SignInForm";
            this.Text = "Sign In";
            this.TopMost = true;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox Userbox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox Passbox;
        private System.Windows.Forms.Button SignBut;
        private System.Windows.Forms.Button RegButton;
    }
}

