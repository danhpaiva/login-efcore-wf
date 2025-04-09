namespace LoginEfCoreWf
{
    partial class f_login
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
            btn_login = new Button();
            tb_login = new TextBox();
            tb_senha = new TextBox();
            SuspendLayout();
            // 
            // btn_login
            // 
            btn_login.BackColor = Color.Transparent;
            btn_login.Cursor = Cursors.Hand;
            btn_login.FlatAppearance.MouseDownBackColor = Color.Transparent;
            btn_login.FlatAppearance.MouseOverBackColor = Color.Transparent;
            btn_login.FlatStyle = FlatStyle.Flat;
            btn_login.Location = new Point(298, 639);
            btn_login.Name = "btn_login";
            btn_login.Size = new Size(281, 60);
            btn_login.TabIndex = 0;
            btn_login.UseVisualStyleBackColor = false;
            btn_login.Click += btn_login_Click;
            // 
            // tb_login
            // 
            tb_login.BorderStyle = BorderStyle.None;
            tb_login.Cursor = Cursors.Hand;
            tb_login.Font = new Font("Segoe UI", 32.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tb_login.Location = new Point(239, 391);
            tb_login.Name = "tb_login";
            tb_login.Size = new Size(466, 58);
            tb_login.TabIndex = 1;
            // 
            // tb_senha
            // 
            tb_senha.BorderStyle = BorderStyle.None;
            tb_senha.Cursor = Cursors.Hand;
            tb_senha.Font = new Font("Segoe UI", 32.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tb_senha.Location = new Point(239, 484);
            tb_senha.Name = "tb_senha";
            tb_senha.Size = new Size(465, 58);
            tb_senha.TabIndex = 2;
            tb_senha.UseSystemPasswordChar = true;
            // 
            // f_login
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources._1036677_6719;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(884, 861);
            Controls.Add(tb_senha);
            Controls.Add(tb_login);
            Controls.Add(btn_login);
            MaximizeBox = false;
            Name = "f_login";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Login - EfCore";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btn_login;
        private TextBox tb_login;
        private TextBox tb_senha;
    }
}
