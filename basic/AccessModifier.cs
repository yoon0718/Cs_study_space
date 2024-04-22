//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace Hello
//{
//    // 접근한정자
//    // 객체간의 상호 작용이 중심인 OOP에서는 각 객체는 다른 객체에게 자신의 내부 사정을 공유하지 않음
//    // 다른 객체에게 공유해야 하는 멤버만 접근한정자를 이용하여 공개
//    // 접근한정자는 멤버(필드, 메소드 등등)를 외부에 어떤 수준으로 공개할 지 지정
//        // public : 모든 곳에서 접근 가능
//        // protected : 외부에선 접근 불가, 파생클래스에서는 접근 가능
//        // private : 클래스 내부에서만 접근 가능, 파생클래스에서도 접근 불가
//    class One
//    {
//        protected int x = 1234;
//    }
//    class AccessModifier
//    {
        
            
//        static void Main(string[] args)
//        {
//            One a = new One();
//            a.x = 100;
//        }
//    }
//}
