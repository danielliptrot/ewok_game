using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ewok_shoot
{
    public partial class Form1 : Form
    {
        //create variables to control text scrolling
       // bool reachTop = false;

        public Form1()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            //while (reachTop == false)
            //{
                //sets labels initial position
                label1.Top -= 5;
                //if the position of the label is less than Height(as it's set to minus five it is), 
                    if (label1.Top <= -Height)
                    {
                        //sets the label to height
                        label1.Top = Height;
                    }
                   // reachTop = true;

            //}//close while
        }
    }
}
