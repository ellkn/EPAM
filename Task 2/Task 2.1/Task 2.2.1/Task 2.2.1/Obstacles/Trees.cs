using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task_2._2._1.Common;

namespace Task_2._2._1.Obstacles
{
    public class Trees : GameObject
    {
        private char _tree;
        public Trees (Point point)
        {
            _tree = 'Y';
            this.Position = point;
        }
    }
}
