using System;

namespace L20230719
{
    class Monster : Character //base class, parent class
    {
        public Monster() 
        {
            hp = 0;
            gold = 0;
            name = "몬스터";
            Console.WriteLine("몬스터 생성자");
        }

        ~Monster() 
        {
            Console.WriteLine("몬스터 소멸자");
        }

        private int hp = 0;
        public int gold = 0;
        public string name = string.Empty;

        public override void Move()
        {
            Console.WriteLine(name + "이/가 움직인다.");
        }
        public void Attack()
        {
            Console.WriteLine(name + "이/가 공격한다.");
        }
        public void Die()
        {
            Console.WriteLine(name + "이/가 죽었다.");
        }
    }
}
