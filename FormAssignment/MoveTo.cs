using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FormAssignment
{
    class MoveTo : Shape
    {
        int x , y;

        public MoveTo(Canvas canvas, List<string> param)
        {
            PaintCanvas = canvas;
            Param = param;
            CheckParam();
        }

        public override void CheckParam()
        {
            string[] userParam = Param[0].Split(',');

            if (int.TryParse(userParam[0], out int newX)
                && int.TryParse(userParam[1], out int newY))
            {
                x = newX;
                y = newY;
            }
        }

        public override void Draw()
        {

        }
    }
}
