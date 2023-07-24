using System;

namespace L20230719
{
    class Program
    {
        static void Main(string[] args)
        {
            //숫자
            Random rand = new Random();

            //초기화
            int goblinCount = rand.Next(1, 4);
            Goblin[] goblins = new Goblin[goblinCount];
            for(int i = 0; i < goblinCount; i++) 
            {
                goblins[i] = new Goblin();
            }

            int hogCount = rand.Next(1, 4);
            Hog[] hogs = new Hog[hogCount];
            for (int i = 0; i < hogCount; i++)
            {
                hogs[i] = new Hog();
            }

            int slimeCount = rand.Next(1, 4);
            Slime[] slimes = new Slime[slimeCount];
            for (int i = 0; i < slimeCount; i++)
            {
                slimes[i] = new Slime();
            }

            Player player = new Player();

            //이동
            for (int i = 0; i < goblinCount; i++)
            {
                goblins[i].Move();
            }
            for (int i = 0; i < hogCount; i++)
            {
                hogs[i].Move();
            }
            for (int i = 0; i < slimeCount; i++)
            {
                slimes[i].Move();
            }

            player.Move();


        }
    }
}
