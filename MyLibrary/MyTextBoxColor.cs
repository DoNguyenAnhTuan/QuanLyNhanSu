using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;

namespace MyLibrary
{
    public class MyTextBoxColor:TextBox
    {
        public Color backGroudEnter = Color.Pink;
        public Color backGroudLeave = Color.White;
        protected override void OnEnter(EventArgs e)
        {
            this.BackColor = Color.Aqua;
            base.OnEnter(e);
        }
        protected override void OnLeave(EventArgs e)
        {
            this.BackColor = Color.Orange;
            base.OnLeave(e);
        }
    }
    
}
