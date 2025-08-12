package com.Server.dao;

import com.Server.model.Pet;

import java.util.List;
import java.util.Optional;

public interface IPet {
    // Provide method signatures for operations that can be performed on the data
    // Should provide at least minimum CRUD support
    // The actual code to perform the processing is in the implementation file

    // Get all entries for data source - return multiple objects
    public List<Pet> getAllPets();

    // Get an entry by primary key - return one object - receive primary key value
    public Optional<Pet> returnPet(int petId);
    // Add an entry to data source - return the entry added (REST protocol) - receive an object
    public Pet addPet(Pet aPet);
    // Update an entry in the data source - return the entry updated (REST protocol) - receive an object
    public Pet updatePet(Pet aPet);
    // Delete an entry by primary key - return nothing (REST protocol) - receive primary key value
    public void deletePet(int petId);
}
