//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;
//using System.Threading;


//namespace Hello
//{
//    class Process_thread
//    {

//        // 프로세스와 스레드
//        //
//        // 프로세스(Process)
//        // 실행파일의 데이터와 코드가 메모리에 적재되어 동작하는 것
//        // word.exe가 실행파일이라면 이 실행 파일을 실행한 것이 프로세스
//        //
//        // 스레드(Thread)
//        // 스레드는 운영체제가 cpu 시간을 할당하는 기본 단위
//        // 프로세스가 밧줄이라면 스레드는 밧줄을 이루는 실
//        // 멀티 스레드
//        // 장점 : 높은 경제성 / 높은 사용자 응답성 / 용이한 데이터 교환
//        // 단점 : 높은 개발 난이도 / 과다한 스레드는 성능 저하 / 스레드의 문제는 프로세스로 확산

//        // 스레드 시작
//        // System.Threading.Thread : 스레드를 나타내는 클래스
//        // 스레드 기동 절차
//        // 1. Thread 인스턴스 생성(스레드가 실행할 메소드를 생성자 인수로 입력)
//        // 2. Thread.Start() 메소드 호출(스레드 시작)
//        // 3. Thread.Join() 메소드 호출(스레드 종료 대기)
//        static void DoSomething()
//        {
//            for (int i = 0; i < 5; i++)
//            {
//                Console.WriteLine($"DoSomething : {i}");
//            }
//        }
//        // 스레드 멈추기 - Abort
//        // 스레드는 실행중인 메소드가 종료되면 함께 종료되지만, 필요한 경우 Abort() 메소드를 호출하여 강제 종료 가능
//        // Abort() 메소드 호출 시 ThreadAbortedException 발생
//        static void DoSometing_stop()
//        {
//            try
//            {
//                for(int i = 0; i < 10000; i++)
//                {
//                    Console.WriteLine($"DoSometing_stop : {i}");
//                    Thread.Sleep(10);
//                }
//            }
//            catch(ThreadAbortException e)
//            {
//                /**/
//            }
//            finally
//            {
//                /**/
//            }
//        }
//        // 스레드 멈추기 - interrupt
//        // Thread.Interrupt() 메소드는 스레드가 WaitJoinSleep 상태에 진입했을 때
//        // ThreadInterttuptedException 예외를 일으켜 스레드를 중단시킴
//        // 스레드가 블록되어 있을 때 스레드를 중단시키므로 부작용을 최소화할 수 있음
//        static void DoSometing_stopTwo()
//        {
//            try
//            {
//                for (int i = 0; i < 10000; i++)
//                {
//                    Console.WriteLine($"DoSometing_stop : {i}");
//                    Thread.Sleep(10);
//                }
//            }
//            catch (ThreadInterruptedException e)
//            {
//                /**/
//            }
//            finally
//            {
//                /**/
//            }
//        }
//        // 스레드간의 동기화
//        // 멀티스레드 동기화(Synchronization)
//        // 자원(예:변수)을 한 번에 한 스레드가 사용하도록 순서를 맞추는 것
//        // .NET이 제공하는 대표적 동기화 도구
//        // lock 키워드 / Monitor 클래스

//        // lock 키워드
//        // 크리티컬 섹션(Critical Section)
//        // 동시 접근이 불가능하도록 보호된 코드 영역
//        // C#에서는 lock 키워드를 이용하여 생성 가능
//        class Counter
//        {
//            public int count = 0;
//            private readonly object thisLock = new object();
//            public void Increase()
//            {
//                lock (thisLock)
//                {
//                    count = count + 1;
//                }
//            }
//        }

//        // Monitor 클래스
//        // 스레드 동기화를 지원하는 메소드 제공
//        // Monitor.Enter()와 Monitor.Exit()를 이용하면 lock과 같이 크리티컬 섹션 생성 가능
//        class Moni
//        {
//            public int count = 0;
//            private readonly object thisLock = new object();
//            public void Increase()
//            {
//                Monitor.Enter(thisLock);
//                try
//                {
//                    count++;
//                }
//                finally
//                {
//                    Monitor.Exit(thisLock);
//                }
//            }
//        }

//        // System.Threading.Tasks.Task 클래스
//        // Action 대리자를 실행
//        // Start() 메소드 : Action 대리자 비동기 실행
//        // Factory.StartNew() 메소드 : Task 객체 생성 및 Action 대리자 비동기 실행
//        // Wait() 메소드 : Action 대리자 실행 완료 대기
//        class Task
//        {
//            public void TaskTest()
//            {
//                var myTask = Task.Factory.StartNew(() =>
//               {
//                   Thread.Sleep(1000);
//                   Console.WriteLine("Printed asynchronously");
//               });

//                Console.WriteLine("Printed synchronously");
//                myTask.Wait();

//            }
//        }
        

//        static void Main(string[] args)
//        {
//            Thread t1 = new Thread(new ThreadStart(DoSomething));
//            t1.Start();
//            t1.Join();
//            Thread t2 = new Thread(new ThreadStart(DoSometing_stop));
//            t2.Start();
//            t2.Abort();
//            t2.Join();
//            Thread t3 = new Thread(new ThreadStart(DoSometing_stopTwo));
//            t3.Start();
//            t3.Interrupt();
//            t3.Join();
//            Counter obj = new Counter();
//            Thread t4 = new Thread(new ThreadStart(obj.Increase));
//            Thread t5 = new Thread(new ThreadStart(obj.Increase));
//            Thread t6 = new Thread(new ThreadStart(obj.Increase));

//            t4.Start(); t5.Start(); t6.Start();
//            t4.Join(); t5.Join(); t6.Join();
//            Console.WriteLine(obj.count);

//            Moni obj2 = new Moni();
//            Thread t7 = new Thread(new ThreadStart(obj2.Increase));
//            Thread t8 = new Thread(new ThreadStart(obj2.Increase));
//            Thread t9 = new Thread(new ThreadStart(obj2.Increase));

//            t7.Start(); t8.Start(); t9.Start();
//            t7.Join(); t8.Join(); t9.Join();
//            Console.WriteLine(obj2.count);

//            Task obj3 = new Task();
//            obj3.TaskTest();

//        }
//    }
//}
 