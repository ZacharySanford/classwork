package ApplicationProgram;

import CardDeck.CardDeck;
import PlayingCard.PlayingCard;

import javax.smartcardio.Card;

public class TestCardDeck {
//
    public static void main(String[] args) {

        System.out.println("Welcome to my Second Java program!");

        //Instantiate a CardDeck
        CardDeck aCardDeck = new CardDeck();

        //Display all the cards in a deck
        aCardDeck.showDeck();

        System.out.println("\n--- Removing Jokers ---");
        aCardDeck.removeJokers();
        aCardDeck.showDeck();

        aCardDeck.shuffleDeck();

        PlayingCard aCard = aCardDeck.dealCard();
        aCard.showCard();

        CardDeck discardDeck = new CardDeck();
        



    } // End of main() method
} // End of TestPlayingCard CLass