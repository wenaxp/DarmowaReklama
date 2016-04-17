import {Component} from 'angular2/core';
import {AdvertisementsComponent} from './advertisement/advertisement.list.component';
import {AdvertisementAddComponent} from './advertisement/advertisement.add.component';
import {ROUTER_DIRECTIVES, RouteConfig, Router } from "angular2/router";
import { HTTP_PROVIDERS } from 'angular2/http';

@Component({
    selector: 'my-app',
    templateUrl: '/app/app.component.html',
    directives: [AdvertisementsComponent, AdvertisementAddComponent, ROUTER_DIRECTIVES],
    providers: [HTTP_PROVIDERS]
})
@RouteConfig([
    { path: "/advertisements", name: "Advertisements", component: AdvertisementsComponent, useAsDefault: true },
    { path: "/add-advertisement", name: "AdvertisementAdd", component: AdvertisementAddComponent }
])
export class AppComponent {
    constructor(public router: Router) {
    }

    isActive = (name: string) => {
        console.log(name + " | " + this.router.hostComponent.name);
        return name == this.router.hostComponent.name;
    };
}
