using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Customer_Add : Form
    {
        public bool isMove;
        public Point fPt;

        public Customer_Add()
        {
            InitializeComponent();
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

        private void btnSave_Click(object sender, EventArgs e) //저장버튼
        {
            string path = @"C:\WHMP";
            DirectoryInfo di = new DirectoryInfo(path);
            if (di.Exists == false)
            {
                di.Create();
            }
            StreamWriter swr = new StreamWriter(@"C:\WHMP\거래처데이터.txt", true);
            swr.Close();
            List<Program.Customer_Date> Custom = new List<Program.Customer_Date>();

            Program.File_Read read = new Program.File_Read();
            int i = read.Customer_Read(Custom);

            int check = 0;

            List<Program.InterInfor> Iinfor = new List<Program.InterInfor>();
            List<Program.Product_Date> Pinfor = new List<Program.Product_Date>();

            int Pnum = read.Product_Read(Pinfor);
            int Inum = read.Inter_Read(Iinfor);

            int check2 = 0;

            for (int n = 0; n < Pnum; n++)
                if(Pinfor[n].number == txtCuProNum.Text)
                    for(int m = 0; m <Inum; m++)
                        if(Iinfor[m].identity == txtIidentity.Text)
                            check2++;

            if (check2 != 0)
            {
                if (i == 1)
                {
                    if (txtDealNum.Text == Custom[0].ITnumber)
                    {
                        txtDealNum.Text = "";
                        txtBusinessName.Text = "";
                        txtRepresentativeName.Text = "";
                        txtCustomerNum.Text = "";
                        txtCuProNum.Text = "";
                        txtIidentity.Text = "";
                        MessageBox.Show("중복되는 정보가 있습니다.");
                    }
                    else
                    {
                        string data = txtDealNum.Text + "\r\n" + txtBusinessName.Text + "\r\n" + txtRepresentativeName.Text + "\r\n" +
                                txtCustomerNum.Text + "\r\n" + txtCuProNum.Text + "\r\n" + txtIidentity.Text;

                        StreamWriter wr = new StreamWriter(@"C:\WHMP\거래처데이터.txt", true);
                        wr.WriteLine(data);
                        wr.Close();

                        txtDealNum.Text = "";
                        txtBusinessName.Text = "";
                        txtRepresentativeName.Text = "";
                        txtCustomerNum.Text = "";
                        txtCuProNum.Text = "";
                        txtIidentity.Text = "";
                    }
                }
                else if (i == 0)
                {
                    string data = txtDealNum.Text + "\r\n" + txtBusinessName.Text + "\r\n" + txtRepresentativeName.Text + "\r\n" +
                                txtCustomerNum.Text + "\r\n" + txtCuProNum.Text + "\r\n" + txtIidentity.Text;

                    StreamWriter wr = new StreamWriter(@"C:\WHMP\거래처데이터.txt", true);
                    wr.WriteLine(data);
                    wr.Close();

                    txtDealNum.Text = "";
                    txtBusinessName.Text = "";
                    txtRepresentativeName.Text = "";
                    txtCustomerNum.Text = "";
                    txtCuProNum.Text = "";
                    txtIidentity.Text = "";
                }
                else
                {
                    for (int n = 0; n < i; n++)
                    {
                        if (txtDealNum.Text == Custom[n].ITnumber)
                        {
                            check++;
                        }
                        else if (n == i - 1 && check == 0)
                        {
                            string data = txtDealNum.Text + "\r\n" + txtBusinessName.Text + "\r\n" + txtRepresentativeName.Text + "\r\n" +
                                 txtCustomerNum.Text + "\r\n" + txtCuProNum.Text + "\r\n" + txtIidentity.Text;

                            StreamWriter wr = new StreamWriter(@"C:\WHMP\거래처데이터.txt", true);
                            wr.WriteLine(data);
                            wr.Close();

                            txtDealNum.Text = "";
                            txtBusinessName.Text = "";
                            txtRepresentativeName.Text = "";
                            txtCustomerNum.Text = "";
                            txtCuProNum.Text = "";
                            txtIidentity.Text = "";
                        }
                        else if (n == i - 1 && check != 0)
                        {
                            txtDealNum.Text = "";
                            txtBusinessName.Text = "";
                            txtRepresentativeName.Text = "";
                            txtCustomerNum.Text = "";
                            txtCuProNum.Text = "";
                            txtIidentity.Text = "";
                            MessageBox.Show("중복되는 정보가 있습니다.");
                        }
                    }
                }
            }
            else
                MessageBox.Show("연관되는 정보가 없습니다.");
        }

        private void txtDealNum_KeyPress(object sender, KeyPressEventArgs e) //거래번호숫자만입력
        {
            if (Char.IsDigit(e.KeyChar)
                || e.KeyChar == Convert.ToInt32(Keys.Back))
            {

            }
            else
            {
                e.Handled = true;
            }
        }

        private void txtCustomerNum_KeyPress(object sender, KeyPressEventArgs e) //전화번호숫자만입력
        {
            if (Char.IsDigit(e.KeyChar)
                || e.KeyChar == Convert.ToInt32(Keys.Back))
            {

            }
            else
            {
                e.Handled = true;
            }
        }

        private void txtCuProNum_KeyPress(object sender, KeyPressEventArgs e) //제품번호숫자만입력
        {
            if (Char.IsDigit(e.KeyChar)
                || e.KeyChar == Convert.ToInt32(Keys.Back))
            {

            }
            else
            {
                e.Handled = true;
            }
        }

    }
}
