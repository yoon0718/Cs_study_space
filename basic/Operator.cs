//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace Hello
//{
//    internal class Operator
//    {

        
//        static void Main(string[] args)
//        {
//            //산술연산자( +, -, *, /, % )
//            //수치 형식의 데이터 연산
//            //정수, 부동 소수점, 소수 형식에 대해서만 사용 가능

//            //증가, 감소 연산자
//            int a = 10;
//            int b = 20;
//            Console.WriteLine("{0}", a++);
//            Console.WriteLine("{0}", ++a);
//            Console.WriteLine("{0}", b--);
//            Console.WriteLine("{0}", --b);
//            Console.WriteLine("--------------");

//            // 문자열 결합 연산자
//            int result = 123 + 456;
//            String resultOne = "123" + "456";
//            Console.WriteLine("{0}", result);
//            Console.WriteLine("{0}", resultOne);
//            Console.WriteLine("--------------");

//            // 관계 연산자
//            // 두 피연산자 사이의 관계를 확인하는 연산자
//            // <, >, <=, >=, ==, !=
//            Console.WriteLine("{0}", 1 < 5);
//            Console.WriteLine("{0}", 1 > 5);
//            Console.WriteLine("{0}", 1 <= 5);
//            Console.WriteLine("{0}", 1 >= 5);
//            Console.WriteLine("{0}", 1 == 5);
//            Console.WriteLine("{0}", 1 != 5);
//            Console.WriteLine("--------------");

//            // 논리 연산자
//            // 참과 거짓의 진리값이 피연산자인 연산자
//            // &&(and), ||(or), !(not)
//            bool tr = true;
//            bool fa = false;
//            Console.WriteLine("{0}", tr && tr);
//            Console.WriteLine("{0}", tr && fa);
//            Console.WriteLine("{0}", tr || tr);
//            Console.WriteLine("{0}", tr || fa);
//            Console.WriteLine("{0}", !tr);
//            Console.WriteLine("{0}", !fa);
//            Console.WriteLine("--------------");

//            // 조건 연산자
//            // 조건에 따라 두 값 중 하나의 값을 반환하는 연산자
//            int c = 30;
//            string resultC = c == 30 ? "삼십" : "삼십아님";
//            string resultCPlus = c == 40 ? "삼십" : "삼십아님";
//            Console.WriteLine("{0}", resultC);
//            Console.WriteLine("{0}", resultCPlus);
//            Console.WriteLine("--------------");

//            // 비트 연산자
//            // 비트 수준에서 데이터를 가공하는 연산자
//            // <<(왼쪽으로 밀기), >>(오른쪽으로 밀기), &(논리곱), |(논리합), ^(배타적논리합), ~(보수)
//            Console.WriteLine("{0}", 240 << 2);
//            Console.WriteLine("{0}", 240 >> 2);
//            Console.WriteLine("{0}", 240 & 2);
//            Console.WriteLine("{0}", 240 | 2);
//            Console.WriteLine("{0}", 240 ^ 2);
//            Console.WriteLine("{0}", ~240);
//            Console.WriteLine("--------------");

//            // 할당 연산자
//            // 변수 또는 상수에 피연산자를 할당하는 연산자





//        }
//    }
//}
