using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArkanoidConsole
{
    class Ball : GameObject
    {
        private int speed=1;
        public Ball(int x,int y)
        {
            SetPosition(x, y);
            LookCharacter('a');
        }

        public override void Tick(int time)
        {
            if ( positionY < 10 )
            {
                speed = speed * (-1);
                this.SetPosition(positionX, (positionY + time *speed));

            }
            
            this.SetPosition(positionX + time, positionY + time );


        }
    }
}
