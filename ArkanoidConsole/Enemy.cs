using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArkanoidConsole
{
    class Enemy : GameObject
    {
        private int speed = 1;
        public string enemySymbol;

        public Enemy(int x, int y)
        {
           
            //speed = 1; 
            enemySymbol="ooooooo";
            SetPosition(x, y);

        }


        public override void Draw(char[] tab)
        {
            for (int i = 0; i < enemySymbol.Length; i++)
            {
                tab[(positionX + i) + positionY * 80] = enemySymbol[i];
            }
        }

        public override void SetPosition(int x, int y)
        {
            try
            {
                if (x >= 0 && (x + enemySymbol.Length - 1) < 79 && y >= 0 && y <= 23)
                {
                    this.positionX = x;
                    this.positionY = y;
                }
                else
                {
                    throw new Exception("Obiekt poza obszarem");
                }

            }
            catch (Exception ex)
            {
                Console.WriteLine("Obiekt poza obszarem");

            }
        }
        public override void Tick(int time)
        {
            Move(time);
        }
        private void Move(int time)
        {
            SetPosition(positionX, positionY + time * speed);
        }

        public static implicit operator List<object>(Enemy v)
        {
            throw new NotImplementedException();
        }
    }
}
