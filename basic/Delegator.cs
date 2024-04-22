//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace Hello
//{
//    // 대리자 - Delegator
//    // 코드(method)를 대신 실행하는 객체
//    // 메소드를 호출하듣 사용(즉, 인수를 입력하고 결과를 반환 받음)
//    // 단, 대리자가 실행할 코드는 컴퍼일 시점이 아닌 실행 시점에 결정

//    // delegate 키워드를 이용하여 선언
//    // 메소드와 같이 대리자 또한 매개변수 목록과 반환 형식을 가짐

//    class Delegator
//    {
//        private delegate int MyDelegate(int a, int b);

//        private static int Plus(int a, int b)
//        {
//            return a + b;
//        }
//        private static int Minus(int a, int b)
//        {
//            return a - b;
//        }

//        static void Main()
//        {
//            MyDelegate dele = new MyDelegate(Plus);

//            Console.WriteLine("Plus : " + dele(7, 3));

//            dele = new MyDelegate(Minus);

//            Console.WriteLine("Minus : " + dele(7, 3));

//            // 익명 메소드 - Anonymous Method)
//            // 다른 코드 블록애서 재사용될 일이 없는 이름 없는 메소드
//                // 사전 정의된 대리자 형식(반환형식, 매개변수)에 맞춰 익명 메소드 작성
//                // 익명 메소드 정의시 delegate 키워드로 시작하며, 정의된 코드는 대리자 참조에 할당
//                // 익명 메소드를 할당받은 대리자 참조 호출
//            MyDelegate Anonymous;
//            Anonymous = delegate (int a, int b)
//            {
//                return a * b;
//            };
//            Console.WriteLine("multiply : " + Anonymous(3, 3));

//        }
//    }
//}
