using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RandomLabelMove
{
    class racers
    {
        //string variable for getting
        public PictureBox piture;
        public Random Randomizer;
        public int StartingPoint;


        public bool Move()
        {
            //calling the next method of the random class and pass the value to move the variable from 4
            piture.Left += Randomizer.Next(4);
            //calling the method of move picture box while passing the argumentb to the method
            if(piture.Left >= piture.Parent.Width - piture.Width)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        //this user define the method that is used for set all the pictures and all the starting position. this method is void method it will not return any value
        public void Startbike()
        {
            piture.Left = StartingPoint;
        }
    }
}
