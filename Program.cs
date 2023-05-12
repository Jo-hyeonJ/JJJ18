namespace JJJ18
{
    internal class Program
    {
        // 지난 수업 복습
        #region
        /*static void Func() // 문 형식
        {
            Console.WriteLine("HELLO 1");
        }
        static void Func2() => Console.WriteLine("HELLO 2"); // 식 형식
        static int Count() // 반환형이 있는 함수
        {
            return 0;
        }
        static int Count2() => 10; // 대입으로 끝
        static void Main(string[] args)
        {
            // 반환형이 없는 기본형 델리게이트
            Action onAction = Func;
            onAction += Func2;
            onAction += () =>
            {
                Console.WriteLine("Hello 3");
            };
            onAction += () => Console.WriteLine("Hello 4");

            onAction();

            // 반환형이 있는 기본형 델리게이트
            Func<int> onFunc = Count2;
            onFunc = () => 200;
            Console.WriteLine("반환 값 : " + onFunc());
        }*/
        #endregion

        // Linq (퀴리문)
        // = 데이터를 찾아내는 방법
        enum JOB
        {
            Warrior,
            Archor,
            Thief,
            Wizard
        }
        class Player
        {
            public string name;
            public int level;
            public JOB job;

            public int str;
            public int dex;
            public int lnt;
            public int lux;
            public Player(string name, int level, JOB job)
            {
                this.name = name;
                this.level = level;
                this.job = job;
                
                // 직업별로 레벨업시 증가하는 스텟

                switch(job)
                {
                    case JOB.Warrior:
                        str = 5 * level;
                        dex = 3 * level;
                        lnt = level;
                        lux = level;
                        break;
                    case JOB.Archor:
                        lnt = level;
                        dex = 5 * level;
                        str = 3 * level;
                        lux = level;
                        break;
                    case JOB.Thief:
                        str = level;
                        lux = 5 * level;
                        dex = 3 * level;
                        lnt = level;
                        break;
                    case JOB.Wizard:
                        str = level;
                        lnt = 5 * level;
                        dex = 3 * level;
                        lux = level;
                        break;


                }

            }

            public override string ToString()
            { 
            return $"name : {name}, lv.{level}, 직업 : {job}";
            }
        }
        static void Main(string[] args)
        {
            // 1,2교시
            #region
            /*List<Player> playerList = new List<Player>();

            playerList.Add(new Player("전사A", 10, JOB.Warrior));
            playerList.Add(new Player("전사B", 30, JOB.Warrior));
            playerList.Add(new Player("전사C", 99, JOB.Warrior));
            playerList.Add(new Player("궁수A", 15, JOB.Archor));
            playerList.Add(new Player("궁수B", 45, JOB.Archor));
            playerList.Add(new Player("돚1", 30, JOB.Thief));
            playerList.Add(new Player("돚2", 32, JOB.Thief));
            playerList.Add(new Player("법1", 23, JOB.Wizard));
            playerList.Add(new Player("법2", 44, JOB.Wizard));
            playerList.Add(new Player("법3", 55, JOB.Wizard));
            

            List<Player> List30 = new List<Player>();
            // Q. 레벨이 30이상인 플레이어 리스트를 생성해보자.
            *//*
            foreach (Player player in playerList)
            {
                if (player.level >= 30 && player.job == JOB.Warrior)
                {
                    List30.Add(player);
                }
            }
            foreach (Player player in List30)
            {
                Console.WriteLine(player);
            }
            *//*

            // from-in : foreach와 동일하게 컬렉션에서 값을 하나씩 가져오는 키워드
            // where : 조건식에 맞는 데이터만 선별한다.
            // select : 결과적으로 어떠한 데이터로 만들겠는가
            var search2 = from player in playerList
                         where player.level >= 30
                         where player.job == JOB.Warrior
                         select player;

            foreach (Player player in search2)
            {
                Console.WriteLine($"레벨 30이상의 전사 {player}");
            }

            // Linq문을 이용해서 힘이 200이상이고 운이 50이상인 캐릭터를 뽑아서 출력하자

            var search = from player in playerList
                         where player.str >= 200
                         where player.lux >= 50
                         select player;

            // Linq에 람다식을 활용하는 방법
            // 델리게이트 형태를 띄고 있는 Where. 명시 되어 있는 자료형과 반환 값(bool)을 따른다면 어떤 조건이든 수용한다.
            // Where은 자신이 가지고 있는 데이터 열거자를 통해 값을 순회하고 매개변수로 받은 함수를 통해 조건을 만족하는 데이터를 찾는다.
            var search3 = playerList.Where((Player player) => { return player.str >= 200 &&  player.lux >= 50; });
            var search4 = playerList.Where((player) => player.str >= 200 &&  player.lux >= 50).ToArray();
            // ↘ .where 선처리 후에 그것으로 산출 되는 값(여기선 열거자)에 .ToArray()를 적용한 것 [이중으로 멤버 함수를 사용하는 방법]
            
            if (search.Count() <= 0)
            {
            Console.WriteLine("만족하는 캐릭터가 없습니다.");
            }
            else
            {
               foreach (Player player in search)
               {
                Console.WriteLine($"힘 200이상 운 50 이상의 플레이어 {player}");
               }
            }
*/
            #endregion

            // 교집합, 합집합, 차집합, 중복제거

            int[] array1 = new int[] { 1, 2, 3, 4, 5, 6 };
            int[] array2 = new int[] { 3, 4, 5, 6, 7, 8 };

            // Q. 배열 1과 배열2에 모두 포함 되는 값을 가진 배열을 만들어보자.

            List<int> list = new List<int>();
            foreach (int i in array1)
            {
                foreach (int e in array2)
                {
                    if (i == e)
                    {
                        list.Add(e);
                        break;
                    }
                }
            
            }
            int[] array3 = new int[list.Count];
            for (int i = 0; i < array3.Length; i++)
            {
                array3[i] = list[i];
            }
            
            Console.WriteLine($"두 배열이 가진 공통 된 변수는 {string.Join(",", array3)} 입니다.");

            // Contains : 포함하고 있는가
            /*
                        for (int i=0; i < array1.Length; i++)
                        {
                            int num = array1[i];
                            if(array2.Contains(num))
                                list.Add((int)num);
                        }

                        int[] result = list.ToArray(); // 리스트를 배열로 바꾸기
            */
            int[] result;
            result = array1.Where(num => array2.Contains(num)).ToArray();
            

            // 교집합(함수) Intersect
            result = array1.Intersect(array2).ToArray();
            foreach (int i in result) { Console.WriteLine(i); }


            // 합집합(함수) Union
            // 중복 값은 알아서 제거 된다.
            result = array1.Union(array2).ToArray();
            foreach (int i in result) { Console.WriteLine(i); }

            // 차집합(함수) Except
            result = array1.Except(array2).ToArray();
            foreach (int i in result) { Console.WriteLine(i); }

            // 중복제거(함수) Distinct
            array1 = array1.Distinct().ToArray();

        }

    }
}