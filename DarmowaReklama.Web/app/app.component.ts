import {Component} from 'angular2/core';
import {AdvertisementsComponent} from './advertisement/advertisement.list.component';
import {AdvertisementAddComponent} from './advertisement/advertisement.add.component';
import {ROUTER_DIRECTIVES,RouteConfig,Router} from "angular2/router";

@Component({
    selector: 'my-app',
    templateUrl: '/app/app.component.html',
    directives: [AdvertisementsComponent,AdvertisementAddComponent,ROUTER_DIRECTIVES]
   
})
@RouteConfig([
    {path:"/advertisements",name:"Advertisements",component:AdvertisementsComponent},
    {path:"/add-advertisement",name:"AdvertisementAdd",component:AdvertisementAddComponent}
])
export class AppComponent {
    constructor(public router: Router){  
    }
    
    isActive=(name:string)=>{
        console.log(name+" | "+this.router.hostComponent.name);
        return name==this.router.hostComponent.name;
    };
 }
