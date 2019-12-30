using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Bind
{
    public partial class Save : Form
    {
        private Main main;
        private Main.DaySave tempDaySave;
        private string deskPath;
        public Save(Main main)
        {
            this.main = main;
            tempDaySave = new Main.DaySave();
            deskPath = Environment.GetFolderPath(Environment.SpecialFolder.DesktopDirectory)+@"\!" ;
            InitializeComponent();
            MessageBox.Show("경로 : "+deskPath, "바탕화면 경로", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void savebutton_Click(object sender, EventArgs e)
        { 

            if (DialogResult.Yes == MessageBox.Show("일기를 저장 합니까 ?", "일기 저장",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question))
            {
                try
                {
                    File.WriteAllText(deskPath + DateTime.Now.ToString("yy_MM_dd - ") + TitleBox.Text + ".txt",
                        TitleBox.Text + Environment.NewLine + Environment.NewLine + ContentsBox.Text 
                        + Environment.NewLine + Environment.NewLine +
                    DateTime.Now);

                    tempDaySave.iD = main.ID;
                    tempDaySave.date = DateTime.Now.ToString("yy_MM_dd");
                    tempDaySave.title = TitleBox.Text;
                    tempDaySave.Contents = ContentsBox.Text;

                    main.DaySaves.Add(tempDaySave);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.StackTrace, "저장 실패",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                MessageBox.Show("저장 되었습니다.", "저장 성공");
            }
        }
    }
}
