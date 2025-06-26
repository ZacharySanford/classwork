import { Component } from '@angular/core';
import { FormsModule } from '@angular/forms';
import { throwError } from 'rxjs';

@Component({
  selector: 'form-example',  // Name used in html to reference the component <form-example>
  standalone: true,
  imports: [FormsModule],  // Tell Angular we want Forms support for this code
  templateUrl: './form-example.component.html',
  styleUrl: './form-example.component.css'
})
// Allow access to stuff defined this component from outside the component
export class FormExampleComponent {
  // Data to be shared with Angular when processing the web page
  buttonClicked = false
  firstName = ""
  lastName = ""
  birthDate = ""
  foodPref = ""
  emailAddress = ""
  emailPref = ""
  prefSports : any[]
  // Methods to handle interactions with the html/webpage
  onSubmit() { // Handle the Submit button click on the  form
    this.buttonClicked = true
    console.log(`OK.... You Clicked Submit`)
    console.log(`You entered ${this.firstName} in the first name field`)
    console.log(`You entered ${this.lastName} in the last name field` )
    console.log(`You entered ${this.birthDate} in the birthday field`)
    console.log(`You entered ${this.foodPref} in the food preference field`)
    console.log(`You entered ${this.emailAddress} in the food preference field`)
    console.log(`You entered ${this.emailPref} in the food preference field`)
    console.log(`You entered ${this.prefSports} in the sports preferences field`)
  }
}
