import { Injectable } from '@angular/core';
import { PetInfo } from '../interfaces/pet-info';

@Injectable({
  providedIn: 'root'
})
export class Pet {

  petData : PetInfo[] = []

  constructor() {
    this.petData.push({name: 'Jenna', type: 'Dog', gender: 'Female'})
    this.petData.push({name: 'Luna', type: 'Cat', gender: 'Female'})
    this.petData.push({name: 'Pebbles', type: 'Cat', gender: 'Male'})
    this.petData.push({name: 'Cooper', type: 'Dog', gender: 'Male'})
   }

   getPetData() : PetInfo[] {
    return this.petData;
   }
}
