using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StatePatternLab
{
    public class BlueState : State
    {
        public override void handlePush(CPanel c)
        {
            c.setState(new GreenState());
        }

        public override void handlePull(CPanel c)
        {
            c.setState(new RedState());
        }

        public override Color getColor()
        {
            return (Color.Blue); 
        }
    }
}
