namespace Bind
{
    partial class Main
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
            this.Save = new System.Windows.Forms.Button();
            this.Read = new System.Windows.Forms.Button();
            this.LogOut = new System.Windows.Forms.Button();
            this.Log = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Save
            // 
            this.Save.Font = new System.Drawing.Font("나눔고딕", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.Save.Location = new System.Drawing.Point(12, 47);
            this.Save.Name = "Save";
            this.Save.Size = new System.Drawing.Size(301, 127);
            this.Save.TabIndex = 0;
            this.Save.Text = "일기 기록";
            this.Save.UseVisualStyleBackColor = true;
            this.Save.Click += new System.EventHandler(this.Save_Click);
            // 
            // Read
            // 
            this.Read.Font = new System.Drawing.Font("나눔고딕", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.Read.Location = new System.Drawing.Point(12, 180);
            this.Read.Name = "Read";
            this.Read.Size = new System.Drawing.Size(301, 129);
            this.Read.TabIndex = 1;
            this.Read.Text = "일기 보기";
            this.Read.UseVisualStyleBackColor = true;
            this.Read.Click += new System.EventHandler(this.Read_Click);
            // 
            // LogOut
            // 
            this.LogOut.Font = new System.Drawing.Font("나눔고딕", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.LogOut.Location = new System.Drawing.Point(12, 342);
            this.LogOut.Name = "LogOut";
            this.LogOut.Size = new System.Drawing.Size(301, 69);
            this.LogOut.TabIndex = 2;
            this.LogOut.Text = "LogOut";
            this.LogOut.UseVisualStyleBackColor = true;
            this.LogOut.Click += new System.EventHandler(this.LogOut_Click);
            // 
            // Log
            // 
            this.Log.AutoSize = true;
            this.Log.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Log.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Log.Font = new System.Drawing.Font("나눔고딕", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.Log.Location = new System.Drawing.Point(35, 9);
            this.Log.Name = "Log";
            this.Log.Size = new System.Drawing.Size(66, 23);
            this.Log.TabIndex = 3;
            this.Log.Text = "label1";
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(324, 421);
            this.Controls.Add(this.Log);
            this.Controls.Add(this.LogOut);
            this.Controls.Add(this.Read);
            this.Controls.Add(this.Save);
            this.Font = new System.Drawing.Font("나눔고딕", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.Name = "Main";
            this.Text = "D_Main";
            this.Load += new System.EventHandler(this.Main_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Save;
        private System.Windows.Forms.Button Read;
        private System.Windows.Forms.Button LogOut;
        private System.Windows.Forms.Label Log;
    }
}