import { Component, OnInit } from '@angular/core';
import { BlogPost } from 'src/app/model/blogpost';
import { ActivatedRoute } from '@angular/router';
import { PostService } from 'src/app/services/posts.service';
import { AddCommentService } from 'src/app/services/addComment.service';

@Component({
  selector: 'app-profile',
  templateUrl: './profile.component.html',
  styleUrls: ['./profile.component.css']
})
export class ProfileComponent implements OnInit {

  commentCount: any;
  userName = localStorage.getItem('token');
  userEmail = localStorage.getItem('email');
  posts: BlogPost[];
  postCount: number;
  constructor(private commentService: AddCommentService,private postsService: PostService){}


  ngOnInit() {
    this.postsService.getUserPosts(this.userName).subscribe(
      posts => {
        this.posts = posts;
        this.postCount = posts.length;
      }
    );
    this.commentService.getUserCommentCount(this.userName).subscribe(
      comment => {
        this.commentCount = comment;
      }
    )
}
}
