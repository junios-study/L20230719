using System;
using System.Collections;
using System.Collections.Generic;

namespace L20230719
{
    class Floor : GameObject
    {
        public Floor() { }
        ~Floor() { }
    }

    class Program
    {
        static void Main(string[] args)
        {
            //숫자
            Random rand = new Random();

            List<GameObject> characters = new List<GameObject>();

            

            //초기화
            //int goblinCount = rand.Next(1, 4);
            //for(int i = 0; i < goblinCount; i++) 
            //{
            //    characters.Add(new Goblin());
            //}

            //int hogCount = rand.Next(1, 4);
            //for (int i = 0; i < hogCount; i++)
            //{
            //    characters.Add(new Hog());
            //}

            //int slimeCount = rand.Next(1, 4);
            //for (int i = 0; i < slimeCount; i++)
            //{
            //    characters.Add(new Slime());
            //}

            //characters.Add(new Player());

            //이동
            //for (int i = 0; i < characters.Count; i++)
            //{
            //    characters[i].Move();
            //}

            characters.Add(new Slime());
            characters.Add(new Floor());

            characters[0].Move();


        }
    }
}
