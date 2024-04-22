//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace Hello
//{
//    // 예외 - Exception
//    // 예정된 프로그램 프름에서 벗어나는 사건
//    // 예외처리 - Exception Handling)
//        // 예외가 프로그램의 오류나 다운으로 이어지지 않도록 적절하게 처리하는 것
    
    
    
//    class Exception
//    {
//        // 예외 일으키기
//        // throw 문으로 예외 객체를 던짐
//        // system.exception 클래스와 그 파생클래스의 인스턴스를 인수로 사용
//        static void DoSomething(int arg)
//        {
//            if (arg < 10)
//            {
//                Console.WriteLine("arg : {0}", arg);
//            }
//            else
//            {
//                throw new System.Exception("arg가 10보다 큽니다");
//            }
//        }

//        // finally 문
//        // try~catch 블록 마지막에 붙여 사용
//        // 예외 처리 이후의 뒷정리를 할 때 사용함
//        // 예외가 일어나든 일어나지 않든 반드시 실행

//        static void Main(string[] args)
//        {
//            int[] arr = { 1, 2, 3, 4, 5 };

//            try
//            {
//                for(int i = 0; i < 10; i++)
//                {
//                    Console.Write(arr[i]);
//                }
//            }
//            catch(IndexOutOfRangeException e)
//            {
//                Console.WriteLine("예외발생"); 
//            }

//            try
//            {
//                DoSomething(11);
//            }
//            catch(System.Exception e)
//            {
//                Console.WriteLine(e.Message);
//            }
//        }
//    }
//}
