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
    public partial class Product_Add : Form
    {
        public bool isMove;
        public Point fPt;
        private Form1 frm;

        public Product_Add()
        {
            InitializeComponent();
        }
        public Product_Add(Form1 frm)
        {
            InitializeComponent();
            this.frm = frm;
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

        private void btnSave_Click(object sender, EventArgs e) //데이터저장
        {
            List<Program.Product_Date> infor = new List<Program.Product_Date>();
            Program.File_Read read = new Program.File_Read();
            Program.File_Write write = new Program.File_Write();
            Program.Product_Date add = new Program.Product_Date();
            int i = read.Product_Read(infor);
            int check = 0;

            try
            {
                if (Program.Company_HDD >= int.Parse(cboRegion_HDD.SelectedItem.ToString()) && Program.Company_DB >= int.Parse(cboRegion_DB.SelectedItem.ToString())) // 우리 데이터가 모자라면 생성 안되고 메세지 박스 출력
                {
                    if (i == 0)
                    {
                        MessageBox.Show("" + i);
                        string mf = radioR.Checked ? "리눅스" : "윈도우";

                        add.number = txtProNum.Text;
                        add.OS = mf;
                        add.HDD = cboRegion_HDD.SelectedItem.ToString();
                        add.DB = cboRegion_DB.SelectedItem.ToString();
                        add.pay = txtProPrice.Text;
                        add.period = cboRegion_Period.SelectedItem.ToString();

                        i++;
                        infor.Add(add);

                        Program.Company_HDD = Program.Company_HDD - int.Parse(cboRegion_HDD.SelectedItem.ToString()); // 여기서 값을 입력시 우리 데이터들이 계산이 되고
                        Program.Company_DB = Program.Company_DB - int.Parse(cboRegion_DB.SelectedItem.ToString());
                        Program.Company_Money = Program.Company_Money + int.Parse(txtProPrice.Text);

                        if (Program.Company_HDD < 300 && Program.Company_DB >= 2000)
                            MessageBox.Show("HDD가 " + Program.Company_HDD + "GB뿐입니다.\n 구매하시기 바랍니다."); // 용량이 어느정도 부족하면 메세지 박스만 출력한다.
                        else if (Program.Company_DB < 2000 && Program.Company_HDD >= 300)
                            MessageBox.Show("DB가 " + Program.Company_DB + "MB뿐 입니다.\n 구매 하시기 바랍니다.");
                        else if (Program.Company_HDD < 300 && Program.Company_DB < 2000)
                            MessageBox.Show("HDD와 DB가 각각 " + Program.Company_HDD + "GB, " + Program.Company_DB + "MB뿐 입니다.\n 구매 하시기 바랍니다.");

                        write.Product_Write(infor, i + 1);

                        Form1.PList[0] = txtProNum.Text;
                        Form1.PList[1] = mf;
                        Form1.PList[2] = cboRegion_HDD.SelectedItem.ToString();
                        Form1.PList[3] = cboRegion_DB.SelectedItem.ToString();
                        Form1.PList[4] = txtProPrice.Text;
                        Form1.PList[5] = cboRegion_Period.SelectedItem.ToString();

                        frm.Add_Product();

                        //저장버튼 누르면 초기화
                        txtProNum.Text = "";
                        cboRegion_HDD.SelectedIndex = -1;
                        cboRegion_DB.SelectedIndex = -1;
                        txtProPrice.Text = "";
                        cboRegion_Period.SelectedIndex = -1;
                    }
                    else if (i == 1)
                    {
                        if (txtProNum.Text == infor[0].number)
                        {
                            txtProNum.Text = "";
                            cboRegion_HDD.SelectedIndex = -1;
                            cboRegion_DB.SelectedIndex = -1;
                            txtProPrice.Text = "";
                            cboRegion_Period.SelectedIndex = -1;
                            MessageBox.Show("중복되는 제품이 있습니다.");
                        }
                        else
                        {
                            string mf = radioR.Checked ? "리눅스" : "윈도우";

                            add.number = txtProNum.Text;
                            add.OS = mf;
                            add.HDD = cboRegion_HDD.SelectedItem.ToString();
                            add.DB = cboRegion_DB.SelectedItem.ToString();
                            add.pay = txtProPrice.Text;
                            add.period = cboRegion_Period.SelectedItem.ToString();

                            i++;
                            infor.Add(add);

                            Program.Company_HDD = Program.Company_HDD - int.Parse(cboRegion_HDD.SelectedItem.ToString()); // 여기서 값을 입력시 우리 데이터들이 계산이 되고
                            Program.Company_DB = Program.Company_DB - int.Parse(cboRegion_DB.SelectedItem.ToString());
                            Program.Company_Money = Program.Company_Money + int.Parse(txtProPrice.Text);

                            if (Program.Company_HDD < 300 && Program.Company_DB >= 2000)
                                MessageBox.Show("HDD가 " + Program.Company_HDD + "GB뿐입니다.\n 구매하시기 바랍니다."); // 용량이 어느정도 부족하면 메세지 박스만 출력한다.
                            else if (Program.Company_DB < 2000 && Program.Company_HDD >= 300)
                                MessageBox.Show("DB가 " + Program.Company_DB + "MB뿐 입니다.\n 구매 하시기 바랍니다.");
                            else if (Program.Company_HDD < 300 && Program.Company_DB < 2000)
                                MessageBox.Show("HDD와 DB가 각각 " + Program.Company_HDD + "GB, " + Program.Company_DB + "MB뿐 입니다.\n 구매 하시기 바랍니다.");

                            write.Product_Write(infor, i + 1);

                            Form1.PList[0] = txtProNum.Text;
                            Form1.PList[1] = mf;
                            Form1.PList[2] = cboRegion_HDD.SelectedItem.ToString();
                            Form1.PList[3] = cboRegion_DB.SelectedItem.ToString();
                            Form1.PList[4] = txtProPrice.Text;
                            Form1.PList[5] = cboRegion_Period.SelectedItem.ToString();

                            frm.Add_Product();

                            //저장버튼 누르면 초기화
                            txtProNum.Text = "";
                            cboRegion_HDD.SelectedIndex = -1;
                            cboRegion_DB.SelectedIndex = -1;
                            txtProPrice.Text = "";
                            cboRegion_Period.SelectedIndex = -1;
                        }
                    }
                    else
                    {
                        for (int n = 0; n < i; n++)
                        {
                            if (txtProNum.Text == infor[n].number)
                            {
                                check++;
                            }
                            else if (n == i - 1 && check == 0)
                            {
                                string mf = radioR.Checked ? "리눅스" : "윈도우";

                                add.number = txtProNum.Text;
                                add.OS = mf;
                                add.HDD = cboRegion_HDD.SelectedItem.ToString();
                                add.DB = cboRegion_DB.SelectedItem.ToString();
                                add.pay = txtProPrice.Text;
                                add.period = cboRegion_Period.SelectedItem.ToString();

                                i++;
                                infor.Add(add);

                                Program.Company_HDD = Program.Company_HDD - int.Parse(cboRegion_HDD.SelectedItem.ToString()); // 여기서 값을 입력시 우리 데이터들이 계산이 되고
                                Program.Company_DB = Program.Company_DB - int.Parse(cboRegion_DB.SelectedItem.ToString());
                                Program.Company_Money = Program.Company_Money + int.Parse(txtProPrice.Text);

                                if (Program.Company_HDD < 300 && Program.Company_DB >= 2000)
                                    MessageBox.Show("HDD가 " + Program.Company_HDD + "GB뿐입니다.\n 구매하시기 바랍니다."); // 용량이 어느정도 부족하면 메세지 박스만 출력한다.
                                else if (Program.Company_DB < 2000 && Program.Company_HDD >= 300)
                                    MessageBox.Show("DB가 " + Program.Company_DB + "MB뿐 입니다.\n 구매 하시기 바랍니다.");
                                else if (Program.Company_HDD < 300 && Program.Company_DB < 2000)
                                    MessageBox.Show("HDD와 DB가 각각 " + Program.Company_HDD + "GB, " + Program.Company_DB + "MB뿐 입니다.\n 구매 하시기 바랍니다.");

                                write.Product_Write(infor, i + 1);

                                Form1.PList[0] = txtProNum.Text;
                                Form1.PList[1] = mf;
                                Form1.PList[2] = cboRegion_HDD.SelectedItem.ToString();
                                Form1.PList[3] = cboRegion_DB.SelectedItem.ToString();
                                Form1.PList[4] = txtProPrice.Text;
                                Form1.PList[5] = cboRegion_Period.SelectedItem.ToString();

                                frm.Add_Product();

                                //저장버튼 누르면 초기화
                                txtProNum.Text = "";
                                cboRegion_HDD.SelectedIndex = -1;
                                cboRegion_DB.SelectedIndex = -1;
                                txtProPrice.Text = "";
                                cboRegion_Period.SelectedIndex = -1;

                                break;
                            }
                            else if (n == i - 1 && check != 0)
                            {
                                txtProNum.Text = "";
                                cboRegion_HDD.SelectedIndex = -1;
                                cboRegion_DB.SelectedIndex = -1;
                                txtProPrice.Text = "";
                                cboRegion_Period.SelectedIndex = -1;
                                MessageBox.Show("중복되는 제품이 있습니다.");
                            }
                        }
                    }
                }
                else
                    MessageBox.Show("DB나 HDD가 없어 생성할수 없습니다.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("저장할 정보를 정확히 입력해주세요");
            }
        }

        private void txtProNum_KeyPress(object sender, KeyPressEventArgs e) //제품번호숫자만입력
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

        private void txtProPrice_KeyPress(object sender, KeyPressEventArgs e) //제품가격숫자만입력
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
