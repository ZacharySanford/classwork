// Every class in Java is part of a package
// First thing you do to create a new class is create a new package
package Pet;

import java.util.Objects;

/*************************************************************************************************
 * This class will represent Pet information for a pet
 *
 * Data: Name of the Pet
 *       Type of Pet
 *       Gender
 *       Weight
 *       Is it spayed of neutered?
 *
 * Behavior (methods):
 *  1. You should always have at least one constructor to the class
 *      (usually you have a default constructor and a constructor that takes arguments
 *      a default ctor (in case Java needs it; Java uses the default ctor behind the scenes if needed)
 *
 *  2. Getters and Setters to allow controlled access to private data members
 *
 *  3. Object method overrides to get the behavior you want from the methods:
 *
 *      toString() - Represent the class data as a String rather than show location@package.Class
 *      equals()   - To determine if two objects of the class are equal based on their content\
 *                          rather than
 *      hashCode() - To generate a hash code based on the content of the object not it's location in memory
 *                   The same data members used in eequals should be used in hashCode() so objects that are
 *                   equal have equal hashCode
 *
 *  4. Additional methods to support the class (e.g. display method)
 *
 *  A class that has data and method in items 1 through 3 is know as a POJO
 ************************************************************************************************/
public class Pet {
    /********************************************************************************************
     * Member Data
     *******************************************************************************************/

    private String petName;
    private String petType;
    private char gender;
    private int petWeight;
    private boolean isSpayed;

    /********************************************************************************************
     * Constructors - initialize objects instantiated for a class
     *******************************************************************************************/

    //Default ctor - define an empty object (we don't know default pet info
    public Pet(){} // ctor that takes no arguments and doesn't do anything

    // Ctor that initializes using arguments passed to the constructor

    public Pet(String petName, String petType, char gender, int petWeight, boolean isSpayed) {
        // Why is this. used in these statements?
        // Because the parameters names are the same as the data member names
        //      this. is used to reference the data member and NOT the parameters
        this.petName = petName;
        this.petType = petType;
        this.gender = gender;
        this.petWeight = petWeight;
        this.isSpayed = isSpayed;
    }

    /********************************************************************************************
     * Standard Getters and Setters - allow controlled access to private data
     *
     * Standard names: getters - getVariableName        setters: setVariableName
     *
     *******************************************************************************************/
    public String getPetName() {
        return petName;
    }

    public void setPetName(String petName) {
        this.petName = petName;
    }

    public String getPetType() {
        return petType;
    }

    public void setPetType(String petType) {
        this.petType = petType;
    }

    public char getGender() {
        return gender;
    }

    public void setGender(char gender) {
        this.gender = gender;
    }

    public int getPetAge() {
        return petWeight;
    }

    public void setPetWeight(int petAge) {
        this.petWeight = petWeight;
    }

    public boolean isSpayed() {
        return isSpayed;
    }

    public void setSpayed(boolean spayed) {
        isSpayed = spayed;
    }



    /********************************************************************************************
     * Object Method overrides
     *
     *      toString() - Represent the class data as a String rather than show location@package.Class
     *      equals()   - To determine if two objects of the class are equal based on their content\
     *                           rather than based on their location in memory
     *      hashCode() - To gererate a
     *******************************************************************************************/

    @Override // Optional - Asks the compiler to check to be sure this is valid override
    public String toString() {
        return "Pet{" +
                "petName='" + petName + '\'' +
                ", petType='" + petType + '\'' +
                ", gender=" + gender +
                ", petAge=" + petWeight +
                ", isSpayed=" + isSpayed +
                '}';
    }

    @Override
    // equals receives a generic Object - NOT an object of the class
    // We have to check or cast the generic object to an object of the class
    public boolean equals(Object o) {
        // an object called pet is instantiated as part of the if
        // (o instance of Pet pet) - the Pet pet instantiates a Pet object called pet
        if (!(o instanceof Pet pet)) return false;
        return gender == pet.gender
                && Double.compare(petWeight, pet.petWeight) == 0
                && isSpayed == pet.isSpayed
                && Objects.equals(petName, pet.petName)
                && Objects.equals(petType, pet.petType);
    }

    @Override
    public int hashCode() {
        return Objects.hash(petName, petType, gender, petWeight, isSpayed);
    }

    /*****************************************************************************************
     * Additional methods to support the class
     */
    public void displayPet(){
        System.out.println(this); // Display the object used to invoke the method (implied use of toString()
    }
} // End of Pet Class

