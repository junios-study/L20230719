using System;

namespace L20230719
{
    class Goblin : Monster
    {
        public Goblin()
        {
            name = "고블린";
            Console.WriteLine(name + "이/가 생성 되었다.");
        }

        ~Goblin()
        {
            Console.WriteLine(name + "이/가 삭제되었습니다.");
        }
    }
}
