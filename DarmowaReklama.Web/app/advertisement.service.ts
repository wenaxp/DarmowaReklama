import {Injectable} from 'angular2/core';


export interface IAdvertisement{
    //INFORMACJE PODSTAWOWE
    id:number;
    password:string;
    category:number;//*
    name:string;//*
    age:number;//*
    weight:number;//*
    breastSize:number;//*
    languages:number[];
    //LOKALIZACJA
    city:number;//*
    voivodeship:number;//*
    district:number;
    address:string;
    //DANE KONTAKTOWE
    email:string;//*
    telephone:string;//*
    //USŁUGA
    priceFor1h:number;//*
    priceFor30min:number;
    priceFor15min:number;
    priceForAllNight:number;
    OutCalls:number;//tak,nie, tylko hotele
    //GODZINY PRACY
    poniedzialekOd:number;
    poniedzialekDo:number;
    
    trescOgloszeniaPL:string;
    
}

@Injectable()
export class AdvertisementService {
    constructor() {
        
    }
    list=()=>{
        return [
        {id:1,title:"dafdf"},
        {id:2,title:"dafdf"}
    ]};
    add=(advertisement:IAdvertisement)=>{
        
    };
}