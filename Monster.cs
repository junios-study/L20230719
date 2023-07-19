using System;

namespace L20230719
{
    class Monster
    {
        public Monster() 
        {
            hp = 0;
            gold = 0;
            name = "몬스터";
        }

        ~Monster() 
        {
            Console.WriteLine(name + "이/가 삭제되었습니다.");
        }

        public int hp = 0;
        public int gold = 0;
        public string name = string.Empty;

        public void Move()
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
