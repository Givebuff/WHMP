using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Customer_Remove : Form
    {
        public bool isMove;
        public Point fPt;
        List<Program.Customer_Date> infor = new List<Program.Customer_Date>();
        Program.File_Read read = new Program.File_Read();
        Program.File_Write write = new Program.File_Write();

        public Customer_Remove()
        {
            InitializeComponent();
        }

        private void pnlTop_MouseDown(object sender, MouseEventArgs e)
        {
            isMove = true;
            fPt = new Point(e.X, e.Y);
        }

        private void pnlTop_MouseMove(object sender, MouseEventArgs e)
        {
            if (isMove && (e.Button & MouseButtons.Left) == MouseButtons.Left)
                Location = new Point(this.Left - (fPt.X - e.X), this.Top - (fPt.Y - e.Y));
        }

        private void btnClose2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            int b = read.Customer_Read(infor);
            int a = b - 1;
            for(int i = b - 1; i >= 0; i--)
            {
                if(infor[i].ITnumber == textBox1.Text)
                {
                    infor.RemoveAt(i);
                    MessageBox.Show("삭제완료");
                    write.Customer_Write(infor, a);
                }
                else if (infor[i].Centerprise  == textBox1.Text)
                {
                    infor.RemoveAt(i);
                    MessageBox.Show("삭제완료");
                    write.Customer_Write(infor, a);
                }
                else if (infor[i].Cboss  == textBox1.Text)
                {
                    infor.RemoveAt(i);
                    MessageBox.Show("삭제완료");
                    write.Customer_Write(infor, a);
                }
                else if (infor[i].Cphone  == textBox1.Text)
                {
                    infor.RemoveAt(i);
                    MessageBox.Show("삭제완료");
                    write.Customer_Write(infor, a);
                }
                else if (infor[i].Pnumber  == textBox1.Text)
                {
                    infor.RemoveAt(i);
                    MessageBox.Show("삭제완료");
                    write.Customer_Write(infor, a);
                }
                else if(infor[i].Iidentity == textBox1.Text)
                {
                    infor.RemoveAt(i);
                    MessageBox.Show("삭제완료");
                    write.Customer_Write(infor, a);
                }
                else if (i == 0)
                {
                    textBox1.Text = "결과값이 없습니다.";
                }
            }
        }
    }
}
