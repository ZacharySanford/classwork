package com.Server.model;

import jakarta.persistence.*;

import java.util.Objects;


@Entity // Tells the data framework this is something it cares about
@Table(name = "pet") // Tells the data framework the table this POJO represents
public class Pet {

    // Data members
    @Id
    @GeneratedValue(strategy = GenerationType.IDENTITY)
    @Column (name="pet_id")
    private int petId;
    @Column (name="name")
    private String petName;
    @Column (name="pet_type_id")
    private int petTypeId;
    @Column (name="owner_id")
    private int ownerId;

    // Constructors

    // Programmer defined default constructor
    public Pet() {}

    // IDE Generated Constructor
    public Pet(int petId, String petName, int petTypeId, int ownerId) {
        this.petId = petId;
        this.petName = petName;
        this.petTypeId = petTypeId;
        this.ownerId = ownerId;
    }

    // Getters and Setters - IDE Generated

    public int getPetId() {
        return petId;
    }
    public void setPetId(int petId) {
        this.petId = petId;
    }
    public String getPetName() {
        return petName;
    }
    public void setPetName(String petName) {
        this.petName = petName;
    }
    public int getPetTypeId() {
        return petTypeId;
    }
    public void setPetTypeId(int petTypeId) {
        this.petTypeId = petTypeId;
    }
    public int getOwnerId() {
        return ownerId;
    }
    public void setOwnerId(int ownerId) {
        this.ownerId = ownerId;
    }

    // Overrides ( ToString, Equals, Hashcode)
    @Override
    public String toString() {
        return "Pet{" +
                "petId=" + petId +
                ", petName='" + petName + '\'' +
                ", petTypeId=" + petTypeId +
                ", ownerId=" + ownerId +
                '}';
    }

    @Override
    public boolean equals(Object o) {
        if (!(o instanceof Pet pet)) return false;
        return petId == pet.petId && petTypeId == pet.petTypeId && ownerId == pet.ownerId && Objects.equals(petName, pet.petName);
    }

    @Override
    public int hashCode() {
        return Objects.hash(petId, petName, petTypeId, ownerId);
    }

    // Additional Methods to support class


}// End of Gambler
