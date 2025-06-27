import { CommonModule } from '@angular/common';
import { Component } from '@angular/core';
import { FormsModule } from '@angular/forms';
import { throwError } from 'rxjs';

@Component({
  selector: 'form-example',  // Name used in html to reference the component <form-example>
  standalone: true,
  imports: [FormsModule, CommonModule],  // Tell Angular we want Forms support for this code
  templateUrl: './form-example.component.html',
  styleUrl: './form-example.component.css'
})
// Allow access to stuff defined this component from outside the component
export class FormExampleComponent {
  // Data to be shared with the Angular when processing the web page
  buttonClicked = false
  firstName = ""     // hold the data from first name from the form
  lastName = ""      // hold the data from last name from the form
  birthday = ""     // hold the data from birthday from the form
  foodPreference = ""
  emailAddress = ""
  sendEmail = ""
  // A checkbox control may have multiple values (many checkboxes can be checked)
  // Sports is specified as a checkbox it's data will be returned as an array
  // With each element in the array corresponding to a choice
  // Checkbox need to be included in the html a individual element
  // More tomorrow
  sports : any[] = [
    {name: 'European Football', value:"Soccer"},
    {name: 'American Football', value:"Football"},
    {name: 'Baseball', value:"Baseball"},
    {name: 'Basketball', value:"Basketball"},
    {name: 'Cricket', value:"Cricket"},
    {name: 'Hockey', value:"Hockey"},
    {name: 'Other', value:"Other Sport"},
    {name: 'None', value:"None"},
  ]
  //sports = ""
 // Methods to handle interactions with the html/web page
  onSubmit() { // Handle the Submit button click on the  form
    this.buttonClicked = true
    console.log(`OK.... You Clicked Submit`)
    console.log(`You entered ${this.firstName} in the First Name field`)
    console.log(`You entered ${this.lastName} in the Last Name field`)
    console.log(`You entered ${this.emailAddress} in the email field`)
    //console.table(this.sports)

    // console.table(this.checkboxResult) // This will call a function named checkboxResult
    console.log("You indicated you like the following sports")
    // Display each item checked on a line by itself
    // Loop through an array of items that were checked and display them
    // .forEach() - an array function that will loop through an array passing each element to an arrow function (=>)
    // Use checkbox result function to get an array of checked items
    // then give the array to .forEach to display each item
    this.checkboxResult.forEach((aBox)=> console.log(aBox.name))
  }

  get checkboxResult(){
    //Loop through the checkbox array(sports)
    //if an item has checked equals true, save for return when done
    // When the loop is done, return all the items where checked was true
    //
    // .filet() is an array function that will go through an array one element at a time
    //          using an arrow function (=>) to tell it whether the current element
    //          should be saved in a new array
    //
    //          if the arrow (=>) returns true, the current element is saved in a new array
    //
    //          After all elements in the array are processed, it returns the array it saved elements in
    return this.sports.filter((aCheckbox) => aCheckbox.checked)

  }

}
