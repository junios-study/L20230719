using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace L20230719
{
    class Player
    {
        public Player()
        {
            Console.WriteLine("플레이가 생성 되었다.");
            _hp = 0;
            _mp = 0;
            _gold = 0;
        }

        public Player(int inHp, int inMp, int inGold)
        {
            Console.WriteLine("플레이가 생성 되었다.");
            _hp = inHp;
            _mp = inMp;
            _gold = inGold;
        }

        ~Player()
        {
            Console.WriteLine("플레이가 삭제 되었다.");
        }

        public int hp 
        {
            get 
            { 
                return _hp;
            }
            set 
            {
                if (value > 0)
                {
                    _hp = value;
                }
            }
        }

        //property 다 private
        public int mp 
        { 
            get;
            set;
        }

        public int gold
        {
            get;
            set;
        }

        private int _hp = 0;
        private int _mp = 0;
        private int _gold = 0;

        public void Move()
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

        private void DetailMove()
        {
            Console.WriteLine("플레이어가 움직인다.");
        }
    }
}
