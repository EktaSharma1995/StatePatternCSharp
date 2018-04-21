using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StatePatternLab
{
    public class CPanel : Panel
    {
        private State state = null;

        public CPanel() : base()
        {
            state = new RedState();
            this.BackColor = state.getColor();
        }

        public CPanel(State state) : base()
        {
            this.state = state;
            this.BackColor = state.getColor();
        }

        public State getState()
        {
            return state;
        }

        public void setState(State state)
        {
            this.state = state;
        }

        public void push()
        {
            state.handlePush(this);
            this.BackColor = state.getColor();
        }

        public void pull()
        {
            state.handlePull(this);
            this.BackColor = state.getColor();
        }
    }
}
