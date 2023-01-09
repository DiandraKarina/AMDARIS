import {Component} from '@angular/core';

@Component({
    selector: 'first',
    template:`<ul>
    <li *ngFor="let book of books"><h2>{{book.title}}</h2>
    <h4>{{book.author}}</h4></li>
    </ul>
    `
})
export class FirstComponent{
    public books: Array<any> = [
        { title: 'The Silent Patient', author: 'Alex Michaelides' },
        { title: "Ugly Love", author: "Coleen Hoover" },
        { title: "Verity", author: "Coleen Hoover" },
        { title: "All The Light We Cannot See", author: "Anthony Doerr" }
      ];
}

