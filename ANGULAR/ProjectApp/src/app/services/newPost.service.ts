import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { BlogPost } from 'src/app/model/blogpost';

@Injectable({
  providedIn: 'root'
})
export class NewPostService {

constructor(private http:HttpClient) { }

// addBlog(blog: Blog){
//   let newBlog = [];
//   if(localStorage.getItem('Blogs')) {
//     newBlog = JSON.parse(localStorage.getItem('Blogs'));
//     newBlog = [blog, ...newBlog];
//   } else {
//     newBlog = [blog];
//   }
//   localStorage.setItem('Blogs', JSON.stringify(newBlog));
// }

addBlog(blogpost: BlogPost) {
  return this.http.post('http://localhost:53744/api/Post/post', blogpost);
}

newpostID() {
  if(localStorage.getItem('PID')) {
    localStorage.setItem('PID', String(+localStorage.getItem('PID')+1));
    return +localStorage.getItem('PID');
  } else {
    localStorage.setItem('PID', '101');
    return 101;
  }
}
}