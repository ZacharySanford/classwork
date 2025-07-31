package com.gamblerapi.controller;
// Anything associated with the server must be in the same package as the server
//                  so the server can find it.
// Server, Controller, DAOs, POJO Model Class for data, Server, Repository, et al.
//                  are all in the same package as the server

// Controller contains methods that handle HTTP requests
// When the server receives a request,
//                  it will route it to the appropriate controller

import com.gamblerapi.dao.GamblerDAO.GamblerMemoryDao;
import com.gamblerapi.model.Gambler;
import org.springframework.web.bind.annotation.GetMapping;
import org.springframework.web.bind.annotation.PathVariable;
import org.springframework.web.bind.annotation.RequestParam;
import org.springframework.web.bind.annotation.RestController;

import java.util.List;

// When the server is looking for controller methods it searches for class that are annotated with @RestController
// If you forget to add the @RestController annotation, the server will not be able to find your controller methods


@RestController     // This annotation indicates that this class contains REST controller methods
                    // REST stands for Representational State Transfer
                    // REST is an architectural style for designing networked applications
                    // REST is the protocol for communication between client and server
public class GamblerController {
    // This is where you will define your controller methods
    // Controller methods are the methods that handle HTTP requests
    // They are annotated with @GetMapping, @PostMapping, @PutMapping, @DeleteMapping, etc.

    // Define a reference to the Gambler DAO
    private GamblerMemoryDao gamblerDao;

    // Constructor to initialize the GamblerDAO
    public GamblerController() {
        this.gamblerDao = new GamblerMemoryDao();
    }

    // Define a controller to handle a GET request to the root URL ("\" or nothing)
    // This method will return a simple greeting message
    @GetMapping("/") // This annotation maps HTTP GET requests to this method for "/" path
    public String methodNameIsNotImportantButMustBeUnique(){
        return "Welcome to the Gambler API";
    }


    // Define a controller to handle a GET request to return all the Gamblers
    //
    // We need:
    // 1: This method will return a list of all gamblers
    // 2: The DAO method we call that will return a list of gamblers
    // 3: URL path for performing this action is

    @GetMapping("/gamblers")
    public List<Gambler> getAllGamblers(){
        // Call the DAO method to get all gamblers
        return gamblerDao.getGamblers();
    }

    // Define a controller to handle a GET request to return all the Gamblers
    //
    // We need:
    // 1: This method will return a gambler: Gambler object
    // 2: DAO method that will return a gambler by id: getGamblerById(int id)
    // 3: URL path for performing this action is: /gambler/{id}
    // 4: HTTP method: GET

    @GetMapping("/gamblers/{id}")
    public Gambler getGamblerById(@PathVariable int id){
        return gamblerDao.getGamblerById(id);
    }

    // Define a controller to handle a GET request to return all the Gamblers
    //
    // We need:
    // 1: This method will return a gambler: Gambler object
    // 2: DAO method that will return a gambler by name: getGamblerByName(String name)
    // 3: URL path for performing this action is: /gamblers?name={name}
    // 4: HTTP method: GET

    @GetMapping("/gamblers/search")
    public Gambler getGamblerByName(@RequestParam String name){
        return gamblerDao.getGamblerByName(name);
    }


}
