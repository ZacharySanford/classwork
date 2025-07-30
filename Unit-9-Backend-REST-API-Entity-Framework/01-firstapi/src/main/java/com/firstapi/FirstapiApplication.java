package com.firstapi;


import org.springframework.boot.SpringApplication;
import org.springframework.boot.autoconfigure.SpringBootApplication;

// This is the main class for the Spring Boot application.
// It contains the main method which is the entry point of the application
// The @SpringBootApplication annotation indicates that this is a Spring Boot Application
// This is what starts when you run the application

@SpringBootApplication
public class FirstapiApplication {
		// The main method is the entry point of the application
	public static void main(String[] args) {
		// SpringApplication.run() method is used to launch the application.
		// It takes the application class and command line arguments as parameters
		SpringApplication.run(FirstapiApplication.class, args);
	}

}
