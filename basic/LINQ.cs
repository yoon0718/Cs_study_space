//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace Hello
//{
//    class LINQ
//    {
//        // LINQ( Lanaguage INtegrated Query)
//        // c# 언어에 동합된 데이터 질의 기능
//        // sql이랑 비슷한 듯
//        // 프로그래밍에서 많은 부분을 차지하는 데이터 작업의 효율을 크게 향상
//        // 데이터 질의란 데이터 집합에서 원하는 데이터를 찾는 작업

        

//        class Human
//        {
//            public string Name { get; set; }
//            public int Height { get; set; }
//        }

//        class Team
//        {
//            public string Name { get; set; }
//            public string TeamName { get; set; }
//        }
//        static void Main()
//        {
//            // from 절 
//            // from < 범위 변수 > in < 데이터 원본 >

//            // where 절
//            // 찾고자 하는 데이터를 필터
//            // 범위 변수가 충족해야 하는 조건을 매개변수로 입력

//            // order by 절
//            // 필터링된 데이터를 정렬
//            // ascending(오름차순) / descending(내림차순)
//            // 아무것도 선택하지 않으면 오름차순 기본 적용

//            // select 절
//            // 최종 결과를 추출하는 쿼리식의 마침표 같은 존재
//            // LINQ질의 결과인 IEnumerable<T>객체의 매개변수 T는 select 문에 의해 결정

//            // group by 절
//            // 특정 기준으로 데이터 분류
//            int[] numbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
//            var result = from n in numbers
//                         where n % 2 == 0
//                         orderby n
//                         select n;

//            foreach (int n in result)
//            {
//                Console.WriteLine($"짝수 : {n}");
//            }

//            List<Human> profiles = new List<Human>()
//            {
//                new Human() {Name="윤여록", Height=174 },
//                new Human() {Name="김태영", Height=175 },
//                new Human() {Name="임정혁", Height=180 },
//                new Human() {Name="김승원", Height=135 },
//                new Human() {Name="신서연", Height=170 },
//            };

//            var listProfile = from profile in profiles
//                              group profile by profile.Height < 175 into g
//                              select new { GroupKey = g.Key, Profiles = g };

//            foreach (var v in listProfile)
//            {
//                Console.WriteLine($"{v.GroupKey} / {v.GroupKey}");
//            }

//            // 조인 - JOIN
//            // 두 데이터 원본을 연결하는 연산
//            // 각 데이터 원본에서 특정 필드가 일치하는 데이터끼리 연결
//            // 내부 조인 : 일종의 교집합, 두 데이터 원본 사이에서 일치하는 데이터만 연결하여 반환
//            // 외부 조인 : 한쪽 데이터 원본을 기준으로 삼은 상태에서 다른 데이터 원본과 결합하여 반환
//            List<Team> schoolTeam = new List<Team>()
//            {
//                new Team() {Name="윤여록", TeamName="ㅇ" },
//                new Team() {Name="윤우루사", TeamName="ㄴ" },
//                new Team() {Name="밤양갱", TeamName="ㄹ" },
//                new Team() {Name="신서연", TeamName="ㅇ" },
//                new Team() {Name="김태영", TeamName="ㅇ" }
//            };

//            var a = from profile in profiles
//                    join product in schoolTeam
//                    on profile.Name equals product.Name
//                    select new { Name = profile.Name, Team = product.TeamName, Height = profile.Height };
//            foreach (var b in a)
//            {
//                Console.WriteLine($"{b.Name} / {b.Team} / {b.Height}");
//            }

//            // 외부 조인
//            // join 절을 이용해서 조인을 수행 후 그 결과를 임시 컬렉션에 저장
//            // DefaultIfEmpty 연산을 통해 임시 컬렉션의 비어 있는 조인 결과에 빈 값 삽입
//            // DefaultIfEmpty 연산을 거친 임시 컬렉션에서 다시 form 절을 통해 범위 변수 추출
//            // 범위 변수와 기준 데이터 원본에서 뽑아낸 범위 변수를 이용해서 최종 결과 추출

//            var secondProfile = from profile in profiles
//                                join product in schoolTeam
//                                on profile.Name equals product.Name into ps
//                                from sub_product in ps.DefaultIfEmpty(new Team() { TeamName = "그런거 없음" })
//                                select new
//                                {
//                                    Name = profile.Name,
//                                    Team = sub_product.TeamName,
//                                    Height = profile.Height
//                                };
//            foreach (var c in secondProfile)
//            {
//                Console.WriteLine($"{c.Name} / {c.Team} / {c.Height}");
//            }

//        }

//     }
//}

