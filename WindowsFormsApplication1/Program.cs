using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using WHMP;

namespace WindowsFormsApplication1
{
    static class Program
    {
        public static int Company_HDD = 0;    // 회사 하드량
        public static int Company_DB = 0;     // 회사 DB량
        public static int Company_Money = 0;  // 회사 자금으로 int 자료형이고 File_Read에서 Product_Read를 보면 이 부분을 읽는게 있으니 참조하시고

        //여기부분은 제품,인사,거래처 데이터의 형태
        public class Product_Date
        {
            public string number;
            public string OS;
            public string HDD;
            public string DB;
            public string traffic;
            public string pay;
            public string period;

            public string Number
            {
                get { return number; }
            }
            public string Os
            {
                get { return OS; }
            }
            public string Hdd
            {
                get { return HDD; }
            }
            public string Db
            {
                get { return DB; }
            }
            public string Traffic
            {
                get { return traffic; }
            }
            public string Pay
            {
                get { return pay; }
            }
            public string Priod
            {
                get { return period; }
            }
        }

        public class InterInfor
        {
            public String ID;
            public String PW;
            public String name;
            public String EmNum;
            public String Position;
            public string identity; // 이게 직원 고유 번호

            public string Id
            {
                get { return ID; }
            }
            public string Pw
            {
                get { return PW; }
            }
            public string Name
            {
                get { return name; }
            }
            public string Emnum
            {
                get { return EmNum; }
            }
            public string POsition
            {
                get { return Position; }
            }
            public string Identity
            {
                get { return identity; }
            }
        }

        public class Customer_Date
        {
            public string ITnumber; //거래번호
            public string Centerprise;  //기업명                                               
            public string Cboss;  // 대표자명                                                   
            public string Cphone; //거래처 번호
            public string Pnumber; // 제품번호
            public string Ppay;  //제품가격
            public string Pperiod; //기간
            public string Iname; //직원이름
            public string IEnNum;  //직원 전화번호
            public string Iposition; //직급
            public string Iidentity; // 직원 고유 번호
        }
        public class Money_Date /////////////재무 데이터
        {
            public string iitnumber; //제품번호
            public int primecost; // 원가
            public int fixedprice; // 정가
            public int amount; // 수량
            public int apc; // 총 원가
            public int afp; // 총 정가
            public int netprofit; //순 이익(총 정가-총 원가)
            public int anp;//총 순 이익(모든 총 정가 - 모든 총 원가)
        }
        //여기까지 제품, 인사, 거래처 데이터
        public class File_Read // 파일 읽어오는걸로 제품, 인사, 거래처 순서임
        {
            public int Product_Read(List<Product_Date> infor)
            {
                StreamReader sr = new StreamReader(@"C:\WHMP\제품데이터.txt");
                int i = 0;

                if (sr.ReadLine() == null)
                {
                    Company_HDD = 0;
                    Company_DB = 0;
                    Company_Money = 0;
                }
                else
                {
                    Company_HDD = int.Parse(sr.ReadLine());
                    Company_DB = int.Parse(sr.ReadLine());
                    Company_Money = int.Parse(sr.ReadLine());
                }
                string blank = sr.ReadLine();            //그 구분선을 읽을 변수이고 private로 선언하면 오류가 발생하여 그냥 선언하였고 File_Write에서 Product_Write에 입력되는 구분선이 나옴

                while (sr.Peek() >= 0)
                {
                    Product_Date value = new Product_Date();
                    value.number = sr.ReadLine();
                    value.OS = sr.ReadLine();
                    value.HDD = sr.ReadLine();
                    value.DB = sr.ReadLine();
                    value.traffic = sr.ReadLine();
                    value.pay = sr.ReadLine();
                    value.period = sr.ReadLine();
                    infor.Add(value);
                    i++;
                }
                sr.Close();
                return i;
            }
            public int Inter_Read(List<InterInfor> infor)
            {
                StreamReader sr = new StreamReader(@"C:\WHMP\인사데이터.txt");
                int i = 0;

                while (sr.Peek() >= 0)
                {
                    InterInfor name = new InterInfor();
                    name.ID = sr.ReadLine();
                    name.PW = sr.ReadLine();
                    name.name = sr.ReadLine();
                    name.EmNum = sr.ReadLine();
                    name.Position = sr.ReadLine();
                    name.identity = sr.ReadLine();

                    infor.Add(name); //list에 추가
                    i++;
                } //파일을 읽어와서 list에 저장
                sr.Close();
                return i;
            }
            public int Customer_Read(List<Customer_Date> infor)
            {
                StreamReader sr = new StreamReader(@"C:\WHMP\거래처데이터.txt");
                List<Product_Date> Pinfor = new List<Product_Date>();
                List<InterInfor> Iinfor = new List<InterInfor>();

                int Pnum = Product_Read(Pinfor);
                int Inum = Inter_Read(Iinfor);

                int i = 0;

                while (sr.Peek() >= 0)
                {
                    Customer_Date value = new Customer_Date();
                    value.ITnumber = sr.ReadLine();
                    value.Centerprise = sr.ReadLine();
                    value.Cboss = sr.ReadLine();
                    value.Cphone = sr.ReadLine();
                    value.Pnumber = sr.ReadLine();
                    value.Iidentity = sr.ReadLine();
                    for (int n = 0; n < Pnum; n++)
                    {
                        if (value.Pnumber == Pinfor[n].number)
                        {
                            value.Ppay = Pinfor[n].pay;
                            value.Pperiod = Pinfor[n].period;
                            break;
                        }
                        else if (n == Pnum - 1)
                        {
                            value.Ppay = "등록된 제품이 없습니다.";
                            value.Pperiod = "등록된 제품이 없습니다.";
                        }
                    }
                    for (int n = 0; n < Inum; n++)
                    {
                        if (value.Iidentity == Iinfor[n].identity)
                        {
                            value.Iname = Iinfor[n].name;
                            value.IEnNum = Iinfor[n].EmNum;
                            value.Iposition = Iinfor[n].Position;
                        }
                        else if (n == Inum - 1)
                        {
                            value.Iname = "담당 직원이 없습니다.";
                            value.IEnNum = "담당 직원이 없습니다.";
                            value.Iposition = "담당 직원이 없습니다.";
                        }
                    }
                    infor.Add(value);
                    i++;
                }
                sr.Close();
                return i;
            }
            public List<Money_Date> Money_Read(List<Money_Date> Money,int n)
            {

                string[] stringArray = new string[5] { "1","2","3","4","5" }; //제품번호 5개로 한정해서 보여줄거라고 했기때문에
                int[] intArray = new int[5] { 0, 0, 0, 0, 0 }; // 제품번호의 수
                /* 제품번호 읽어들이고 동일한 제품번호는 수 올리기 */
                List<Product_Date> Pinfor = new List<Product_Date>();
                int Pnum = Product_Read(Pinfor);
                List<Customer_Date> Cinfor = new List<Customer_Date>();
                int Cnum = Customer_Read(Cinfor);

                for (int i = 0; i < 5; i++)
                {
                    for (int k = 0; k < Cnum; k++)
                    {
                        if (stringArray[i] == Cinfor[k].Pnumber)
                        {
                            intArray[i] += 1;
                        }
                    }
                }

                /* 제품번호 읽어들이고 동일한 제품번호는 수 올리기END  */

                Money_Date value = new Money_Date();
                value.iitnumber = stringArray[n];
                value.primecost = (n + 1) * 100000;
                value.fixedprice = (n + 1) * 200000;
                value.amount = intArray[n];
                value.apc = intArray[n] * (n + 1) * 100000;
                value.afp = intArray[n] * (n + 1) * 200000;
                value.netprofit = (intArray[n] * (n + 1) * 200000) - (intArray[n] * (n + 1) * 100000);
                value.anp = 5*(intArray[n] * (n + 1) * 200000) - (intArray[n] * (n + 1) * 100000);
                Money.Add(value);
                
                return Money;
            }
        }

        public class File_Write //여기서는 파일 입력하는 부분
        {
            public void Product_Write(List<Product_Date> infor, int num)
            {
                File.Delete(@"C:\WHMP\\제품데이터.txt");
                FileStream create = File.Create(@"C:\WHMP\\제품데이터.txt");
                create.Close();
                StreamWriter sw = new StreamWriter(@"C:\WHMP\\제품데이터.txt");

                sw.WriteLine("-----------");
                sw.WriteLine(Company_HDD);  // 여기서 파일에 입력이 되고
                sw.WriteLine(Company_DB);   //
                sw.WriteLine(Company_Money);//
                sw.WriteLine("-----------");// 여기서 구분선을 입력할거임

                for (int i = 0; i < num - 1; i++)
                {
                    sw.WriteLine(infor[i].number);
                    sw.WriteLine(infor[i].OS);
                    sw.WriteLine(infor[i].HDD);
                    sw.WriteLine(infor[i].DB);
                    sw.WriteLine(infor[i].traffic);
                    sw.WriteLine(infor[i].pay);
                    sw.WriteLine(infor[i].period);
                }
                sw.Close();
            }
            public void Inter_Write(List<InterInfor> infor, int num)
            {
                File.Delete(@"C:\WHMP\\인사데이터.txt");
                FileStream create = File.Create(@"C:\WHMP\\인사데이터.txt");
                create.Close();
                StreamWriter sw = new StreamWriter(@"C:\WHMP\\인사데이터.txt");

                for (int i = 0; i < num - 1; i++)
                {
                    sw.WriteLine(infor[i].ID);
                    sw.WriteLine(infor[i].PW);
                    sw.WriteLine(infor[i].name);
                    sw.WriteLine(infor[i].EmNum);
                    sw.WriteLine(infor[i].Position);
                    sw.WriteLine(infor[i].identity);
                }
                sw.Close();
            }
            public void Customer_Write(List<Customer_Date> infor, int num)
            {
                File.Delete(@"C:\WHMP\\거래처데이터.txt");
                FileStream create = File.Create(@"C:\WHMP\\거래처데이터.txt");
                create.Close();
                StreamWriter sw = new StreamWriter(@"C:\WHMP\\거래처데이터.txt");

                for (int i = 0; i < num - 1; i++)
                {
                    sw.WriteLine(infor[i].ITnumber);
                    sw.WriteLine(infor[i].Centerprise);
                    sw.WriteLine(infor[i].Cboss);
                    sw.WriteLine(infor[i].Cphone);
                    sw.WriteLine(infor[i].Pnumber);
                    sw.WriteLine(infor[i].Iidentity);
                }
            }
        }
        /// <summary>
        /// 해당 응용 프로그램의 주 진입점입니다.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form0());
        }
    }
}