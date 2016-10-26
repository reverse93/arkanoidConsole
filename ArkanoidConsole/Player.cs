using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ArkanoidConsole
{
    class Player : GameObject
    {
        private string playerSymbol;
        public Player( int x , int y)
        {
            playerSymbol = "xxxxxxxx";
            SetPosition(x, y);
            
        }

        public override void Draw(char[] tab)
        {
            for (int i = 0; i < playerSymbol.Length; i++)
            {
                tab[(positionX + i) + positionY * 80] = playerSymbol[i];
            }
        }

        public override void SetPosition(int x, int y)
        {
            try
            {
                if (x >= 0 && (x + playerSymbol.Length - 1) < 79 && y >= 0 && y <= 23)
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
            if(Console.KeyAvailable)
            {
                var key = Console.ReadKey();
                if (key.KeyChar == 'a')
                {
                    this.SetPosition(positionX + 1, positionY);
                }
                if (key.KeyChar == 'd')
                {
                    this.SetPosition(positionX - 1, positionY);
                }
            }
            while (Console.KeyAvailable) Console.ReadKey();
        }

    }
}
