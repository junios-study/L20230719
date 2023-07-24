using System;
using System.Collections;
using System.Collections.Generic;

namespace L20230719
{
    class Program
    {
        static void Main(string[] args)
        {
            Object temp = new int();

            //숫자
            Random rand = new Random();

            List<Object> monsters = new List<Object>();

            //초기화
            int goblinCount = rand.Next(1, 4);
            for(int i = 0; i < goblinCount; i++) 
            {
                monsters.Add(new Goblin());
            }

            int hogCount = rand.Next(1, 4);
            for (int i = 0; i < hogCount; i++)
            {
                monsters.Add(new Hog());
            }

            int slimeCount = rand.Next(1, 4);
            for (int i = 0; i < slimeCount; i++)
            {
                monsters.Add(new Slime());
            }

            Player player = new Player();

            //이동
            for (int i = 0; i < monsters.Count; i++)
            {
                
                (monsters[i] as Monster).Move();
            }

            player.Move();


        }
    }
}
