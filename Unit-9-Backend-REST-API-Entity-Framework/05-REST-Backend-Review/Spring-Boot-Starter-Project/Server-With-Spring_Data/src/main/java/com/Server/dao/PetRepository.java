package com.Server.dao;

import com.Server.model.Pet;
import org.springframework.data.jpa.repository.JpaRepository;

// Data type passed to JpaRepository cannot be a primitive type:
// Use wrapper classes "Integer, Float , Double, Boolean, String"

public interface PetRepository extends JpaRepository<Pet, Integer> {

}
