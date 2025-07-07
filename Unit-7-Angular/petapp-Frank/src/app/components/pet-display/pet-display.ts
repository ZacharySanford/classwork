import { CommonModule } from '@angular/common';
import { Component } from '@angular/core';
import { PetInfo } from '../../interfaces/pet-info';
import { Pet } from '../../services/pet';



@Component({
  selector: 'pet-display',
  standalone: true,
  imports: [CommonModule],
  templateUrl: './pet-display.html',
  styleUrl: './pet-display.css'
})
export class PetDisplay {

 ourPetInfo : PetInfo [] = []

  constructor(thePetData : Pet){
    this.ourPetInfo = thePetData.getPetData();
  }


}
