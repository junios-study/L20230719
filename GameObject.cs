using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L20230719
{
    class GameObject
    {
        public GameObject() 
        {
            Console.WriteLine("GameObejct 생성자");
        }

        ~GameObject() 
        {
            Console.WriteLine("GameObejct 소멸자");
        }

        public virtual void Move()
        {

        }
    }
}
