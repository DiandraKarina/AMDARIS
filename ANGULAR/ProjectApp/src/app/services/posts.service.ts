import { Injectable } from '@angular/core';

import {Subject} from "rxjs";
import { Observable } from 'rxjs';
import { HttpClient } from '@angular/common/http';
import { BlogPost } from '../model/blogpost';

@Injectable({providedIn: 'root'})

export class PostService{

    constructor(private http: HttpClient) {}

    getPost(id: number) {
        return this.http.get('http://localhost:53744/api/Post/findPost/'+id);
      }

      // http://localhost:53744/api/Post?

      getAllPosts(): Observable<BlogPost[]> {
        return this.http.get<BlogPost[]>('http://localhost:53744/api/Post');
      }

      getUserPosts(userName: string) {
        return this.http.get<BlogPost[]>('http://localhost:53744/api/Post/userPost/'+userName);
      }

      updatePost(id:number, title:string, description:string) {
        return this.http.put('http://localhost:53744/api/Post/edit/'+id,
        {Id:id,newTitle:title,newDescription:description});
      }

      deletePost(id:number) {
        return this.http.delete('http://localhost:53744/api/Post/delete/'+id);
      }
}