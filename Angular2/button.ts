import { Component } from '@angular/core';

@Component({
  selector: 'app-root',
  //templateUrl: './app.component.html',
  styleUrls: ['./app.component.css'],
  template: `  
  <button (click)="show = !show">{{show ? 'hide' : 'show'}}</button>  
  show = {{show}}  
  <br>  
  <div *ngIf="show">Text to show</div>  
`  
})
export class AppComponent {

  show: boolean = true;  
}