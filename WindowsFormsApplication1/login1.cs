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
using WindowsFormsApplication1;

namespace WHMP
{
    public partial class Form0 : Form
    {
        public bool isMove;
        public Point fPt;

        public Form0()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.None; //윈도우 폼 제거
        }

        private void pnlTop_MouseDown(object sender, MouseEventArgs e) //폼이동시작
        {
            isMove = true;
            fPt = new Point(e.X, e.Y);
        }

        private void pnlTop_MouseMove(object sender, MouseEventArgs e) //폼이동끝
        {
            if (isMove && (e.Button & MouseButtons.Left) == MouseButtons.Left)
                Location = new Point(this.Left - (fPt.X - e.X), this.Top - (fPt.Y - e.Y));
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            List<Program.InterInfor> Iinfor = new List<Program.InterInfor>();
            Program.File_Read inter = new Program.File_Read();
            int i = inter.Inter_Read(Iinfor);

            for (int n = 0; n < i; n++)
            {
                if (Iinfor[n].ID == ID_Box.Text)
                {
                    if (Iinfor[n].PW == PW_Box.Text)
                    {
                        this.Hide();
                        Form1 mainform1 = new Form1();
                        mainform1.Show();
                        break;
                    }
                    else
                    {
                        MessageBox.Show("비밀번호를 확인해주세요.");
                        break;
                    }
                }
                else if (n == i - 1)
                {
                    MessageBox.Show("아이디를 확인해주세요.");
                }
            }
        }

        private void pnlTop_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Form0_Load(object sender, EventArgs e)
        {
            string path = @"C:\WHMP"; //폴더파일생성경로
            DirectoryInfo di = new DirectoryInfo(path);
            if (di.Exists == false) //폴더파일 유무 확인후 없으면 생성
            {
                di.Create();
            }

            StreamWriter swr = new StreamWriter(@"C:\WHMP\인사데이터.txt", true);
            swr.Close();
            StreamWriter pwr = new StreamWriter(@"C:\WHMP\제품데이터.txt", true);
            pwr.Close();

            List<Program.InterInfor> Iinfor = new List<Program.InterInfor>();
            List<Program.Product_Date> Pinfor = new List<Program.Product_Date>();
            Program.File_Read inter = new Program.File_Read();
            Program.File_Write write = new Program.File_Write();
            int i = inter.Inter_Read(Iinfor);
            int p = inter.Product_Read(Pinfor);

            if (i == 0 && p == 0 && Program.Company_HDD == 0 && Program.Company_DB == 0 && Program.Company_Money == 0)
            {
                Program.InterInfor gar = new Program.InterInfor();
                Iinfor.Add(gar);
                Iinfor[0].ID = "admin";
                Iinfor[0].PW = "admin";
                Iinfor[0].name = "신창기";
                Iinfor[0].EmNum = "010-1111-1111";
                Iinfor[0].Position = "사장";
                Iinfor[0].identity = "1";
                Program.Company_HDD = 100;
                Program.Company_DB = 2000;
                Program.Company_Money = 20000000;

                write.Product_Write(Pinfor, 0);
                write.Inter_Write(Iinfor, 2);
            }
            else if (i == 0)
            {
                Iinfor[0].ID = "admin";
                Iinfor[0].PW = "admin";
                Iinfor[0].name = "신창기";
                Iinfor[0].EmNum = "010-1111-1111";
                Iinfor[0].Position = "사장";
                Iinfor[0].identity = "1";

                write.Inter_Write(Iinfor, 2);
            }
            else if (p == 0 && Program.Company_HDD == 0 && Program.Company_DB == 0 && Program.Company_Money == 0)
            {
                Program.Company_HDD = 100;
                Program.Company_DB = 2000;
                Program.Company_Money = 20000000;

                write.Product_Write(Pinfor, 0);
            }

        }
    }
}
