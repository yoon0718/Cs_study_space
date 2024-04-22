//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace Hello
//{
//    // 오버라이딩
//    // 기반 클래스에서 선언된 메소드를 자식 클래스에서 재정의하는 것
//    // 기반 클래스에서 오버라이딩할 메소드를 미리 virtual로 한정
//    // 파생 클래스는 virtual 메소드를 override 한정자를 이용하여 재선언(재정의)
//    class Base
//    {
//        public virtual void Initialize()
//        {
//            Console.WriteLine("Armored");
//        }
//    }

//    class BaseAccessModifier : Base
//    {
//        public override void Initialize()
//        {
//            base.Initialize();
//            Console.WriteLine("Repusor Tays Armed");
//        }
//    }
//    class OverRide
//    {
//        static void Main(string[] args)
//        {
//            BaseAccessModifier a = new BaseAccessModifier();
//            a.Initialize();
//        }

        
//    }
//}
