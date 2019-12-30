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
    public partial class print : Form
    {
        private List<Main.DaySave> List;
        private string id;
        private Main main;
        private void printf() 
        {
            try
            {
                this.List = main.DaySaves;
                this.id = main.ID;
                DataTable table = new DataTable();

                if (string.IsNullOrWhiteSpace(id) || List == null)
                    return;

                table.Columns.Add("날짜", typeof(string));
                table.Columns.Add("제목", typeof(string));
                table.Columns.Add("내용", typeof(string));
                // column을 추가합니다.

                foreach (Main.DaySave temp in List)
                {
                    if (id == temp.iD) //맞는 id에 대한 내용만 출력해야 하므로 검사 해줍니다.
                        table.Rows.Add(temp.date, temp.title, temp.Contents);
                }
                // 각각의 행에 내용을 입력합니다.

                ListView.DataSource = table;

                // 값들이 입력된 테이블을 DataGridView에 입력합니다.
            }
            catch (Exception ex) 
            {
                MessageBox.Show(ex.StackTrace, "불러오기 실패",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public print(Main main)
        {
            this.main = main;
            List = main.DaySaves;

            InitializeComponent();

            printf();
        }

        private void LoadButton_Click(object sender, EventArgs e)
        {
            printf();
        }
    }
}
