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
            textBox1 = new TextBox();
            textBox2 = new TextBox();
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
            // 
            // textBox1
            // 
            textBox1.BorderStyle = BorderStyle.None;
            textBox1.Cursor = Cursors.Hand;
            textBox1.Font = new Font("Segoe UI", 32.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox1.Location = new Point(239, 391);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(466, 58);
            textBox1.TabIndex = 1;
            // 
            // textBox2
            // 
            textBox2.BorderStyle = BorderStyle.None;
            textBox2.Cursor = Cursors.Hand;
            textBox2.Font = new Font("Segoe UI", 32.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox2.Location = new Point(239, 484);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(465, 58);
            textBox2.TabIndex = 2;
            textBox2.UseSystemPasswordChar = true;
            // 
            // f_login
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources._1036677_6719;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(884, 861);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
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
        private TextBox textBox1;
        private TextBox textBox2;
    }
}
