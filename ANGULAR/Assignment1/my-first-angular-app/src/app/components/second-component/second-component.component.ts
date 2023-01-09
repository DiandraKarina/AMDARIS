import { Component } from '@angular/core';

@Component({
  selector: 'app-second-component',
  templateUrl: './second-component.component.html',
  styleUrls: ['./second-component.component.css']
})
export class SecondComponentComponent {

  public books: Array<any> = [
    { title: 'The Silent Patient', author: 'Alex Michaelides' },
    { title: "Ugly Love", author: "Coleen Hoover" },
    { title: "Verity", author: "Coleen Hoover" },
    { title: "All The Light We Cannot See", author: "Anthony Doerr" }
  ];
}
