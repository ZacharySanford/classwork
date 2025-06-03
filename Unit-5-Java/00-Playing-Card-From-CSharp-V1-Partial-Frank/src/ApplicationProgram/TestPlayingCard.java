package ApplicationProgram;

import PlayingCard.PlayingCard;

public class TestPlayingCard {
    // C#:  Main() is spelled with uppercase M
    //      string may be spelled with lowercase or uppercase S
    //      (uppercase was added in .Net version 6)
    //      Console.WriteLine() to display line to screen

    // Java: main() is spelled with a lowercase m
    //       String is always spelled with uppercase S
    //       (because it is a Class - has data methods)
    //       System.out.println() to display a line to the screen

    // this is exactly how C# defines Main() but lowercase m
    public static void main(String[] args) {

        System.out.println("Hello, World!");

        //Define an Ace of Spades
        //Syntax is just like C#
        // ClassName objectName = new ClassName()
        PlayingCard aceOfSpades = new PlayingCard(PlayingCard.CardValue.Ace, PlayingCard.CardSuit.Spade);

        //Display the PlayingCard
        System.out.println(aceOfSpades);

        // Call the method to flip the card over
        aceOfSpades.flip();

        //Display the PlayingCard
        System.out.println(aceOfSpades);
    } // End of main() method
} // End of TestPlayingCard CLass