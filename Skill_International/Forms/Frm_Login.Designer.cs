namespace Skill_International
{
    partial class FrmLogin
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
            this.pBx = new System.Windows.Forms.PictureBox();
            this.grpBx = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtUser = new System.Windows.Forms.TextBox();
            this.txtPass = new System.Windows.Forms.TextBox();
            this.panel = new System.Windows.Forms.Panel();
            this.BtnClear = new System.Windows.Forms.Button();
            this.BtnLogin = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pBx)).BeginInit();
            this.grpBx.SuspendLayout();
            this.panel.SuspendLayout();
            this.SuspendLayout();
            // 
            // pBx
            // 
            this.pBx.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pBx.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pBx.Image = global::Skill_International.Properties.Resources.logo;
            this.pBx.Location = new System.Drawing.Point(0, -1);
            this.pBx.Margin = new System.Windows.Forms.Padding(11, 13, 11, 13);
            this.pBx.Name = "pBx";
            this.pBx.Size = new System.Drawing.Size(284, 232);
            this.pBx.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pBx.TabIndex = 1;
            this.pBx.TabStop = false;
            // 
            // grpBx
            // 
            this.grpBx.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grpBx.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.grpBx.Controls.Add(this.label2);
            this.grpBx.Controls.Add(this.label1);
            this.grpBx.Controls.Add(this.txtUser);
            this.grpBx.Controls.Add(this.txtPass);
            this.grpBx.Controls.Add(this.panel);
            this.grpBx.Location = new System.Drawing.Point(17, 241);
            this.grpBx.Margin = new System.Windows.Forms.Padding(57, 67, 57, 67);
            this.grpBx.Name = "grpBx";
            this.grpBx.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.grpBx.Size = new System.Drawing.Size(249, 226);
            this.grpBx.TabIndex = 3;
            this.grpBx.TabStop = false;
            this.grpBx.Text = "Login";
            this.grpBx.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 28);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 20);
            this.label2.TabIndex = 6;
            this.label2.Text = "Username";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 96);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 20);
            this.label1.TabIndex = 6;
            this.label1.Text = "Password";
            // 
            // txtUser
            // 
            this.txtUser.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtUser.Location = new System.Drawing.Point(44, 52);
            this.txtUser.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtUser.Name = "txtUser";
            this.txtUser.Size = new System.Drawing.Size(184, 27);
            this.txtUser.TabIndex = 0;
            this.txtUser.Text = "Admin";
            this.txtUser.TextChanged += new System.EventHandler(this.txtUser_TextChanged);
            this.txtUser.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtUser_KeyPress);
            // 
            // txtPass
            // 
            this.txtPass.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtPass.Location = new System.Drawing.Point(44, 120);
            this.txtPass.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtPass.Name = "txtPass";
            this.txtPass.PasswordChar = '*';
            this.txtPass.Size = new System.Drawing.Size(184, 27);
            this.txtPass.TabIndex = 1;
            this.txtPass.Text = "Skills@123";
            this.txtPass.TextChanged += new System.EventHandler(this.txtPass_TextChanged);
            this.txtPass.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPass_KeyPress);
            // 
            // panel
            // 
            this.panel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel.Controls.Add(this.BtnClear);
            this.panel.Controls.Add(this.BtnLogin);
            this.panel.Location = new System.Drawing.Point(17, 161);
            this.panel.Name = "panel";
            this.panel.Size = new System.Drawing.Size(211, 61);
            this.panel.TabIndex = 7;
            // 
            // BtnClear
            // 
            this.BtnClear.AutoSize = true;
            this.BtnClear.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.BtnClear.Location = new System.Drawing.Point(13, 19);
            this.BtnClear.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.BtnClear.Name = "BtnClear";
            this.BtnClear.Size = new System.Drawing.Size(72, 30);
            this.BtnClear.TabIndex = 2;
            this.BtnClear.Text = "Clear";
            this.BtnClear.UseVisualStyleBackColor = true;
            // 
            // BtnLogin
            // 
            this.BtnLogin.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnLogin.AutoSize = true;
            this.BtnLogin.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.BtnLogin.Location = new System.Drawing.Point(125, 19);
            this.BtnLogin.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.BtnLogin.Name = "BtnLogin";
            this.BtnLogin.Size = new System.Drawing.Size(72, 30);
            this.BtnLogin.TabIndex = 2;
            this.BtnLogin.Text = "Login";
            this.BtnLogin.UseVisualStyleBackColor = true;
            this.BtnLogin.Click += new System.EventHandler(this.BtnLogin_Click);
            // 
            // FrmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(284, 483);
            this.Controls.Add(this.grpBx);
            this.Controls.Add(this.pBx);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.Name = "FrmLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmLogin_FormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FrmLogin_FormClosed);
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pBx)).EndInit();
            this.grpBx.ResumeLayout(false);
            this.grpBx.PerformLayout();
            this.panel.ResumeLayout(false);
            this.panel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private PictureBox pBx;
        private GroupBox grpBx;
        private TextBox txtUser;
        private TextBox txtPass;
        private Label label2;
        private Label label1;
        private Panel panel;
        private Button BtnClear;
        private Button BtnLogin;
    }
}