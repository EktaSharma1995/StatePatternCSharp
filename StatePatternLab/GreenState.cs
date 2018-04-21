using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using System.Threading.Tasks;

namespace StatePatternLab
{
    class GreenState : State
    {
        public override void handlePush(CPanel c)
        {
            c.setState(new BlackState());
        }

        public override void handlePull(CPanel c)
        {
            c.setState(new BlueState());
        }

        public override Color getColor()
        {
            return (Color.Green);
        }
    }
}
