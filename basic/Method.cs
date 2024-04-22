//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace Hello
//{
//    internal class Method
//    {
//        // 메소드(method)
//        // 일련의 코드를 하나의 이름 아래 묶는 것
//        // 묶은 코드는 메소드의 이름을 불러주는 것만으로 실행
//        // c/cpp 에서는 함수(function), 파스칼에서는 프로시져(Procedure) 등으로 부름

//        // 메소드 선언
//        // 클래스 내부에 선언
//        // 메소드 선언 필수 요소 세가지
//        // 1) 반환 형식
//        // 2) 메소드 이름
//        // 3) 매개변수 목록
//        // 결과를 반환할 때 return문 사용

//        /*
//         한정자 반환_형식 메소드_이름 ( 매개_변수_목록 )
//        {
//        실행하려는 코드
//        }
//         */
        
//        //ex
//        static int MethodTest(int a, int b, int c)
//        {
//            int sum = a + b + c;
        
//            return sum;
//        }

//        // return에 관하여
//        // 호출자에게 결과를 반환
//        // 프로그램의 제어를 즉시 호출자에게 이동시킴
//        // 메소드 중간에 호출하는 경우 메소드에 실행되지 않은 코드가 생길 수 있음
//        // 반환형식과 일치하는 데이터를 반환해야 함
//        // 메소드가 void 형식인 경우 반환값 없이 사용 가능

//        static void PrintProfile(string name, string phone)
//        {
//            if (name == "")
//            {
//                Console.WriteLine("이름을 입력해주세요");
//                return;
//            }
//            Console.WriteLine("이름 : {0}, 전화번호 : {1}", name, phone);

//        }

//        // 참조로 인수 전달하기
//        // 매개변수가 인수를 참조
//        // ref키워드를 이용하여 선언/호출

//        static void RefSwap(ref int a, ref int b)
//        {
//            int temp = b;
//            b = a;
//            a = temp;
//        }

//        // 출력 전용 매개변수
//        // 메소드는 out 키워드로 한정한 매개변수에 결과를 입력해야 함
//        // out 키워드는 ref키워드와 비슷하지만, 참조로 인수 전달을 하는 경우 인수의 값이
//        // 수정되지 않아도 컴파일러가 에러를 출력하지 않음

//        static void OutKeyword(int a, int b, out int quotient, out int remainder)
//        {
//            quotient = a / b;
//            remainder = a % b;
//        }

//        // 메소드 오버로딩
//        // 하나의 메소드 이름에 여러 버전의 구현을 올리는 것
//        static int Plus(int a, int b)
//        {
//            return a + b;
//        }
//        static double Plus(double a, double b)
//        {
//            return a + b;
//        }
        


//        static void Main(string[] args)
//        {

//            int a = 1;
//            int b = 2;
//            int c = 3;
//            int d = MethodTest(a, b, c);
//            Console.WriteLine(d);

//            PrintProfile("윤여록", "01044164679");
//            PrintProfile("", "01044164679");

//            int x = 0;
//            int y = 100;
//            Console.WriteLine("{0}, {1}", x, y);
//            RefSwap(ref x, ref y);
//            Console.WriteLine("{0}, {1}", x, y);

//            int aOut = 20;
//            int bOut = 3;
//            int cOut;
//            int dOut;
//            OutKeyword(aOut, bOut, out cOut, out dOut);
//            Console.WriteLine("{0} / {1}", cOut, dOut);



//        }
//    }
//}
