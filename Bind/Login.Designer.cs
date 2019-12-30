namespace Bind
{
    partial class LogIn
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LogIn));
            this.Title = new System.Windows.Forms.Label();
            this.IdBox = new System.Windows.Forms.TextBox();
            this.PsBox = new System.Windows.Forms.TextBox();
            this.Id_Title = new System.Windows.Forms.Label();
            this.Ps_Title = new System.Windows.Forms.Label();
            this.Login_Button = new System.Windows.Forms.Button();
            this.SignUp_Button = new System.Windows.Forms.Button();
            this.FindPs_Button = new System.Windows.Forms.Button();
            this.Info_Button = new System.Windows.Forms.Button();
            this.Sponsor = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Title
            // 
            resources.ApplyResources(this.Title, "Title");
            this.Title.Name = "Title";
            // 
            // IdBox
            // 
            this.IdBox.AutoCompleteCustomSource.AddRange(new string[] {
            resources.GetString("IdBox.AutoCompleteCustomSource")});
            this.IdBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.IdBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            resources.ApplyResources(this.IdBox, "IdBox");
            this.IdBox.Name = "IdBox";
            // 
            // PsBox
            // 
            resources.ApplyResources(this.PsBox, "PsBox");
            this.PsBox.Name = "PsBox";
            // 
            // Id_Title
            // 
            resources.ApplyResources(this.Id_Title, "Id_Title");
            this.Id_Title.Name = "Id_Title";
            // 
            // Ps_Title
            // 
            resources.ApplyResources(this.Ps_Title, "Ps_Title");
            this.Ps_Title.Name = "Ps_Title";
            // 
            // Login_Button
            // 
            resources.ApplyResources(this.Login_Button, "Login_Button");
            this.Login_Button.Name = "Login_Button";
            this.Login_Button.UseVisualStyleBackColor = true;
            this.Login_Button.Click += new System.EventHandler(this.Login_Button_Click);
            // 
            // SignUp_Button
            // 
            resources.ApplyResources(this.SignUp_Button, "SignUp_Button");
            this.SignUp_Button.Name = "SignUp_Button";
            this.SignUp_Button.UseVisualStyleBackColor = true;
            this.SignUp_Button.Click += new System.EventHandler(this.SignUp_Button_Click);
            // 
            // FindPs_Button
            // 
            resources.ApplyResources(this.FindPs_Button, "FindPs_Button");
            this.FindPs_Button.Name = "FindPs_Button";
            this.FindPs_Button.UseVisualStyleBackColor = true;
            this.FindPs_Button.Click += new System.EventHandler(this.FindPs_Button_Click);
            // 
            // Info_Button
            // 
            resources.ApplyResources(this.Info_Button, "Info_Button");
            this.Info_Button.Name = "Info_Button";
            this.Info_Button.UseVisualStyleBackColor = true;
            this.Info_Button.Click += new System.EventHandler(this.Info_Button_Click);
            // 
            // Sponsor
            // 
            resources.ApplyResources(this.Sponsor, "Sponsor");
            this.Sponsor.Name = "Sponsor";
            this.Sponsor.UseVisualStyleBackColor = true;
            this.Sponsor.Click += new System.EventHandler(this.Sponsor_Click);
            // 
            // LogIn
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.Sponsor);
            this.Controls.Add(this.Info_Button);
            this.Controls.Add(this.FindPs_Button);
            this.Controls.Add(this.SignUp_Button);
            this.Controls.Add(this.Login_Button);
            this.Controls.Add(this.Ps_Title);
            this.Controls.Add(this.Id_Title);
            this.Controls.Add(this.PsBox);
            this.Controls.Add(this.IdBox);
            this.Controls.Add(this.Title);
            this.Name = "LogIn";
            this.Load += new System.EventHandler(this.LogIn_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Title;
        private System.Windows.Forms.TextBox IdBox;
        private System.Windows.Forms.TextBox PsBox;
        private System.Windows.Forms.Label Id_Title;
        private System.Windows.Forms.Label Ps_Title;
        private System.Windows.Forms.Button Login_Button;
        private System.Windows.Forms.Button SignUp_Button;
        private System.Windows.Forms.Button FindPs_Button;
        private System.Windows.Forms.Button Info_Button;
        private System.Windows.Forms.Button Sponsor;
    }
}

