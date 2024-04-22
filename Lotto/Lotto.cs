using System;
using System.Data;
using System.Globalization;
using System.Linq;
using System.Windows.Forms;


namespace Lotto
{
    public partial class Lotto : Form
    {
        private Random random = new Random();
        public Lotto()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Button_click(object sender, EventArgs e)
        {
            AllLottoNumber allLottoNumber = new AllLottoNumber();
            ClearMyLottoNumber[] clearMyNum = new ClearMyLottoNumber[5]; // 5개의 ClearMyLottoNumber 인스턴스를 생성
            Random random = new Random();

            // 5번 반복하여 번호 생성 및 저장
            for (int i = 0; i < 5; i++)
            {
                clearMyNum[i] = new ClearMyLottoNumber(); // 각 인스턴스를 초기화
                allLottoNumber.AllNumber();
                // 각 배열에 난수 생성 및 저장
                for (int j = 0; j < clearMyNum[i].MyLottoNumber.Length; j++)
                {
                    var idx = random.Next(1, allLottoNumber.LottoNumber.Length + 1);
                    clearMyNum[i].MyLottoNumber[j] = allLottoNumber.LottoNumber[idx - 1];
                    allLottoNumber.DeleteNumber(allLottoNumber.LottoNumber[idx - 1]);
                }

                clearMyNum[i].sort();

            }

            int labelIndex = 1;
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < clearMyNum[i].MyLottoNumber.Length; j++)
                {
                    Label label = Controls.Find("label" + labelIndex, true).FirstOrDefault() as Label;
                    if (label != null)
                    {
                        label.Text = clearMyNum[i].MyLottoNumber[j].ToString("D2");
                    }
                    labelIndex++;
                }
            }
            // 오늘 날짜 지정
            DateTime dateToday = DateTime.Today;
            // DayofWeek는 월요일부터 일요일까지 열거형으로 1~7로 표현
            // AddDates로 산술
            // 구하고싶은요일열거형 - 오늘요일열거형 + 오늘요일열거형
            DateTime SaturdayDate = dateToday.AddDays(Convert.ToInt32(DayOfWeek.Saturday) - Convert.ToInt32(dateToday.DayOfWeek));

            
            nowTime.Text = DateTime.Now.ToString("yyyy/MM/dd  (ddd)");
            checkTime.Text = SaturdayDate.ToString("yyyy/MM/dd  (ddd)");



        }
    }
    class AllLottoNumber
    {
        public int[] LottoNumber = new int[45];

        public void AllNumber()
        {
            for (int i = 0; i < LottoNumber.Length; i++)
            {
                LottoNumber[i] = i + 1;
            }
        }

        public void DeleteNumber(int Delete)
        {
            LottoNumber = LottoNumber.Where(x => x != Delete).ToArray();
        }
    }

    class ClearMyLottoNumber
    {
        public int[] MyLottoNumber = new int[6];

        public void sort()
        {
            Array.Sort(MyLottoNumber);
        }
    }
    
}

