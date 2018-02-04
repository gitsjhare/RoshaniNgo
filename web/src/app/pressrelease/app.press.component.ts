import { Component,OnInit } from '@angular/core';
//import { Http, Response } from '@angular/http';
//import {YearAndJsonFilePath} from './app.press.components.interface';
import {GetJsonDataService} from '../service/get-json-data.service';



@Component({
    selector: 'Roshani-Press',
    templateUrl: './app.press.component.html',
    styleUrls: ['./app.press.component.scss'],
    providers:[GetJsonDataService]
})


// tslint:disable-next-line:component-class-suffix
export class Press implements OnInit {
    public Years: any;
    public YearlyUrl: any;    
    public GallaryArray:any[]=[];
    public Gallery:any;
    constructor(private jsondata:GetJsonDataService) {        
    }
    ngOnInit(): void {
    
     this.jsondata.GetJsonFromFile("/assets/data/PressNews.json").subscribe(
         response=>{
             this.Years=response
            },(error:any)=>console.log(error),()=>console.log("Load Complete")
     );
    }
}
