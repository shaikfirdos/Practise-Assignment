import { Component } from '@angular/core';

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.css']
  
 
})
export class AppComponent {

  //Cartoons: cartoon[] =[{Priority:'Doraemon',val:1},{Priority:'Shinchan',val:2},{Priority:'Phinese&Ferb',val:3}];
  //selectedValus:string='Doraemon';

  title = 'firhem';
  vegetables: any []= ["Brinjal","Potato","Onion"];

  subtitle='Colleage-Data';
  Student1: Student  []=[{RegdId:'17NM5A0427',Name:'ShaikFirdos',Trade:'ECE'},
                    {RegdId:'17NM5A0428',Name:'Hema',Trade:'ECE'},
                    {RegdId:'17NM5A0429',Name:'NayimaKausar',Trade:'ECE'},
]
  
}

class Student{
  RegdId:any;
  Name:any;
  Trade:any;

}

//class cartoon{
  ///Priority:string;
  //val:number;
//}
