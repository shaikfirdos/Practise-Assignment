import { Component, OnInit } from '@angular/core';
import { Button } from 'protractor';

@Component({
  selector: 'app-sample',
  templateUrl: './sample.component.html',
  styleUrls: ['./sample.component.css']
  
})
export class SampleComponent implements OnInit {
 
  happy="Output is came";
  h1:number=100;
  h2:number=200;
  sub()
  {
    return this.h1-this.h2;
  }
  imgUrl="https://www.google.com/search?q=png+images&rlz=1C1CHBF_enIN926IN926&sxsrf=ALeKk00DpZVUEo6ZbPY9ft7DN6uFZBNFAw:1604859238902&tbm=isch&source=iu&ictx=1&fir=ljnR8qsOe_KWNM%252CkU78UyWVW14S1M%252C_&vet=1&usg=AI4_-kTpNMkkS8wPD0nO7E7JYP0xGcOhHw&sa=X&ved=2ahUKEwiRleXGxvPsAhWiguYKHQeqAbUQ9QF6BAgCEGA#imgrc=ljnR8qsOe_KWNM";
  constructor() { }

  ngOnInit(): void {
  }

}
