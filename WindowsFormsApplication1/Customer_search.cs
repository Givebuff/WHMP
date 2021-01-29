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
    public partial class Customer_search : Form
    {
        public bool isMove;
        public Point fPt;
        private Form1 frm;
        List<Program.Customer_Date> product = new List<Program.Customer_Date>();
        Program.File_Read read = new Program.File_Read();
        private int number;//리스트의 길이 변수
        private int check = 0;// 검색 값이 있나 없나 나타낼 변수

        public Customer_search(Form1 frm)
        {
            InitializeComponent();
            this.frm = frm;
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            number = read.Customer_Read(product);
            check = 0;
            for (int i = 0; i < number; i++)
            {
                if (product[i].ITnumber == textBox1.Text)
                {
                    number = i;
                    check++;
                    break;
                }
                else if (product[i].Centerprise == textBox1.Text)
                {
                    number = i;
                    check++;
                    break;
                }
                else if (product[i].Cboss == textBox1.Text)
                {
                    number = i;
                    check++;
                    break;
                }
                else if (product[i].Cphone == textBox1.Text)
                {
                    number = i;
                    check++;
                    break;
                }
                else if (product[i].Pnumber == textBox1.Text)
                {
                    number = i;
                    check++;
                    break;
                }
                else if (product[i].Pperiod == textBox1.Text)
                {
                    number = i;
                    check++;
                    break;
                }
                else if (product[i].Iname == textBox1.Text)
                {
                    number = i;
                    check++;
                    break;
                }
                else if (product[i].IEnNum == textBox1.Text)
                {
                    number = i;
                    check++;
                    break;
                }
                else if (product[i].Iposition == textBox1.Text)
                {
                    number = i;
                    check++;
                    break;
                }
                else if(product[i].Iidentity == textBox1.Text)
                {
                    number = i;
                    check++;
                    break;
                }
                else if (i == number - 1)
                    textBox1.Text = "결과값이 없습니다.";
            }
            if (check > 0)
            {
                string[] Cstring = { product[number].ITnumber, product[number].Centerprise, product[number].Cboss ,
                    product[number].Cphone, product[number].Pnumber, product[number].Ppay, product[number].Pperiod,
                    product[number].Iname, product[number].IEnNum, product[number].Iposition, product[number].Iidentity};
                frm.Text_Customer = Cstring;
            }

            this.Close();
        }

        private void pnlTop_MouseDown(object sender, MouseEventArgs e) //폼이동
        {
            isMove = true;
            fPt = new Point(e.X, e.Y);
        }

        private void pnlTop_MouseMove(object sender, MouseEventArgs e) //폼이동끝
        {
            if (isMove && (e.Button & MouseButtons.Left) == MouseButtons.Left)
                Location = new Point(this.Left - (fPt.X - e.X), this.Top - (fPt.Y - e.Y));
        }

        private void btnClose2_Click(object sender, EventArgs e) //창닫기
        {
            this.Close();
        }
    }
}
