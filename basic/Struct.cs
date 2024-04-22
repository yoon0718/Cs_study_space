//using system;
//using system.collections.generic;
//using system.linq;
//using system.text;
//using system.threading.tasks;

//namespace hello
//{

//    // 구조체
//    // class 대신 struct를 이용하여 선언
//    // 클래스는 참조형식, 구조체는 값형식
//    // 클래스 인스턴스는 가비지 콜렉터가 제거, 구조체 인스턴스는 스택이 자동 제거

//    // 튜플
//    // 기본적으로는 구조체, 즉 값 형식
//    // 일부 코드에서 즉석에서 활용되는 형식을 만들 때 적합
//    // 프로그램 전역에서 사용할 형식에는 부적합

//    class person
//    {
//        public string name;
//    }
//    struct personone
//    {
//        public string nameone;
//    }

//    class struct
//    {
//        static void main(string[] args)
//        {
//            person person1 = new person();
//            person1.name = "yoon";

//            person person2 = person1;
//            person2.name = "kim";

//            console.writeline("person1 name : " + person1.name);
//            console.writeline("person2 name : " + person2.name);

//            personone personone1 = new personone();
//            personone1.nameone = "yoonone";

//            personone personone2 = personone1;
//            personone2.nameone = "kimone";

//            console.writeline("personone1 name : " + personone1.nameone);
//            console.writeline("personone2 name : " + personone2.nameone);


//        }

//    }
//}
