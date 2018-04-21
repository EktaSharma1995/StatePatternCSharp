using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using System.Threading.Tasks;

namespace StatePatternLab
{
    abstract public class State
    {
        public abstract void handlePush(CPanel c);
        public abstract void handlePull(CPanel c);
        public abstract Color getColor();

    }
}
