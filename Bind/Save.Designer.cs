namespace Bind
{
    partial class Save
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
            this.TitleBox = new System.Windows.Forms.TextBox();
            this.ContentsBox = new System.Windows.Forms.TextBox();
            this.Contents = new System.Windows.Forms.Label();
            this.savebutton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Title
            // 
            this.Title.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Title.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Title.Font = new System.Drawing.Font("나눔고딕", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.Title.Location = new System.Drawing.Point(13, 7);
            this.Title.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Title.Name = "Title";
            this.Title.Size = new System.Drawing.Size(107, 46);
            this.Title.TabIndex = 0;
            this.Title.Text = "제목";
            this.Title.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // TitleBox
            // 
            this.TitleBox.Font = new System.Drawing.Font("나눔고딕", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.TitleBox.Location = new System.Drawing.Point(127, 12);
            this.TitleBox.Name = "TitleBox";
            this.TitleBox.Size = new System.Drawing.Size(185, 39);
            this.TitleBox.TabIndex = 1;
            // 
            // ContentsBox
            // 
            this.ContentsBox.Font = new System.Drawing.Font("나눔고딕", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.ContentsBox.Location = new System.Drawing.Point(127, 72);
            this.ContentsBox.Multiline = true;
            this.ContentsBox.Name = "ContentsBox";
            this.ContentsBox.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.ContentsBox.Size = new System.Drawing.Size(185, 232);
            this.ContentsBox.TabIndex = 2;
            // 
            // Contents
            // 
            this.Contents.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Contents.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Contents.Font = new System.Drawing.Font("나눔고딕", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.Contents.Location = new System.Drawing.Point(13, 72);
            this.Contents.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Contents.Name = "Contents";
            this.Contents.Size = new System.Drawing.Size(107, 232);
            this.Contents.TabIndex = 3;
            this.Contents.Text = "내용";
            this.Contents.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // savebutton
            // 
            this.savebutton.Font = new System.Drawing.Font("나눔고딕", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.savebutton.Location = new System.Drawing.Point(13, 323);
            this.savebutton.Name = "savebutton";
            this.savebutton.Size = new System.Drawing.Size(299, 37);
            this.savebutton.TabIndex = 4;
            this.savebutton.Text = "저장";
            this.savebutton.UseVisualStyleBackColor = true;
            this.savebutton.Click += new System.EventHandler(this.savebutton_Click);
            // 
            // Save
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(324, 372);
            this.Controls.Add(this.savebutton);
            this.Controls.Add(this.Contents);
            this.Controls.Add(this.ContentsBox);
            this.Controls.Add(this.TitleBox);
            this.Controls.Add(this.Title);
            this.Font = new System.Drawing.Font("나눔고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Save";
            this.Text = "Save";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Title;
        private System.Windows.Forms.TextBox TitleBox;
        private System.Windows.Forms.TextBox ContentsBox;
        private System.Windows.Forms.Label Contents;
        private System.Windows.Forms.Button savebutton;
    }
}