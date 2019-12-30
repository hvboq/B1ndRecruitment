namespace Bind
{
    partial class print
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
            this.components = new System.ComponentModel.Container();
            this.ListView = new System.Windows.Forms.DataGridView();
            this.daySaveBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.LoadButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.ListView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.daySaveBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // ListView
            // 
            this.ListView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ListView.Location = new System.Drawing.Point(12, 69);
            this.ListView.Name = "ListView";
            this.ListView.RowTemplate.Height = 23;
            this.ListView.Size = new System.Drawing.Size(633, 380);
            this.ListView.TabIndex = 0;
            // 
            // daySaveBindingSource
            // 
            this.daySaveBindingSource.DataSource = typeof(Bind.Main.DaySave);
            // 
            // LoadButton
            // 
            this.LoadButton.Location = new System.Drawing.Point(12, 12);
            this.LoadButton.Name = "LoadButton";
            this.LoadButton.Size = new System.Drawing.Size(633, 40);
            this.LoadButton.TabIndex = 1;
            this.LoadButton.Text = "다시불러오기";
            this.LoadButton.UseVisualStyleBackColor = true;
            this.LoadButton.Click += new System.EventHandler(this.LoadButton_Click);
            // 
            // print
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(657, 461);
            this.Controls.Add(this.LoadButton);
            this.Controls.Add(this.ListView);
            this.Font = new System.Drawing.Font("나눔고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "print";
            this.Text = "print";
            ((System.ComponentModel.ISupportInitialize)(this.ListView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.daySaveBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView ListView;
        private System.Windows.Forms.BindingSource daySaveBindingSource;
        private System.Windows.Forms.Button LoadButton;
    }
}