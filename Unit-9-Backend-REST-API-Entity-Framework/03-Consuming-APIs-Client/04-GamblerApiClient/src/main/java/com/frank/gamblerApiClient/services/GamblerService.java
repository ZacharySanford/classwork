package com.frank.gamblerApiClient.services;

import org.springframework.http.HttpEntity;
import org.springframework.http.HttpHeaders;
import org.springframework.http.MediaType;
import org.springframework.web.client.ResourceAccessException;
import org.springframework.web.client.RestClientResponseException;
import org.springframework.web.client.RestTemplate;

import com.frank.gamblerApiClient.models.*;

public class GamblerService {

  // Usually the starting part of the URL for API is stored as a constant
  // Other parts of the URL are added as needed
  private final String BASE_URL; //Reference to the starting part of all URLs (usually server identifiers)
  private final RestTemplate restTemplate = new RestTemplate();
    // RestTemplate is a Spring Framework class for performing REST API calls.
    //
    // RestTemplate contains methods for making HTTP requests
    // and collect all exceptions that might happen into only two

    // Define a reference to the RestTemplate

  public GamblerService() {
    BASE_URL = "http://localhost:8081/";
  }
  // Assign the API URL base string to the BASE_URL


  /**
   * Retrieve all Gamblers in the data source
   * @return List<Gambler>
   */
  public Gambler[] getAllGamblers() {
      // Use the getForObject RestTemplate method to execute a GET HTTP request to our API server
      //
      // It's called get ForObject() because it returns an Object not JSON
      // You don't have to convert the JSON that comes back into an object.
      //
      // RestTemplate methods return either individual objects, array, objects, or nothing.
      //
      // RestTemplate may be used in any programming language
      // Collection class structures like List, ArrayList, Map, Dictionary, Stack, Queue, Set et al.
      // may be implemented differently in each programming language
      //
      // arrays are the same in all programming languages
      //
      // RestTemplate doesn't want to know how to create a Collection object of every programming language
      // so it returns the most common data structure for all programming languages (array)
      Gambler[] theGamblers = null;
      try {
          //                       getForObject(URL-for-the-API-call, What t
        theGamblers = restTemplate.getForObject(BASE_URL + "gamblers", Gambler[].class);
      } catch (RestClientResponseException expceptionObj) {
        // handles exceptions thrown by rest template and contains status codes
        // Display the status code and any message related to the error
        System.out.println(expceptionObj.getRawStatusCode() + " : " + expceptionObj.getStatusText());
      } catch (ResourceAccessException exceptionObj) {
        // i/o error, ex: the server isn't running
        System.out.println(exceptionObj.getMessage());
      }
      return theGamblers;
  }

  /**
   * Retrieve a Gambler by id in the data source
   * @return Gambler
   */
  public Gambler getAGambler(int id) {
    Gambler theGambler = null;
    try {
      theGambler = restTemplate.getForObject(BASE_URL + "gamblers/"+id, Gambler.class);
    } catch (RestClientResponseException expceptionObj) {
      // handles exceptions thrown by rest template and contains status codes
      System.out.println(expceptionObj.getRawStatusCode() + " : " + expceptionObj.getStatusText());
    } catch (ResourceAccessException exceptionObj) {
      // i/o error, ex: the server isn't running
      System.out.println(exceptionObj.getMessage());
    }
    return theGambler;
  }

    /**
     * Add the Gambler given to the data source
     * @return Gambler
     */
    public Gambler addAGambler(Gambler gamblerToAdd) {

        if (gamblerToAdd == null) {
            return null;
        }

        Gambler theAddedGambler = null;

        HttpHeaders headers = new HttpHeaders();
        headers.setContentType(MediaType.APPLICATION_JSON);
        HttpEntity<Gambler> entity = new HttpEntity<>(gamblerToAdd, headers);

        try {
            theAddedGambler = restTemplate.postForObject(BASE_URL + "gamblers", entity, Gambler.class);
        } catch (RestClientResponseException expceptionObj) {
            // handles exceptions thrown by rest template and contains status codes
            System.out.println(expceptionObj.getRawStatusCode() + " : " + expceptionObj.getStatusText());
        } catch (ResourceAccessException exceptionObj) {
            // i/o error, ex: the server isn't running
            System.out.println(exceptionObj.getMessage());
        }
        return theAddedGambler;
    }

    /**
     * Update the Gambler given to the data source
     * @return Gambler
     */
    public void updateAGambler(Gambler gamblerToUpdate) {

        if (gamblerToUpdate == null) {
            return;
        }

        Gambler theUpdatedGambler = null;

        HttpHeaders headers = new HttpHeaders();
        headers.setContentType(MediaType.APPLICATION_JSON);
        HttpEntity<Gambler> entity = new HttpEntity<>(gamblerToUpdate, headers);

        try {
            restTemplate.put(BASE_URL + "gamblers", entity, Gambler.class);
       } catch (RestClientResponseException expceptionObj) {
            // handles exceptions thrown by rest template and contains status codes
            System.out.println(expceptionObj.getRawStatusCode() + " : " + expceptionObj.getStatusText());
        } catch (ResourceAccessException exceptionObj) {
            // i/o error, ex: the server isn't running
            System.out.println(exceptionObj.getMessage());
        }
    }

    /**
     * Delete an existing gambler in tehdata source
     * @param id
     */
    public void deleteAGambler(int id) {
        try {
            restTemplate.delete(BASE_URL + "gamblers/" + id);
        } catch (RestClientResponseException expceptionObj) {
            // handles exceptions thrown by rest template and contains status codes
            System.out.println(expceptionObj.getRawStatusCode() + " : " + expceptionObj.getStatusText());
        } catch (ResourceAccessException exceptionObj) {
            // i/o error, ex: the server isn't running
            System.out.println(exceptionObj.getMessage());
        }
    }

} // End of Gambler service
