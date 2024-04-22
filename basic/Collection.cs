//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;
//using System.Collections;

//namespace Hello
//{


//    class Collection
//    {
//        static void Main()
//        {
//            // 컬렉션
//            // 같은 성격을 띄는 데이터의 모음을 다루는 자료 구조
//            // 배열(system.array) 도 .NET이 제공하는 컬렉션 자료구조 중 하나
//            // ArrayList, Queue, Stack, Hashtable 등이 있음


//            // 배열과 같이 인덱스를 이용하여 요소에 접근 가능
//            // 필요에 따라 동적으로 크기가 증가
//            // 요소를 추가하는 Add(), 삭제하는 RemoveAt(), 삽입하는 Insert() 메서드 등을 제공

//            // 컬렉션 - arraylist
//            // ArrayList 생성
//            ArrayList list = new ArrayList();

//            // 요소 추가
//            list.Add("one");
//            list.Add("two");
//            list.Add("three");

//            foreach (var item in list)
//            {
//                Console.Write(item + " ");
//            }
//            Console.WriteLine();

//            // 요소 삭제
//            list.RemoveAt(0);

//            foreach (var item in list)
//            {
//                Console.Write(item + " ");
//            }
//            Console.WriteLine();

//            // 요소 삽입
//            list.Insert(1, "hi");
//            foreach (var item in list)
//            {
//                Console.Write(item + " ");
//            }
//            Console.WriteLine();


//            // 컬렉션 - queue
//            // 선입선출(FIFO : First In First Out) 구조의 자료구조
//            // 데이터를 입력하는 Enqueue(), 출력하는 Dequeue()메소드 제공

//            Queue<int> que = new Queue<int>();
//            que.Enqueue(1);
//            que.Enqueue(2);
//            que.Enqueue(3);
//            que.Enqueue(4);
//            que.Enqueue(5);
//            foreach (var item in que)
//            {
//                Console.Write(item + " ");
//            }
//            Console.WriteLine();

//            int a = que.Dequeue();
//            Console.WriteLine("que first 요소 제거 : " + a);
//            int b = que.Dequeue();
//            Console.WriteLine("que second 요소 제거 : " + b);

//            // 컬렉션 - stack
//            // 선입후출(FILO : First In Last Out) 구조의 자료구조
//            // 데이터를 입력하는 Push(), 출력하는 Pop() 메소드 제공
//            // stack 생성
//            Stack<int> stack = new Stack<int>();
//            // Push method를 통해 요소 추가
//            stack.Push(1);
//            stack.Push(2);
//            stack.Push(3);
//            Console.WriteLine("요소 Push: ");
//            foreach (var item in stack)
//            {
//                Console.Write(item + " ");
//            }
//            Console.WriteLine();

//            // Pop method를 통해 요소 제거
//            int popedElement = stack.Pop();
//            Console.WriteLine("요소 Pop : ");
//            Console.WriteLine("Pop된 요소 : " + popedElement);
//            foreach (var item in stack)
//            {
//                Console.Write(item + " ");
//            }
//            Console.WriteLine();

//            // 컬렉션 - HashTable
//            // 키(key)와 값(value)로 이루어진 데이터를 다룰 때 사용
//            // 키를 해싱(Hashing)해서 테이블 내의 주소를 계산
//            // 배열처럼 다루기 간편하고 탐색 속도도 빠름

//            //HashTable 생성
//            Hashtable hashtb = new Hashtable();

//            // Add method 를 사용하여 키-값 추가
//            hashtb.Add("apple", 1);
//            hashtb.Add("banana", 2);
//            hashtb.Add("orange", 3);

//            Console.WriteLine("요소 추가 : ");
//            foreach (DictionaryEntry entry in hashtb)
//            {
//                Console.WriteLine("key : " + entry.Key + " / value : " + entry.Value);
//            }

//            //Remove method를 사용하여 키-값 제거
//            hashtb.Remove("banana");
//            foreach (DictionaryEntry entry in hashtb)
//            {
//                Console.WriteLine("key : " + entry.Key + " / value : " + entry.Value);
//            }


//        }

//    }
//}
