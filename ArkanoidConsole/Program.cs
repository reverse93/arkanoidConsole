using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;


namespace ArkanoidConsole
{
    class Program
    {
    
        static void Draw(Player player,Ball ball, Board screen, List<Enemy> enemy)
        {
            screen.ClearBoard();
            foreach (Enemy e in enemy) screen.Add(e);
            screen.Add(ball);
            screen.Add(player);
            screen.DrawAll();
        }

        static void Tick(Player player,Ball ball,  int time)
        {
            ball.Tick(time);
            player.Tick(time);
        }

        static void Main(string[] args)
        {
            Board screen = new Board();
            Player player = new Player(38, 23);
            Enemy enemies = new Enemy(34, 1);
            List<Enemy> enemy = new List<Enemy>();
            Ball ball = new Ball(38,22);
           
            bool end = false;
            int t1 = 3;
            int t2 = 1;
            int time = 0;
          
            enemy.Add(new Enemy(35, 20));
            enemy.Add(new Enemy(36, 10));
            enemy.Add(new Enemy(37, 15));
            Draw(player,ball, screen,enemy);

            while (!end)
            {
                time = (t2 - t1) ;
                Tick(player, ball, time);

                if (Console.KeyAvailable)
                {
                    var key = Console.ReadKey();
                    if (key.Key == ConsoleKey.Escape) end = true;
                }

                Draw(player,ball, screen,enemy);
                Thread.Sleep(500);

            }

            Console.WriteLine("Gra się skończyła.");
            Console.ReadKey();
        }
    }
}
