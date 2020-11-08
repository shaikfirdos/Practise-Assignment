import { Component } from '@angular/core';

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.css']
})
export class AppComponent {
  onSave($event){    
    console.log("Save button is clicked!", $event);    
  }    
  title = "Data binding using Property Binding";      
  //h1="https://www.google.com/imgres?imgurl=https%3A%2F%2Fimage.shutterstock.com%2Fimage-photo%2Fmicro-peacock-feather-hd-imagebest-260nw-1127238599.jpg&imgrefurl=https%3A%2F%2Fwww.shutterstock.com%2Fsearch%2Fhd%2Bimages&tbnid=98SB1BeJZjgGoM&vet=12ahUKEwjzu8jYvfPsAhUW0HMBHVLTB74QMygAegUIARC8AQ..i&docid=dO5dUAol6GHK-M&w=390&h=280&q=hd%20images&ved=2ahUKEwjzu8jYvfPsAhUW0HMBHVLTB74QMygAegUIARC8AQ";    
  title1='Data binding example for string interpolation';
  f1:number =1000;
  f2:number=2000;
  add()
  {
    return this.f1+this.f2;
  }
}


