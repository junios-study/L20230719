﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L20230719
{
    class Hog : Monster
    {
        public Hog()
        {
            name = "멧돼지";
            Console.WriteLine(name + "이/가 생성 되었다.");
        }

        ~Hog()
        {
            Console.WriteLine(name + "이/가 삭제되었습니다.");
        }
    }
}
