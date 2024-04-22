//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace Hello
//{
//    class Delegator_Lambda
//    {
//        private delegate int MyDelegate(int a, int b);

//        static void Main(string[] args)
//        {
//            // 무명 함수(anonymous Function) : 람다식으로 만드는 익명 메소드
//            // 무명함수를 작성하기 위해서는 먼저 대리자로 무명함수의 모습을 결정
//            MyDelegate lambda = (int a, int b) => a + b;

//            // Func 대리자와 Action 대리자
//            // .NET 라이브러리에 사전 정의되어 있는 대리자
//            // 익명 메서도/무명 함수 정의를 위해 매번 대리자를 새롭게 정의하는 불편을 제거
//            // 일반화와 최대 16개 매개변수를 지원
//            // Func 대리자 : 반환값이 있는 익명 메소드/무명 함수용 대리자
//            // Action 대리자 : 반환값이 없는 익명/무명 함수용 대리자

//            // Func 대리자
//            Func<int> func1 = () => 100;
//            Console.WriteLine($"func1의 값 : {func1()}");

//            Func<int, int> func2 = (x) => x * 2;
//            Console.WriteLine($"func2(100)의 값 : {func2(100)}");

//            Func<int, int, string> func3 = (x, y) => $"{x + y}";
//            Console.WriteLine($"func3(100, 2)의 값 : {func3(100, 2)}");

//            // Action 대리자
//            Action act1 = () => Console.WriteLine("");
//            act1();
//            Action<int, int> act2 = (x, y) => Console.WriteLine($"x : {x}, y : {y}, x*y : {x * y}");
//            act2(10, 30);

//            string result = string.Empty;
//            Action<string> act3 = (str)=>result = $"blank{str}";
//            act3("space");
//            Console.WriteLine($"result : {result}");

//        }
//    }
//}
