using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RandomLabelMove
{
    class bikes
    {
        //string variable for getting the name of the player
        public string Name;
        //bet object of the bet variable
        public Bet place;
        //integer variable of the class for getting the amount
        public int amt;
        public int k;
        public RadioButton Rb_Button;
        public Label Labels;
      
        //this method is used to update the label is that which one player has set the bet on which bike and how much amount
        public void UpdateLabels()
        {
            //if any player set the bet then it will call the another method to print his name and bike number also
            Rb_Button.Text = Name + " has " + amt + " $";
            
            Labels.Text = Name+" hasn't not yet placed a bet";
            if (k == 1)
            {
                //if the user has not set any bet then it will display no one has set the bet
                Labels.Text = Name + " hasn't not yet placed a bet";
            }
        }
        //another boolean method that is used for set the bet so thus get the amount using argument
        public bool Bet_palced(int amt_bet, int winerbike)
        {
            place = new Bet() { bucks = amt_bet, bike = winerbike, Bettor = this };
            place.bucks = amt_bet;
            if (amt_bet > amt)
            {
                MessageBox.Show($@"you dont have enough money $");
                return false;
            }
            if (amt >= 1)
            {
                Labels.Text = place.lables_lb();
                return true;
            }
            else
            {
                return false;
            }
        }
        //it is used to remove the bet after completion of race
        public void RemoveBet()
        {
            //pass the value to the numeric object 
            place.bucks = 0;
        }
        //this method is used to collection of the player if he is winner then it will increment in his amount
        public void winer_bik(int Winner)
        {
            amt += place.winner_money(Winner);
            RemoveBet();
            UpdateLabels();
        }
    }
}
