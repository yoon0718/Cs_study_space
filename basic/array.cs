//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace Hello
//{
    
//    class array
//    {

//        static void Main()
//        {
//            // 배열
//            // 같은 형식의 복수 인스턴스를 저장할 수 있는 형식
//            // 참조형식으로써 연속된 메모리 공간(heap)을 가리팀
//            // 반복문, 특히 for/foreach문과 함께 사용하면 효율 향상
//            // 꺾쇠 괄호 [] 안에 배열의 크기를 지정하여 선언

//            // 배열 생성, 초기화
//            int[] array = new int[6] { 1, 3, 6, 4, 2, 5 };
//            string[] Sarray = new string[3] { "A", "B", "C" };

//            int firstArrayNumber = array[0];
//            string firstsArrayNumber = Sarray[0];

//            Console.WriteLine("First Number : " + firstArrayNumber);
//            Console.WriteLine("First Alphbet : " + firstsArrayNumber);

//            int lenOfInt = array.Length;
//            int lenOfString = Sarray.Length;

//            Console.WriteLine("array length : " + lenOfInt);
//            Console.WriteLine("Sarray length : " + lenOfString);

//            // 다차원 배열 - 2차원
//            // 2개의 차원(가로 + 세로)으로 요소 배치
//            // 차원의 길이를 뒤에서부터 읽어 해석
//            // int[2, 3] => 길이가 3인 1차원 배열을 요소로 갖는 길이가 2인 2차원 배열
//            int[,] arrayOne = new int[2, 3] { { 1, 2, 3 }, { 4, 5, 6 } };


//            // 가변배열(jagged array)
//            // 배열의 배열, 즉 배열을 요소로 갖는 배열
//            // 요소로 입력되는 배열의 차원과 길이는 같아야 할 필요 없음
//            // 가변 배열 선언 형식
//            // 데이터 형식[][] 배열 이름 = new 데이터형식[가변배열의 용량][];
//            int[][] jagged = new int[2][] { new int[] { 1000, 2000 }, new int[4] { 4, 5, 6, 7 } };

//            // system.array class
//            // 모든 배열의 기반 클래스이며 배열 그 자체를 나타냄
//            // 배열을 보다 편리하게 다룰 수 있게 도와주는 유틸리티 메소드 제공
//            // 정렬, 탐색, 크기조정 등의 기능을 제공

//            // sort method : 배열을 오름차순으로 정렬
//            Array.Sort(array);
//            Console.WriteLine("sort array : ");
//            foreach(var item in array)
//            {
//                Console.Write(item + " ");
//            }
//            Console.WriteLine();

//            // BinarySearch method : 정렬된 배열에서 값이 ? 인 원소의 인덱스 탐색 및 반환
//            int idx = Array.BinarySearch(array, 3);
//            Console.WriteLine("index of 3 : " + idx);

//            // IndexOf method : 배열에서 값이 ? 인 원소의 인덱스 탐색 및 반환
//            int idx1 = Array.IndexOf(array, 4);
//            Console.WriteLine("index of 4 : " + idx1);

//            // TrueForAll method : 배열의 모든 원소가 조건에 부합할 시 true 아닐시 false
//            bool AllPositive = Array.TrueForAll(array, x => x > 0);
//            Console.WriteLine("모든 요소 조건 부합 여부 : " + AllPositive);

//            // FindIndex : 배열에서 조건에 부합하는 첫 번째 요소의 인덱스 반환
//            int idx2 = Array.FindIndex(array, x => x % 2 == 0);
//            Console.WriteLine("첫 번째 짝수 index : " + idx2);

//            // Resize : 배열의 크기 재조정
//            Array.Resize(ref array, array.Length + 1);
//            array[array.Length - 1] = 7;
//            Console.WriteLine("크기 조정 및 요소 추가 후 배열");
//            foreach(var item in array)
//            {
//                Console.Write(item + " ");
//            }
//            Console.WriteLine();

//            // Clear : 배열의 모든 원소 초기화
//            Array.Clear(array, 0, array.Length);
//            Console.WriteLine("초기화 후 배열");
//            foreach (var item in array)
//            {
//                Console.Write(item + " ");
//            }
//            Console.WriteLine();

//            // GetLength : 지정한 차원의 길이 반환, 다차원배열에서 유용
//            Console.WriteLine("array length : " + array.GetLength(0));

//            // Length : 배열의 길이 반환
//            Console.WriteLine("array length : " + array.Length);

//            // Rank : 배열의 차원 반환
//            Console.WriteLine("array rank : " + array.Rank);


//        }
//    }
//}
