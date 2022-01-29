using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task_2._2._1.Common;
using Task_2._2._1.Maps;

namespace Task_2._2._1.Players
{
    public class Mouse : MovableObject
    {
        protected char _health = '♥';
        protected int health;
        protected char _mouse = 'M';
        public Mouse(Point spawnPoint) : base(spawnPoint)
        {
            this.health = 3;
            this.Position = spawnPoint;
        }
        
        public Mouse() 
        {

        }
        public bool IsOver
        {
            get
            {
                if (health > 0)
                {
                    return false;
                }
                else
                {
                    return true;
                }
            }
        }
        public override string ToString()
        {
            return $"Mouse, Positon: { Position }";
        }
        public new void PlayersMove(int direction, Map map)
        {
            isMoving = true;
            //todo meeting with enemy

            if (isMoving)
            {
                this.Position = step;
            }
        }
        public bool stepOnThing(GameObject obstracles)
        {
            bool isMoving = false;
            //todo smth for this case
            return isMoving;
        }

        public bool stepOnEnemy(MovableObject enemy)
        {
            bool isMoving = false;
            //todo
            return isMoving;
        }
    }
}
