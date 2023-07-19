using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L20230719
{
    class Hog
    {
        public Hog()
        {
            Console.WriteLine("멧돼지가 생성 되었다.");
        }

        public int hp = 0;
        public int gold = 0;

        public void Move()
        {
            Console.WriteLine("멧돼지가 움직인다.");
        }
        public void Attack()
        {
            Console.WriteLine("멧돼지가 공격한다.");
        }
        public void Die()
        {
            Console.WriteLine("멧돼지가 죽었다.");
        }
    }
}
