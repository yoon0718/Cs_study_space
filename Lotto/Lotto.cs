using System;
using System.Data;
using System.Globalization;
using System.Linq;
using System.Windows.Forms;

namespace Lotto
{
    public partial class Lotto : Form
    {
        private Random random = new Random(); // 난수 생성기

        public Lotto()
        {
            InitializeComponent(); // Windows Forms 디자이너에서 생성된 UI 초기화
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        // 버튼 클릭 시 실행되는 이벤트 핸들러
        private void Button_click(object sender, EventArgs e)
        {
            AllLottoNumber allLottoNumber = new AllLottoNumber(); // 모든 로또 번호 관리 클래스 인스턴스 생성
            ClearMyLottoNumber[] clearMyNum = new ClearMyLottoNumber[5]; // 5개의 특정 로또 번호 관리 클래스 인스턴스 배열 생성

            // 5번 반복하여 번호 생성 및 저장
            for (int i = 0; i < 5; i++)
            {
                clearMyNum[i] = new ClearMyLottoNumber(); // 각 인스턴스 초기화
                allLottoNumber.AllNumber(); // 모든 로또 번호 초기화

                // 각 배열에 랜덤한 로또 번호 생성 및 저장
                for (int j = 0; j < clearMyNum[i].MyLottoNumber.Length; j++)
                {
                    var idx = random.Next(1, allLottoNumber.LottoNumber.Length + 1); // 난수 생성
                    clearMyNum[i].MyLottoNumber[j] = allLottoNumber.LottoNumber[idx - 1]; // 생성된 난수로 로또 번호 설정
                    allLottoNumber.DeleteNumber(allLottoNumber.LottoNumber[idx - 1]); // 이미 선택된 번호 삭제
                }

                clearMyNum[i].sort(); // 로또 번호 정렬
            }

            // 각 로또 번호를 label 컨트롤에 표시
            int labelIndex = 1; // label 인덱스 초기화
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < clearMyNum[i].MyLottoNumber.Length; j++)
                {
                    Label label = Controls.Find("label" + labelIndex, true).FirstOrDefault() as Label; // label 찾기
                    if (label != null)
                    {
                        label.Text = clearMyNum[i].MyLottoNumber[j].ToString("D2"); // 로또 번호 표시
                    }
                    labelIndex++; // 다음 label 인덱스로 이동
                }
            }

            // 오늘 날짜 및 다음 토요일 날짜 표시
            DateTime dateToday = DateTime.Today; // 오늘 날짜
            DateTime SaturdayDate = dateToday.AddDays(Convert.ToInt32(DayOfWeek.Saturday) - Convert.ToInt32(dateToday.DayOfWeek)); // 다음 토요일 날짜 계산
            nowTime.Text = DateTime.Now.ToString("yyyy/MM/dd  (ddd)"); // 현재 날짜 표시
            checkTime.Text = SaturdayDate.ToString("yyyy/MM/dd  (ddd)"); // 다음 토요일 날짜 표시
        }
    }

    // 모든 로또 번호 관리 클래스
    class AllLottoNumber
    {
        public int[] LottoNumber = new int[45]; // 로또 번호 배열

        // 모든 로또 번호 초기화 메서드
        public void AllNumber()
        {
            for (int i = 0; i < LottoNumber.Length; i++)
            {
                LottoNumber[i] = i + 1; // 1부터 45까지의 숫자로 초기화
            }
        }

        // 번호 삭제 메서드
        public void DeleteNumber(int Delete)
        {
            LottoNumber = LottoNumber.Where(x => x != Delete).ToArray(); // 삭제된 번호를 제외하고 다시 배열로 저장
        }
    }

    // 특정 로또 번호 관리 클래스
    class ClearMyLottoNumber
    {
        public int[] MyLottoNumber = new int[6]; // 로또 번호 배열

        // 로또 번호 정렬 메서드
        public void sort()
        {
            Array.Sort(MyLottoNumber); // 로또 번호 정렬
        }
    }
}
