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
    
    public partial class Main : Form
    {
        public class DaySave
        {
            public string iD;
            public string date;
            public string title;
            public string Contents;
        }

        public List<DaySave> DaySaves;

        private List <LogIn.Log> tempLoglist;
        public string ID;

        public Main(List<LogIn.Log> tempLoglist, string ID, List<DaySave> daySaves)
        {
            if (daySaves != null)
                this.DaySaves = daySaves;
            else
                this.DaySaves = new List<DaySave>();
            this.tempLoglist = tempLoglist;
            this.ID = ID;
            InitializeComponent();
        }

        private void Main_Load(object sender, EventArgs e)
        {
            Log.Text = "현재 사용자 : " + ID;
        }

        private void Save_Click(object sender, EventArgs e)
        {
            new Save(this).Show();
        }

        private void Read_Click(object sender, EventArgs e)
        {
            new print(this).Show();
        }

        private void LogOut_Click(object sender, EventArgs e)
        {
            this.Hide();
            LogIn nLogIn = new LogIn(tempLoglist, DaySaves);
            nLogIn.ShowDialog();
            Program.ac.MainForm = nLogIn;
            this.Close();
        }
    }
}
