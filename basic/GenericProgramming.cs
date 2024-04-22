//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace Hello
//{

//    // 데이터 형식(Data Type) 일반화를 이용하는 프로그래밍 패러다임 
//    // 한가지 코드를 다양한 데이터 형식에 활용

    
//    class GenericProgramming
//    {
//        // 일반화 메소드
//        // 데이터 형식을 일반화한 메소드
//        // 메소드 이름 뒤에 형식 매개변수를 입력하여 작성
//        // 형식 매개 변수 : <> 사이에 일반화 데이터 형식을 입력
//        // 컴파일 단계에서 형식 매개 변수는 실제 형식으로 치환됨
//        /*
//        void CopyArray(int[] source, int[] target)
//        {
//            for(int i = 0; i < source.Length; i++)
//            {
//                target[i] = source[i];
//            }
//        }

//        void CopyArray(string[] source, string[] target)
//        {
//            for(int i = 0; i > source.Length; i++)
//            {
//                target[i] = source[i];
//            }
//        }
//        */
//        // 형식 매개변수 T를 사용하는 일반화 메소드 정의
//        public static void CopyArray<T>(T[] source, T[] target)
//        {
//            for (int i = 0; i < source.Length; i++)
//            {
//                target[i] = source[i];
//                Console.WriteLine(target[i]);
//            }
//        }
//        // 클래스 이름 뒤에 형식 매개변수 T를 입력하여 일반화 클래스 정의
//        public class GenericList<T>
//        {
//            private T[] array;

//            public T GetElement(int index)
//            {
//                return array[index];
//            }
//        }


//        static void Main(string[] args)
//        {
//            // 메소드 이름 뒤에 <> 안에 구체적인 데이터 형식을 명기하여 일반화 메소드 호출
//            int[] intArray = { 1, 2, 3, 4, 5 };
//            int[] copyIntArray = { 0, 0, 0, 0, 0 };
//            CopyArray<int>(intArray, copyIntArray);

//            string[] stringArray = { "A", "B", "C", "D", "E" };
//            string[] copyStringArray = { "A", "A", "A", "A", "A" };
//            CopyArray<string>(stringArray, copyStringArray);

//            // 클래스 이름 및 생성자 뒤에 <> 안에 구체적인 데이터 형식을 명기하여 일반화 클래스의 객체 생성
//            GenericList<int> list1 = new GenericList<int>();
//            GenericList<string> list2 = new GenericList<string>();

//        }
//    }
//}
