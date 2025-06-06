import java.util.HashMap;
import java.util.LinkedHashMap;
import java.util.Map;
import java.util.TreeMap;

public class Main {
    public static void main(String[] args) {
        // Create a Map to hold a person's name and their favorite number
        // Note use of Wrapper Class Integer instead of primitive int
        // Map<key-type, value-type>name     = new typeOfMap();
        // Map<String, Integer> peoplesNumbers = new HashMap<>();
        // Map<String, Integer> peoplesNumbers = new TreeMap<>();
        Map<String, Integer> peoplesNumbers = new LinkedHashMap<>();



        // Add some entries to our Map
        // .put(key, value) - Add an entry to the Map
        peoplesNumbers.put("Frank", 42);
        peoplesNumbers.put("Ravyn", 5);
        peoplesNumbers.put("Missy", 22);
        peoplesNumbers.put("Youssef", 7);
        peoplesNumbers.put("Zach", 51);

        // Find an entry in the Map
        // .get(key-value) - retrieve the value associated with the key - null if the key is not in the map
        //                                                                (C# throws an exception)
//        System.out.println("Ravyn's favorite number is " + peoplesNumbers.get("Ravyn"));
//        System.out.println("Missy's favorite number is " + peoplesNumbers.get("Missy"));
//        System.out.println("Frank's favorite number is " + peoplesNumbers.get("Frank"));
//        System.out.println("Youssef's favorite number is " + peoplesNumbers.get("Youssef"));
//        System.out.println("Zach's favorite number is " + peoplesNumbers.get("Zach"));

        // Display all the entries in the Map
        // entrySet() returns a Set of entries from the map
        // Each item in the entrySet is a key-value pair
        // Use setElement.getKey() to retrieve the value of the key
        // Use setElement.getValue() to retrieve the value of the value
        for (Map.Entry<String, Integer> anEntry : peoplesNumbers.entrySet()){
            System.out.print("Name: " + anEntry.getKey() + " Favorite number: " + anEntry.getValue() + "\n");
        }

        //Remove an entry from the map
        peoplesNumbers.remove("Frank");

        for (Map.Entry<String, Integer> anEntry : peoplesNumbers.entrySet()){
            System.out.print("Name: " + anEntry.getKey() + " Favorite number: " + anEntry.getValue() + "\n");
        }

    }
}