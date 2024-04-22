//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;
//using System.Reflection;

//namespace Hello
//{
//    class Profile
//    {
//        public string Name { get; set; }
//        public string Phone { get; set; }

//        public void Print()
//        {
//            Console.WriteLine($"{Name}, {Phone}");
//        }
//    }
//    class Reflection
//    {

//        // 리플렉션(Reflection)
//        // 런타임에 객체의 형식(Type) 정보를 들여다보는 기능
//        // System.Object은 형식 정보를 반환하는 GetType()메소드 보유
//        // 즉, 모든 데이터 형식은 System.Object 형식을 상속하므로 GetType() 메소드 또한 보유

//        // Object.GetType() method 는 System.Type 형식 결과를 반환
//        // Type 형식은 .NET 데이터 형식의 모든 정보(메소드, 필드, 프로퍼티 등)를 표현

//        //System.Type의 주요 메소드
//        //메소드 / 반환 형식 / 설명
//        //GetConstructors() / ConstructorInfo[] / 해당 형식의 모든 생성자 목록을 반환
//        //GetEvents() / EventInfo[] / 해당 형식의 이벤트 목록을 반환
//        //GetFields() / FieldInfo[] / 해당 형식의 필드 목록을 반환
//        //GetGenericArguments() / Type[] / 해당 형식의 형식 매개 변수 목록을 반환
//        //GetInterfaces() / Type[] / 해당 형식이 상속하는 인터페이스 목록을 반환
//        //GetMembers() / MemberInfo[] / 해당 형식의 멤버 목록을 반환
//        //GetMethod() / MethodInfo[] / 해당 형식의 메소드 목록을 반환
//        //GetNestedTypes() / Type[] / 해당 형식의 내장 형식 목록을 반환
//        //GetProperties() / PropertyInfo[] / 해당 형식의 프로퍼티 목록을 반환

//        // 리플렉션을 이용한 객체 생성 및 활용
//        // System.Activator 클래스에게 System.Type 객체를 입력하여 인스턴스를 생성
//        // PropertyInfo 클래스의 GetValue()로 값을 읽고, SetValue() 로 값 기록
//        // MethodInfo 클래스의 Invoke() 메소드를 통해 메소드 호출

        

//        static void Main()
//        {
//            //int a = 0;
//            //Type type = a.GetType();
//            //FieldInfo[] fields = Type.GetType();

//            //foreach (FieldInfo field in fields)
//            //{
//            //    Console.WriteLine("Type:{0}, Name:{1}, field.FieldType.Name, field.Name);
//            //}

//            Type type = typeof(Profile);
//            Profile profile = (Profile)Activator.CreateInstance(type);

//            PropertyInfo name = type.GetProperty("Name");
//            PropertyInfo phone = type.GetProperty("Phone");

//            name.SetValue(profile, "박찬호", null);
//            phone.SetValue(profile, "997-55111", null);
//            Console.WriteLine($"{name.GetValue(profile, null)}, {phone.GetValue(profile, null)}");

//            MethodInfo method = type.GetMethod("Print");
//            method.Invoke(profile, null);
//        }

//    }
//}
