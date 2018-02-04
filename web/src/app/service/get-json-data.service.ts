import { Injectable } from '@angular/core';
import { Http, Response } from '@angular/http';
import {Observable} from 'rxjs/Rx';


@Injectable()
export class GetJsonDataService {
  private JsonData: any;
  constructor(private http: Http) { }

  public GetJsonFromFile(FileName: any):Observable<any> {
   return this.http.get(FileName)
      .map((res: Response) => { return res.json(); });
  }
}
