using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L20230719
{
    class Slime
    {
        public Slime()
        {
            Console.WriteLine("슬라임이 생성 되었다.");
        }

        public int hp = 0;
        public int gold = 0;

        public void Move()
        {
            Console.WriteLine("슬라임이 움직인다.");
        }
        public void Attack()
        {
            Console.WriteLine("슬라임이 공격한다.");
        }
        public void Die()
        {
            Console.WriteLine("슬라임이 죽었다.");
        }
    }
}
