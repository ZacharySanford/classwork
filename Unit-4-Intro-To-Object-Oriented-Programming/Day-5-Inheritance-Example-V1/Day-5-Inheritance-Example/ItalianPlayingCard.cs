using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Day_5_Inheritance_Example;

namespace Day_5_Inheritance_Example;

//This is a subclass of a PlayingCard
public class ItalianPlayingCard : PlayingCard
{
    // Define a default color that calls the base class ctor
    public ItalianPlayingCard() : base(0, "Joker", "Black") {}

    // Define a 2-arg ctor for value and suit
    public ItalianPlayingCard(int theValue, string theSuit, string theColor = "Black") : base(theValue, theSuit, theColor) { }
    

}
