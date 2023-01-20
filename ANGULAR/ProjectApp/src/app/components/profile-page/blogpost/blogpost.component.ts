import { Component, Input, OnInit } from '@angular/core';

@Component({
  selector: 'app-blogpost',
  templateUrl: './blogpost.component.html',
  styleUrls: ['./blogpost.component.css']
})
export class BlogpostComponent implements OnInit{
  @Input() post : any
  starRating = 0;
  constructor() { }

  ngOnInit() {
  }

  toggleViewBlog(){
    console.log('ok');
  }
}
