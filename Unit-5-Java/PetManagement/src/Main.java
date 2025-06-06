import Pet.Pet;

import java.util.Scanner;

//TIP To <b>Run</b> code, press <shortcut actionId="Run"/> or
// click the <icon src="AllIcons.Actions.Execute"/> icon in the gutter.
public class Main {
    public static void main(String[] args) {

        System.out.println("Welcome to Pet Management");

        // Instantiate a pet
        Pet cat1 = new Pet("James", "Cat", 'M', 30, true);

        cat1.displayPet();

        // Instantiate a Pet from User Input - Java uses Scanner for keyboard input
        // Scanner is a class to scan data and break it into variables\
        // System.in is a Java defined object to represent the keyboard
        Scanner theKeyboard = new Scanner(System.in); // Create a Scanner for the keyboard

        System.out.println("\nWhat is the name of your pet?");
        String thePetName = theKeyboard.nextLine(); // nextLine() gets a line from the keyboard

        System.out.println("\nWhat is the type of your pet?");
        String thePetType = theKeyboard.nextLine(); // nextLine() gets a line from the keyboard

        System.out.println("\nWhat is the gender of your pet?");
        String thePetGender = theKeyboard.nextLine(); // nextLine() gets a line from the keyboard

        System.out.println("\nWhat is the weight of your pet?");
        String thePetWeight = theKeyboard.nextLine(); // nextLine() gets a line from the keyboard

        System.out.println("\nIs your pet spayed?");
        String isThePetSpayed = theKeyboard.nextLine(); // nextLine() gets a line from the keyboard

        // Instantiate a pet from user input
        char petGender = thePetGender.charAt(0);
        int petWeight = Integer.parseInt(thePetWeight);
        boolean petSpayed = false;
        if (isThePetSpayed.equals("Y")){
            petSpayed = true;
        }
        Pet pet1 = new Pet(thePetName, thePetType, petGender, petWeight, petSpayed);

        pet1.displayPet();
    } // End of main()
}// End of Main() Class