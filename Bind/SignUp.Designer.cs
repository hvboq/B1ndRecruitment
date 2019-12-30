namespace Bind
{
    partial class SignUp
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
            this.Title = new System.Windows.Forms.Label();
            this.Ps_Title = new System.Windows.Forms.Label();
            this.Id_Title = new System.Windows.Forms.Label();
            this.PsBox = new System.Windows.Forms.TextBox();
            this.IdBox = new System.Windows.Forms.TextBox();
            this.SignUp_Button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Title
            // 
            this.Title.AutoSize = true;
            this.Title.Font = new System.Drawing.Font("나눔고딕", 27.75F);
            this.Title.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.Title.Location = new System.Drawing.Point(87, 27);
            this.Title.Name = "Title";
            this.Title.Size = new System.Drawing.Size(159, 43);
            this.Title.TabIndex = 1;
            this.Title.Text = "회원가입";
            // 
            // Ps_Title
            // 
            this.Ps_Title.AutoSize = true;
            this.Ps_Title.Font = new System.Drawing.Font("나눔고딕", 14.25F);
            this.Ps_Title.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.Ps_Title.Location = new System.Drawing.Point(11, 150);
            this.Ps_Title.Name = "Ps_Title";
            this.Ps_Title.Size = new System.Drawing.Size(31, 21);
            this.Ps_Title.TabIndex = 8;
            this.Ps_Title.Text = "PS";
            // 
            // Id_Title
            // 
            this.Id_Title.AutoSize = true;
            this.Id_Title.Font = new System.Drawing.Font("나눔고딕", 14.25F);
            this.Id_Title.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.Id_Title.Location = new System.Drawing.Point(14, 106);
            this.Id_Title.Name = "Id_Title";
            this.Id_Title.Size = new System.Drawing.Size(29, 21);
            this.Id_Title.TabIndex = 7;
            this.Id_Title.Text = "ID";
            // 
            // PsBox
            // 
            this.PsBox.Font = new System.Drawing.Font("나눔고딕", 14.25F);
            this.PsBox.Location = new System.Drawing.Point(54, 150);
            this.PsBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.PsBox.Name = "PsBox";
            this.PsBox.PasswordChar = '*';
            this.PsBox.Size = new System.Drawing.Size(257, 29);
            this.PsBox.TabIndex = 6;
            // 
            // IdBox
            // 
            this.IdBox.Font = new System.Drawing.Font("나눔고딕", 14.25F);
            this.IdBox.Location = new System.Drawing.Point(54, 102);
            this.IdBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.IdBox.Name = "IdBox";
            this.IdBox.Size = new System.Drawing.Size(257, 29);
            this.IdBox.TabIndex = 5;
            // 
            // SignUp_Button
            // 
            this.SignUp_Button.Font = new System.Drawing.Font("나눔고딕", 15.75F);
            this.SignUp_Button.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.SignUp_Button.Location = new System.Drawing.Point(33, 207);
            this.SignUp_Button.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.SignUp_Button.Name = "SignUp_Button";
            this.SignUp_Button.Size = new System.Drawing.Size(280, 41);
            this.SignUp_Button.TabIndex = 9;
            this.SignUp_Button.Text = "회원가입";
            this.SignUp_Button.UseVisualStyleBackColor = true;
            this.SignUp_Button.Click += new System.EventHandler(this.SignUp_Button_Click_1);
            // 
            // SignUp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(324, 261);
            this.Controls.Add(this.SignUp_Button);
            this.Controls.Add(this.Ps_Title);
            this.Controls.Add(this.Id_Title);
            this.Controls.Add(this.PsBox);
            this.Controls.Add(this.IdBox);
            this.Controls.Add(this.Title);
            this.Font = new System.Drawing.Font("나눔고딕", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "SignUp";
            this.Text = "D_SignUp";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Title;
        private System.Windows.Forms.Label Ps_Title;
        private System.Windows.Forms.Label Id_Title;
        private System.Windows.Forms.TextBox PsBox;
        private System.Windows.Forms.TextBox IdBox;
        private System.Windows.Forms.Button SignUp_Button;
    }
}