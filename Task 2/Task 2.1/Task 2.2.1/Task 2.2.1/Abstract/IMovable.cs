using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task_2._2._1.Common;
using Task_2._2._1.Maps;

namespace Task_2._2._1.Abstract
{
    public interface IMovable
    {
        void PlayersMove(int direction, Map map);
        void EnemyMove();
    }
}
