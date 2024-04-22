using System;
using System.Linq;

namespace Hello
{
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

    class Test
    {
        static void Main(string[] args)
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

            

            // 저장된 번호 출력
            Console.WriteLine("LottoNumbers:");
            for (int i = 0; i < 5; i++)
            {
                Console.Write($"Row {i + 1}: ");
                for (int j = 0; j < 6; j++)
                {
                    Console.Write($"{clearMyNum[i].MyLottoNumber[j]} ");
                }
                Console.WriteLine();
            }
        }
    }
}
