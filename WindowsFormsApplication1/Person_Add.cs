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
    public partial class Person_Add : Form
    {
        public bool isMove;
        public Point fPt;
        private Form1 frm;

        public Person_Add(Form1 frm)
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

        private void txtEmNum_KeyPress(object sender, KeyPressEventArgs e) //전화번호숫자만입력
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

        private void btnSave_Click(object sender, EventArgs e) //데이터저장
        {
            string path = @"C:\WHMP"; //폴더파일생성경로
            DirectoryInfo di = new DirectoryInfo(path);
            if (di.Exists == false) //폴더파일 유무 확인후 없으면 생성
            {
                di.Create();
            }
            List<Program.InterInfor> infor = new List<Program.InterInfor>();
            Program.File_Read read = new Program.File_Read();
            Program.File_Write write = new Program.File_Write();
            Program.InterInfor add = new Program.InterInfor();
            int i = read.Inter_Read(infor);
            int check = 0;

            string aa;
            string[] str = new string[6];

            try
            {
                aa = cboPosition.SelectedItem.ToString();
                str[0] = txtEmName.Text; str[1] = txtEmNum.Text; str[2] = aa; str[3] = txtID.Text; str[4] = txtPW.Text; str[5] = txtTnumber.Text;

                if (i == 1)
                {
                    if (txtEmName.Text == infor[0].identity || txtID.Text == infor[0].ID)
                    {
                        txtEmName.Text = "";
                        txtEmNum.Text = "";
                        cboPosition.SelectedIndex = -1;
                        txtID.Text = "";
                        txtPW.Text = "";
                        txtTnumber.Text = "";
                        MessageBox.Show("중복되는 정보가 있습니다.");
                    }
                    else
                    {
                        add.ID = txtID.Text;
                        add.PW = txtPW.Text;
                        add.name = txtEmName.Text;
                        add.EmNum = txtEmNum.Text;
                        add.Position = aa;
                        add.identity = txtTnumber.Text; ;

                        infor.Add(add);
                        i++;

                        write.Inter_Write(infor, i + 1);

                        frm.Add_Person = str;
                        MessageBox.Show("저장되었습니다.");
                        //저장버튼 누르면 초기화
                        txtEmName.Text = "";
                        txtEmNum.Text = "";
                        cboPosition.SelectedIndex = -1;
                        txtID.Text = "";
                        txtPW.Text = "";
                        txtTnumber.Text = "";
                    }
                }
                else
                {
                    for (int n = 0; n < i; n++)
                    {
                        if (txtEmName.Text == infor[n].identity || txtID.Text == infor[n].ID)
                        {
                            txtEmName.Text = "";
                            txtEmNum.Text = "";
                            cboPosition.SelectedIndex = -1;
                            txtID.Text = "";
                            txtPW.Text = "";
                            txtTnumber.Text = "";
                            MessageBox.Show("중복되는 정보가 있습니다.");
                            break;
                        }
                        else if (n == i - 1 && check == 0)
                        {
                            frm.Add_Person = str;

                            add.ID = txtID.Text;
                            add.PW = txtPW.Text;
                            add.name = txtEmName.Text;
                            add.EmNum = txtEmNum.Text;
                            add.Position = aa;
                            add.identity = txtTnumber.Text; ;

                            infor.Add(add);
                            i++;

                            write.Inter_Write(infor, i + 1);

                            MessageBox.Show("저장되었습니다.");
                            //저장버튼 누르면 초기화
                            txtEmName.Text = "";
                            txtEmNum.Text = "";
                            cboPosition.SelectedIndex = -1;
                            txtID.Text = "";
                            txtPW.Text = "";
                            txtTnumber.Text = "";
                            break;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("저장할 정보를 정확히 입력해주세요");
            }
        }

        private void txtTnumber_KeyPress(object sender, KeyPressEventArgs e)
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
