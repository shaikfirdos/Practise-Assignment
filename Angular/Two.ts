import { Component } from '@angular/core';

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.css']
})
export class AppComponent {

  fullName: string = "Hello JavaTpoint";    

  onSave($event){    
    console.log("Save button is clicked!", $event);    
  }    
  title = "Data binding using Property Binding";      
  imgUrl="https://static.javatpoint.com/tutorial/angular7/images/angular-7-logo.png";    
  
  title1='Data binding example for string interpolation';
  f1:number =1000;
  f2:number=2000;
  add()
  {
    return this.f1+this.f2;
  }
}


