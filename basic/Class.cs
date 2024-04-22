//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace Hello
//{

//    class Animal // 생성자
//        // 필드 초기화, 자원(파일, 커넥션, db 등등..) 초기화 
//    {
//        public string Name; // 필드
//        public string Gender; // 필드
//        public string Age; // 필드

//        public void Check() // 메소드
//        {
//            Console.WriteLine("{0} : Profile_load", Name);
//        }
//    }


//    // 생성자 오버로딩
//    // 객체의 필드를 초기화하는 다양한 옵션 제공 기능
//    class Cat
//    {
//        public string Name;
//        public string Color;
//        public Cat()
//        {
//            Name = "";
//            Color = "";
//        }

//        public Cat(string _Name, string _Color)
//        {
//            Name = _Name;
//            Color = _Color;
//        }

//        ~Cat() // 종료자
//        {
//            Console.WriteLine($"{Name} : Over");
//        }

//        public void Check()
//        {
//            Console.WriteLine("{0} / {1}", Name, Color);
//        }
//    }

//    class Class
//    {


//        static void Main(string[] args)
//        {
//            Animal animal = new Animal(); // 객체 생성
//            animal.Name = "고양이";
//            animal.Gender = "남자";
//            animal.Age = "5";

//            animal.Check();

//            Console.WriteLine("{0} / {1} / {2}", animal.Name, animal.Gender, animal.Age);
//            Console.WriteLine("-------------------------------");

//            Cat no = new Cat();
//            no.Check();

//            Cat kitty = new Cat();
//            kitty.Name = "키티";
//            kitty.Color = "white";
//            kitty.Check();

//            Cat nabi = new Cat("나비", "노란색");
//            nabi.Check();



//        }

//    }
//}
