import { Component, OnInit} from '@angular/core';
import {BlogPost} from 'src/app/model/blogpost';
import { FormBuilder, FormControl, FormGroup, Validators } from '@angular/forms';
import { HttpClient, HttpHeaders } from '@angular/common/http';
import { Router } from '@angular/router';
import { NewPostService } from 'src/app/services/newPost.service';
import { AlertifyService } from 'src/app/services/alertify.service';

@Component({
  selector: 'app-new-post',
  templateUrl: './new-post.component.html',
  styleUrls: ['./new-post.component.css']
})
export class NewPostComponent implements OnInit {

  addBlogForm: FormGroup;
  blogpost: BlogPost;
  userSubmitted: boolean;
  file: any;
  fileExtension: any;
  filepostedOn= new Date().toString().split("+")[0].split(':').join('_');
  //filepostedOn= new Date().toString().split(':').join('_');
  imageUrl: string | ArrayBuffer = "https://www.adc-awards.archi/images/joomlart/demo/default.jpg"

  constructor(private fb: FormBuilder,
              private newPostService: NewPostService,
              private alertify: AlertifyService,
              private router: Router,
              private http:HttpClient) { }

  ngOnInit() {
    this.CreateAddBlogForm();
  }

  onSubmit(){
    this.userSubmitted = true;

    if(this.addBlogForm.valid) {
      console.log(this.addBlogForm);
      const formData: FormData = new FormData();
      formData.append('file', this.file, this.file.name+this.filepostedOn+this.fileExtension);
      this.http.post('http://localhost:53744/api/Post', formData).subscribe(
        data => {
          console.log(data);
        }
      );
      //this.newBlogService.addBlog(this.blogData());
      this.newPostService.addBlog(this.blogData()).subscribe(
        data => {
          console.log(data);
          this.alertify.warning("Please wait for the blog to be uploaded");
          setTimeout(() => {
            this.alertify.success("You have successfully posted a new blog");
            this.router.navigate(['/home']);
            this.addBlogForm.reset();
        }, 2000);
        }
      );

      this.userSubmitted = false;

    } else {
      this.alertify.error("Kindly provide the required fields");
    }
  }

  CreateAddBlogForm() {
    this.addBlogForm = this.fb.group({
      Category:[null,Validators.required],
      Title: [null, Validators.required],
      Description: [null, Validators.required],
      Banner_Image: [null, Validators.required]
    })
  }

  get Category(){
    return this.addBlogForm.get('Category') as FormControl;
  }
  get Title(){
    return this.addBlogForm.get('Title') as FormControl;
  }

  get Description(){
    return this.addBlogForm.get('Description') as FormControl;
  }

  get Image(){
    return this.addBlogForm.get('Image') as FormControl;
  }

  blogData(): BlogPost {
    return this.blogpost = {
      //Id: this.newBlogService.newpostID(),
      category:this.Category.value,
      image: this.file.name+this.filepostedOn+this.fileExtension,
      postName: this.Title.value,
      description: this.Description.value
    }
  }

  onFileSelect(event) {
    this.file = event.target.files[0];
    this.fileExtension = (".").concat(this.file.name.split('.').pop());

    const reader = new FileReader();
    reader.readAsDataURL(this.file);

    reader.onload = event => {
      this.imageUrl = reader.result;
    };
  }
}
