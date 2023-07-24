using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace L20230719
{
    class Player : Character
    {
        public Player()
        {
            Console.WriteLine("플레이가 생성 되었다.");
            hp = 0;
            mp = 0;
            gold = 0;
        }

        public Player(int inHp, int inMp, int inGold)
        {
            Console.WriteLine("플레이가 생성 되었다.");
            hp = inHp;
            mp = inMp;
            gold = inGold;
        }

        ~Player()
        {
            Console.WriteLine("플레이가 삭제 되었다.");
        }

        public int hp = 0;
        public int mp = 0;
        public int gold = 0;

        public override void Move()
        {
            DetailMove();
        }
        public void Attack()
        {
            Console.WriteLine("플레이어가 공격한다.");
        }
        public void Die()
        {
            Console.WriteLine("플레이어가 죽었다.");
        }

        protected void DetailMove()
        {
            Console.WriteLine("플레이어가 걷는다.");
        }
    }
}
