//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace Hello
//{
//    public class Indexers
//    {
//        // 인덱스를 이용해서 객체 내의 데이터에 접근하게 해주는 프로퍼티
//        private int[] arr;

//        public void List()
//        {
//            arr = new int[100];
//        }

//        // 인덱서 선언
//        public int this[int i]
//        {
//            get
//            {
//                // 인덱스 범위 확인
//                if(i < 0 || i >= 100)
//                {
//                    throw new IndexOutOfRangeException();
//                }
//                return arr[i];
//            }
//            set
//            {
//                // 인덱스 범위 확인
//                if(i < 0 || i >= 100)
//                {
//                    throw new IndexOutOfRangeException();
//                }
//                arr[i] = value;
//            }
//        }
//    }
//    class indexer
//    {
        
//        static void Main(string[] args)
//        {
//            Indexers ints = new Indexers();
//            // 인덱서 활용
//            ints[0] = 1;
//            ints[1] = 2;
//            ints[2] = 3;
//            Console.WriteLine(ints[0]);
//            Console.WriteLine(ints[1]);
//            Console.WriteLine(ints[2]);
//        }
//    }
//}
