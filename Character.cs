using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L20230719
{
    class Character : GameObject
    {
        public Character() 
        {
            Console.WriteLine("캐릭터 생성자");
        }

        ~Character() 
        {
            Console.WriteLine("캐릭터 소멸자");
        }

        public override void Move()
        {

        }
    }
}
