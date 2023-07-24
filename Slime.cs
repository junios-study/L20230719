using System;

namespace L20230719
{
    class Slime : Monster //child, derive
    {
        public Slime()
        {
            name = "슬라임";
            Console.WriteLine(name + "이/가 생성 되었다.");
//            hp = 10;
        }

        ~Slime()
        {
            Console.WriteLine(name + "이/가 삭제되었습니다.");
        }
    }
}
