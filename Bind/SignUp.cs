using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bind
{
    public partial class SignUp : Form
    {
        private LogIn LogIn;
        private LogIn.Log tempLog;
        public SignUp(LogIn log)
        {
            LogIn = log;
            tempLog = new LogIn.Log();
            InitializeComponent();
        }

        private void SignUp_Button_Click_1(object sender, EventArgs e)
        {
            foreach (LogIn.Log temp in LogIn.logList)
            {
                if (temp.Id == IdBox.Text)
                {
                    MessageBox.Show("중복된 ID가 존재합니다.", "오류",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }
            try 
            {
                tempLog.Id = IdBox.Text;
                tempLog.Ps = PsBox.Text;
            }

            catch(Exception ex) {
                MessageBox.Show(ex.StackTrace, "오류",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            if (string.IsNullOrWhiteSpace(tempLog.Id) || string.IsNullOrWhiteSpace(tempLog.Ps))
                return;
            LogIn.logList.Add(tempLog);
            LogIn.aComplSource.Add(tempLog.Id);
            MessageBox.Show("회원가입이 완료 되었습니다.", "회원가입");
            this.Hide();
            this.Close();
        }
    }
}
