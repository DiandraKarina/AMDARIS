import { HttpClient } from "@angular/common/http";
import{Injectable} from "@angular/core";
import { Observable } from 'rxjs';
import { EncryptionService } from './encryption.service';

@Injectable({
    providedIn: 'root'
})
export class AuthService{
    constructor(private http: HttpClient,
        private encryptionService: EncryptionService) { }

        baseServerUrl="https://localhost:44396/api/";
registerUser(user:Array<String>){
    return this.http.post(this.baseServerUrl+"User/CreateUser",null,{
        responseType:'text',
    });
}
getAllUsers(): Observable<string[]> {
return this.http.get<string[]>('http://localhost:53744/api/User');
}

authUser(user: any, UserArray:any[]) {
return UserArray.find(p => p.userName === user.userName && p.password === this.encryptionService.encryptPass(user.password));
}
}