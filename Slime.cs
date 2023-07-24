using System;

namespace L20230719
{
    class Slime : Monster //child, derive
    {
        public Slime()
        {
            name = "슬라임";
            Console.WriteLine(name + " 생성자");
//            hp = 10;
        }

        ~Slime()
        {
            Console.WriteLine("슬라임 소멸자");
        }

        public override void Move()
        {
            Console.WriteLine(name + "이 미끄러진다.");
        }
    }
}
