using System;

namespace L20230719
{
    class Slime : Monster
    {
        public Slime()
        {
            name = "슬라임";
            Console.WriteLine(name + "이/가 생성 되었다.");
        }

        ~Slime()
        {
            Console.WriteLine(name + "이/가 삭제되었습니다.");
        }
    }
}
