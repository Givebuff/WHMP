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
using System.Text.RegularExpressions;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        private DataTable pdt, idt;
        private DataView pdv, idv;
        public bool isMove;
        public Point fPt;
        public static string[] PList = new string[7];
        public static string[] IList = new string[6];

        public Form1()
        {
            InitializeComponent();

            List<Program.Product_Date> pinfor = new List<Program.Product_Date>();
            List<Program.InterInfor> Iinfor = new List<Program.InterInfor>();
            Program.File_Read read = new Program.File_Read();
            int n = read.Product_Read(pinfor);
            int m = read.Inter_Read(Iinfor);

            pdt = new DataTable();
            pdt.Columns.Add("number");
            pdt.Columns.Add("os");
            pdt.Columns.Add("hdd");
            pdt.Columns.Add("db");
            pdt.Columns.Add("pay");
            pdt.Columns.Add("priod");
            fillDataTable(pinfor);

            pdv = new DataView(pdt);
            populateListView(pdv);

            idt = new DataTable();
            idt.Columns.Add("name");
            idt.Columns.Add("emnum");
            idt.Columns.Add("position");
            idt.Columns.Add("id");
            idt.Columns.Add("pw");
            idt.Columns.Add("identity");
            ifillDataTable(Iinfor);

            idv = new DataView(idt);
            lpopulateListView(idv);
        }

        private void fillDataTable(List<Program.Product_Date> pinfor) //제품검색
        {
            foreach (var player in pinfor)
            {
                pdt.Rows.Add(player.Number, player.Os, player.Hdd, player.Db, player.Pay, player.Priod);
            }
        }
        
        private void populateListView(DataView pdv) //제품검색
        {
            listViewProduct.Items.Clear();
            foreach (DataRow row in pdv.ToTable().Rows)
            {
                listViewProduct.Items.Add(new ListViewItem(new string[] { row[0].ToString(),
                row[1].ToString(), row[2].ToString(), row[3].ToString(), row[4].ToString(), row[5].ToString()}));
            }
        }

        private void ifillDataTable(List<Program.InterInfor> Iinfor) //인사검색
        {
            foreach (var player in Iinfor)
            {
                idt.Rows.Add(player.Name, player.Emnum, player.POsition, player.Id, player.Pw, player.Identity);
            }
        }

        private void lpopulateListView(DataView dv) //인사검색
        {
            listViewPerson.Items.Clear();
            foreach (DataRow row in dv.ToTable().Rows)
            {
                listViewPerson.Items.Add(new ListViewItem(new string[] { row[0].ToString(),
                row[1].ToString(), row[2].ToString(), row[3].ToString(), row[4].ToString(), row[5].ToString()}));
            }
        }

        public void Add_Product()
        {
            ListViewItem item = new ListViewItem(PList);
            listViewProduct.Items.Add(item);
        }
        
        public string[] Add_Person
        {
            set
            {
                ListViewItem item = new ListViewItem(value);
                listViewPerson.Items.Add(item);
            }
        }

        public string[] Text_Product
        {
            set
            {
                txtProNum.Text = value[0];
                txtOS.Text = value[1];
                txtHDD.Text = value[2];
                txtDB.Text = value[3];
                txtProPrice.Text = value[4];
                txtPeriod.Text = value[5];
            }
        }

        public string[] Text_Person
        {
            set
            {
                txtName.Text = value[0];
                txtEmNum.Text = value[1];
                txtPosition.Text = value[2];
                txtID.Text = value[3];
                txtPW.Text = value[4];
                txtTnumber.Text = value[5];
            }
        }

        public string[] Text_Customer
        {
            set
            {
                txtDealNum.Text = value[0];
                txtBusinessName.Text = value[1];
                txtRepresentativeName.Text = value[2];
                txtCustomerNum.Text = value[3];
                txtCuProNum.Text = value[4];
                txtCuProPrice.Text = value[5];
                txtCuPeriod.Text = value[6];
                txtCuEmName.Text = value[7];
                txtCuEmNum.Text = value[8];
                txtCuPosition.Text = value[9];
                txtIidentity.Text = value[10];
            }
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

        private void btnClose_Click(object sender, EventArgs e) //창닫기
        {
            Application.Exit();
        }

        private void btnProAdd_Click(object sender, EventArgs e) //제품추가
        {
            Form form = new Product_Add(this);
            form.ShowDialog();
        }

        private void btnPersonAdd_Click(object sender, EventArgs e) //인사추가
        {
            Form form = new Person_Add(this);
            form.ShowDialog();
        }

        private void btnMenu_Click(object sender, EventArgs e) //메뉴탭버튼
        {
            listViewsell.Items.Clear();
            panelMenu.BringToFront();
        }

        private void btnOut_Click(object sender, EventArgs e)
        {
            paneloutsell.BringToFront();
        }

        private void btnPro_Click(object sender, EventArgs e) //제품탭버튼
        {
            panelProData.BringToFront();

            //초기화
            txtName.Text = "";
            txtEmNum.Text = "";
            txtPosition.Text = "";
            txtID.Text = "";
            txtPW.Text = "";
            txtTnumber.Text = "";
        }

        private void btnPersonData_Click(object sender, EventArgs e) //인사탭버튼
        {
            panelPersonData.BringToFront();

            //초기화
            txtProNum.Text = "";
            txtOS.Text = "";
            txtHDD.Text = "";
            txtDB.Text = "";
            txtProPrice.Text = "";
            txtPeriod.Text = "";
        }

        private void btnCustomer_Click(object sender, EventArgs e) //거래처탭버튼
        {
            panelCustomerData.BringToFront();

            //초기화
            txtProNum.Text = "";
            txtOS.Text = "";
            txtHDD.Text = "";
            txtDB.Text = "";
            txtProPrice.Text = "";
            txtPeriod.Text = "";

            txtName.Text = "";
            txtEmNum.Text = "";
            txtPosition.Text = "";
            txtID.Text = "";
            txtPW.Text = "";
            txtTnumber.Text = "";

        }

        private void btnProRemove_Click(object sender, EventArgs e) //제품삭제
        {
            try
            {
                List<Program.Product_Date> product = new List<Program.Product_Date>();//제품데이터에 대한 리스트 생성
                Program.File_Read read = new Program.File_Read();//제품데이터의 클래스 생성
                Program.File_Write write = new Program.File_Write();
                int b = read.Product_Read(product);
                int a = b;
                for (int i = b - 1; i >= 0; i--)
                {
                    if (product[i].number == txtProNum.Text)
                    {
                        product.RemoveAt(i);
                        MessageBox.Show("삭제 완료");
                        write.Product_Write(product, a);
                        break;
                    }
                }
                listViewProduct.Items.RemoveAt(listViewProduct.SelectedIndices[0]);
            }
            catch
            {
                MessageBox.Show("삭제할 것을 지정해주세요.");
            }
            finally
            {
                txtProNum.Text = "";
                txtOS.Text = "";
                txtHDD.Text = "";
                txtDB.Text = "";
                txtProPrice.Text = "";
                txtPeriod.Text = "";
            }
        }

        private void btnPersonRemove_Click(object sender, EventArgs e) //인사삭제
        {
            try
            {
                List<Program.InterInfor> Inter = new List<Program.InterInfor>();//제품데이터에 대한 리스트 생성
                Program.File_Read read = new Program.File_Read();//제품데이터의 클래스 생성
                Program.File_Write write = new Program.File_Write();

                int b = read.Inter_Read(Inter);
                int a = b;
                for (int i = b - 1; i >= 0; i--)
                {
                    if (Inter[i].identity == txtTnumber.Text)
                    {
                        Inter.RemoveAt(i);
                        MessageBox.Show("삭제 완료");
                        write.Inter_Write(Inter, a);
                        break;
                    }
                }
                listViewPerson.Items.RemoveAt(listViewPerson.SelectedIndices[0]);
            }
            catch (Exception ex)
            {
                MessageBox.Show("삭제할것을 지정해주세요");
            }
            finally
            {
                txtName.Text = "";
                txtEmNum.Text = "";
                txtPosition.Text = "";
                txtID.Text = "";
                txtPW.Text = "";
                txtTnumber.Text = "";
            }
        }

        private void btnCustomerAdd_Click(object sender, EventArgs e) //거래처추가
        {
            Form form = new Customer_Add();
            form.ShowDialog();
        }

        private void btnCustomerSearch_Click(object sender, EventArgs e) //거래처검색
        {
            Form form = new Customer_search(this);
            form.ShowDialog();
        }

        private void btnCustomerRemove_Click(object sender, EventArgs e) //거래처삭제
        {
            Form form = new Customer_Remove();
            form.ShowDialog();
        }

        private void listView1_MouseClick(object sender, MouseEventArgs e) //제품리스트뷰
        {
            txtProNum.Text = listViewProduct.SelectedItems[0].SubItems[0].Text;
            txtOS.Text = listViewProduct.SelectedItems[0].SubItems[1].Text;
            txtHDD.Text = listViewProduct.SelectedItems[0].SubItems[2].Text;
            txtDB.Text = listViewProduct.SelectedItems[0].SubItems[3].Text;
            txtProPrice.Text = listViewProduct.SelectedItems[0].SubItems[4].Text;
            txtPeriod.Text = listViewProduct.SelectedItems[0].SubItems[5].Text;
        }

        private void listViewPerson_MouseClick(object sender, MouseEventArgs e) //인사리스트뷰
        {
            txtName.Text = listViewPerson.SelectedItems[0].SubItems[0].Text;
            txtEmNum.Text = listViewPerson.SelectedItems[0].SubItems[1].Text;
            txtPosition.Text = listViewPerson.SelectedItems[0].SubItems[2].Text;
            txtID.Text = listViewPerson.SelectedItems[0].SubItems[3].Text;
            txtPW.Text = listViewPerson.SelectedItems[0].SubItems[4].Text;
            txtTnumber.Text = listViewPerson.SelectedItems[0].SubItems[5].Text;
        }

        private void button1_Click(object sender, EventArgs e) //판매목록
        {
            try
            {
                Program.File_Read read = new Program.File_Read();
                List<Program.Customer_Date> Cinfor = new List<Program.Customer_Date>();
                int l = read.Customer_Read(Cinfor);
                ListViewItem item;

                //거래처
                for (int i = 0; i < l; i++)
                {
                    item = new ListViewItem(Cinfor[i].ITnumber);
                    item.SubItems.Add(Cinfor[i].Centerprise);
                    item.SubItems.Add(Cinfor[i].Cboss);
                    item.SubItems.Add(Cinfor[i].Pnumber);
                    item.SubItems.Add(Cinfor[i].Ppay);
                    item.SubItems.Add(Cinfor[i].Pperiod);

                    listViewsell.Items.Add(item);
                }

                panelsell.BringToFront();
            }
            catch(Exception ex)
            {
                MessageBox.Show("거래 정보가 없습니다.");
            }
        }


        /*여기서 부터 재무관리 목록 */

        int HDDsel;
        int DBsel;
        int res;

        private void Calc()
        {
            res = (HDDsel * 80000) + (DBsel * 95000); // 총 가격 변수 HDD 1000GB = 8만원 DBsel 200MB 9만 5천원 가격 수정바랍니다
            Finacial_Text_Money.Text = Convert.ToInt32(res)+"원";
        }
        /** 버튼당 가격및 HDD,DB 양 설정 **/
        private void button1_Click_1(object sender, EventArgs e) 
        {
            HDDsel = 0;
            Calc();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            HDDsel = 1;
            Calc();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            HDDsel = 10;
            Calc();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            HDDsel = 100;
            Calc();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            DBsel = 0;
            Calc();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            DBsel = 1;
            Calc();
        }
        private void button7_Click(object sender, EventArgs e)
        {
            DBsel = 10;
            Calc();
        }
        private void button8_Click(object sender, EventArgs e)
        {
            DBsel = 100;
            Calc();
        }

        private void txtPersearch_TextChanged(object sender, EventArgs e) //인사검색
        {
            List<Program.InterInfor> Iinfor = new List<Program.InterInfor>();
            Program.File_Read read = new Program.File_Read();
            int m = read.Inter_Read(Iinfor);
            idt = new DataTable();
            idt.Columns.Add("name");
            idt.Columns.Add("emnum");
            idt.Columns.Add("position");
            idt.Columns.Add("id");
            idt.Columns.Add("pw");
            idt.Columns.Add("identity");
            ifillDataTable(Iinfor);

            idv = new DataView(idt);
            lpopulateListView(idv);

            if (radio_Name.Checked) { idv.RowFilter = string.Format("name Like '%{0}%'", txtPersearch.Text); }
            else if (radio_EmNum.Checked) { idv.RowFilter = string.Format("emnum Like '%{0}%'", txtPersearch.Text); }
            else if (radio_Position.Checked) { idv.RowFilter = string.Format("position Like '%{0}%'", txtPersearch.Text); }
            else if (radio_ID.Checked) { idv.RowFilter = string.Format("id Like '%{0}%'", txtPersearch.Text); }
            else if (radio_PW.Checked) { idv.RowFilter = string.Format("pw Like '%{0}%'", txtPersearch.Text); }
            else if (radio_Tnumber.Checked) { idv.RowFilter = string.Format("identity Like '%{0}%'", txtPersearch.Text); }

            lpopulateListView(idv);
        }

        private void button14_Click(object sender, EventArgs e)  //제품수정
        {
            try
            {
                List<Program.InterInfor> infor = new List<Program.InterInfor>();
                Program.File_Read read = new Program.File_Read();
                Program.File_Write write = new Program.File_Write();
                int i = read.Inter_Read(infor);

                for (int n = 0; n < i; n++)
                {
                    if (infor[n].identity == listViewPerson.SelectedItems[0].SubItems[5].Text)
                    {
                        infor[n].name = txtName.Text;
                        infor[n].EmNum = txtEmNum.Text;
                        infor[n].Position = txtPosition.Text;
                        infor[n].ID = txtID.Text;
                        infor[n].PW = txtPW.Text;
                        infor[n].identity = txtTnumber.Text;
                        write.Inter_Write(infor, i + 1);
                    }
                }
                listViewPerson.SelectedItems[0].SubItems[0].Text = txtName.Text;
                listViewPerson.SelectedItems[0].SubItems[1].Text = txtEmNum.Text;
                listViewPerson.SelectedItems[0].SubItems[2].Text = txtPosition.Text;
                listViewPerson.SelectedItems[0].SubItems[3].Text = txtID.Text;
                listViewPerson.SelectedItems[0].SubItems[4].Text = txtPW.Text;
                listViewPerson.SelectedItems[0].SubItems[5].Text = txtTnumber.Text;
            }
            catch (Exception ex)
            {
                MessageBox.Show("수정할 것을 선택해주세요");
            }
        }

        private void button15_Click(object sender, EventArgs e)  //인사수정
        {
            try
            {
                List<Program.Product_Date> infor = new List<Program.Product_Date>();
                Program.File_Read read = new Program.File_Read();
                Program.File_Write write = new Program.File_Write();
                int i = read.Product_Read(infor);

                for (int n = 0; n < i; n++)
                {
                    if (infor[n].number == listViewProduct.SelectedItems[0].SubItems[0].Text)
                    {
                        infor[n].number = txtProNum.Text;
                        infor[n].OS = txtOS.Text;
                        infor[n].HDD = txtHDD.Text;
                        infor[n].DB = txtDB.Text;
                        infor[n].pay = txtProPrice.Text;
                        infor[n].period = txtPeriod.Text;
                        write.Product_Write(infor, i + 1);
                    }
                }
                listViewProduct.SelectedItems[0].SubItems[0].Text = txtProNum.Text;
                listViewProduct.SelectedItems[0].SubItems[1].Text = txtOS.Text;
                listViewProduct.SelectedItems[0].SubItems[2].Text = txtHDD.Text;
                listViewProduct.SelectedItems[0].SubItems[3].Text = txtDB.Text;
                listViewProduct.SelectedItems[0].SubItems[4].Text = txtProPrice.Text;
                listViewProduct.SelectedItems[0].SubItems[5].Text = txtPeriod.Text;
            }
            catch (Exception ex)
            {
                MessageBox.Show("수정할 것을 선택해주세요");
            }
        }

        private void button16_Click(object sender, EventArgs e)  //거래처수정
        {
            List<Program.Customer_Date> infor = new List<Program.Customer_Date>();
            Program.File_Read read = new Program.File_Read();
            Program.File_Write write = new Program.File_Write();
            int i = read.Customer_Read(infor);

            for (int n = 0; n < i; n++)
            {
                if (infor[n].ITnumber == txtDealNum.Text)
                {
                    infor[n].Centerprise = txtBusinessName.Text;
                    infor[n].Cboss = txtRepresentativeName.Text;
                    infor[n].Cphone = txtCustomerNum.Text;
                    infor[n].Pnumber = txtProNum.Text;
                    infor[n].Iidentity = txtIidentity.Text;
                }
                else if (n == i - 1)
                    MessageBox.Show("수정할 것을 검색하고 정확한 정보를 입력해주세요");
            }
        }

        private void button20_Click(object sender, EventArgs e) //제무리스트뷰
        {
            try
            {
                Program.File_Read read = new Program.File_Read();
                List<Program.Money_Date> Minfor = new List<Program.Money_Date>();



                ListViewItem item;

                //거래처
                for (int i = 0; i < 5; i++)
                {
                    Minfor = read.Money_Read(Minfor,i);
                    item = new ListViewItem(Minfor[i].iitnumber.ToString());
                    item.SubItems.Add(Minfor[i].primecost.ToString());
                    item.SubItems.Add(Minfor[i].fixedprice.ToString());
                    item.SubItems.Add(Minfor[i].amount.ToString());
                    item.SubItems.Add(Minfor[i].apc.ToString());
                    item.SubItems.Add(Minfor[i].afp.ToString());
                    item.SubItems.Add(Minfor[i].netprofit.ToString());
                    item.SubItems.Add(Minfor[i].anp.ToString());

                    listView1.Items.Add(item);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("정보가 없습니다.");
            }
        }

        /** 버튼당 가격및 HDD,DB 양 설정  END **/

        private void button9_Click(object sender, EventArgs e) // HDD 및 DB 구매
        {
            List<Program.Product_Date> product = new List<Program.Product_Date>();//제품데이터에 대한 리스트 생성
            Program.File_Read read = new Program.File_Read();//제품데이터의 클래스 생성
            Program.File_Write write = new Program.File_Write();
            int len = read.Product_Read(product);

            int a = Program.Company_HDD + (HDDsel*1000);
            int b = Program.Company_DB + (DBsel * 200);
            int c = Program.Company_Money - res;

            if (c > 0)
            {
                string regextext = Convert.ToInt32(Program.Company_HDD) + "\r\n" + Convert.ToInt32(Program.Company_DB) + "\r\n" + Convert.ToInt32(Program.Company_Money);
                string regextext2 = Convert.ToInt32(a) + "\r\n" + Convert.ToInt32(b) + "\r\n" + Convert.ToInt32(c);

                StreamReader reader = new StreamReader(@"C:\WHMP\\제품데이터.txt");
                string content = reader.ReadToEnd();
                reader.Close();

                content = Regex.Replace(content, regextext, regextext2);

                StreamWriter writer = new StreamWriter(@"C:\WHMP\\제품데이터.txt");
                writer.Write(content);
                writer.Close();
                if(HDDsel == 0 && DBsel == 0)
                    MessageBox.Show("구입할 것을 선택해주세요");
                else
                    MessageBox.Show("구입이 완료되었습니다. \r\n남은 금액 : " + c);
            }
            else
            {
                MessageBox.Show("돈이 부족합니다 \r\n현재 금액 : " + Convert.ToInt32(Program.Company_Money));
            }

        }

        private void textBox1_TextChanged(object sender, EventArgs e) //제품검색
        {
            List<Program.Product_Date> pinfor = new List<Program.Product_Date>();
            Program.File_Read read = new Program.File_Read();
            int n = read.Product_Read(pinfor);
            
            pdt = new DataTable();
            pdt.Columns.Add("number");
            pdt.Columns.Add("os");
            pdt.Columns.Add("hdd");
            pdt.Columns.Add("db");
            pdt.Columns.Add("pay");
            pdt.Columns.Add("period");
            fillDataTable(pinfor);

            pdv = new DataView(pdt);
            populateListView(pdv);

            if (radio_Num.Checked) { pdv.RowFilter = string.Format("number Like '%{0}%'", textBox1.Text); }
            else if (radio_OS.Checked) { pdv.RowFilter = string.Format("os Like '%{0}%'", textBox1.Text); }
            else if (radio_HDD.Checked) { pdv.RowFilter = string.Format("hdd Like '%{0}%'", textBox1.Text); }
            else if (radio_DB.Checked) { pdv.RowFilter = string.Format("db Like '%{0}%'", textBox1.Text); }
            else if (radio_pay.Checked) { pdv.RowFilter = string.Format("pay Like '%{0}%'", textBox1.Text); }
            else if (radio_period.Checked) { pdv.RowFilter = string.Format("period Like '%{0}%'", textBox1.Text); }

            populateListView(pdv);
        }
        /*재무관리 목록 END */
    }
}