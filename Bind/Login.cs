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

    public partial class LogIn : Form
    {

        public class Log
        {
            private string _id;
            public string Id
            {
                get
                {
                    return _id;
                }
                set
                {
                    if (string.IsNullOrWhiteSpace(value))
                    {
                        MessageBox.Show("id를 입력하여 주십시오.", "오류",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    _id = value;
                }
            }

            private string _ps;
            public string Ps
            {

                get
                {
                    return _ps;
                }
                
                set
                {
                    if (string.IsNullOrWhiteSpace(value))
                    {
                        MessageBox.Show("패스워드를 입력하여 주십시오.", "오류",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    else if (value.Length < 6)
                    {
                        MessageBox.Show("비밀번호의 길이가 6보다 짧습니다.", "오류",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    _ps = value;
                }
            }
        }

        public List<Log> logList; //전체 계정 목록입니다.
        public Log tempLog = new Log(); // 회원가입 에서 사용할 Log 입니다.
        public AutoCompleteStringCollection aComplSource = new AutoCompleteStringCollection(); //회원가입시 사용할 자동완성 기능의 소스 입니다.
        public List<Main.DaySave> daySaves;
        public LogIn()
        {
            logList = new List<Log>();
            tempLog.Id = "root";
            tempLog.Ps = "12345678";
            logList.Add(tempLog);

            this.daySaves = null;

            InitializeComponent();
        }

        public LogIn(List<Log> logs, List<Main.DaySave> daySaves) 
        {
            this.logList = logs;
            this.daySaves = daySaves;

            InitializeComponent();
        }
        private void LogIn_Load(object sender, EventArgs e)
        {
            foreach (Log temp in logList)
            {
                aComplSource.Add(temp.Id);
            }
            IdBox.AutoCompleteCustomSource = aComplSource;
        }
        private void Login_Button_Click(object sender, EventArgs e)
        {
            foreach (Log temp in logList)
            {
                if (temp.Id == IdBox.Text && temp.Ps == PsBox.Text)
                {
                    MessageBox.Show("로그인에 성공하였습니다.", "로그인 성공",
                MessageBoxButtons.OK, MessageBoxIcon.None);
                    this.Hide();
                    Main main = new Main(logList, temp.Id, daySaves);
                    main.ShowDialog();
                    Program.ac.MainForm = main ;
                    this.Close();
                    return;
                }
            }
            MessageBox.Show("다시 확인해주세요.", "로그인 실패",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        private void Info_Button_Click(object sender, EventArgs e)
        {
            MessageBox.Show("이 프로그램은 안드로이드에 존재하는 한줄 일기와 같은 기능을" +
                "가지는 프로그램 입니다.", "프로그램 정보",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void Sponsor_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://op-op.tistory.com/");
        }

        private void SignUp_Button_Click(object sender, EventArgs e)
        {
            tempLog = new Log();
            new SignUp(this).Show();
        }

        private void FindPs_Button_Click(object sender, EventArgs e)
        {
            string knowId = Microsoft.VisualBasic.Interaction.InputBox(
                "ID를 입력해주세요.", "비밀번호 찾기");
            foreach (Log temp in logList)
            {
                if (temp.Id == knowId)
                {
                    MessageBox.Show($"ID {temp.Id}의 비밀번호는 {temp.Ps} 입니다.", "비밀번호 찾기",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
            }
            MessageBox.Show($"해당하는 ID {knowId}가 존재하지 않습니다.", "오류",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}
