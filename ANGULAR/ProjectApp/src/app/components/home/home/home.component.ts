import { Component, OnInit } from '@angular/core';
import { PostService } from 'src/app/services/posts.service';

@Component({
  selector: 'app-home',
  templateUrl: './home.component.html',
  styleUrls: ['./home.component.css']
})
export class HomeComponent implements OnInit {
  posts: any[];
  constructor(private postsService: PostService) { }

  ngOnInit() {
    this.postsService.getAllPosts().subscribe(
      post_data=>{
        this.posts = post_data.reverse();
        console.log(this.posts);
      }, error => {
        console.log('error');
      }
    )
}
}
