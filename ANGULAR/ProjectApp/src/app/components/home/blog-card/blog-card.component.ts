import { Component } from '@angular/core';

@Component({
  selector: 'app-blog-card',
  templateUrl: './blog-card.component.html',
  styleUrls: ['./blog-card.component.css']
})
export class BlogCardComponent {
  starRating = 0; 
  toggleViewBlog(){
    console.log('ok');
  }
}
