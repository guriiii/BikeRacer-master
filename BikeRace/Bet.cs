using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RandomLabelMove
{
    class Bet
    {
///  //global variable of class that are used to varify the winner 
        public int bucks;
        public int bike;
        public bikes k;
        public bikes Bettor;
        //constructor method of the class so thus the local value can be pass to global variable
        public int winner_money(int winner)
        {
            if (bike == winner)
            {
                return bucks;
            }
            else
            {
                return -bucks;
            }
        }
        //lables is another method that is used to verify the amount after winning or loosing the bet
        public string lables_lb()
        {
            
            if (bucks > 0)
            {
                return Bettor.Name + " Bets " + bucks + " on " + "bike #" + bike;
            }
            
           
            else
            {

                return Bettor.Name + " hasn't noy yet placed a bet";
            }

        }
        
       
    }
}
