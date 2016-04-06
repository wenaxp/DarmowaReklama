import {Component} from 'angular2/core';
import { AdvertisementService } from '../advertisement.service';

@Component({
    selector:'advertisements',
    templateUrl:'/app/advertisement/advertisement.list.component.html',
    providers: [AdvertisementService]
})
export class AdvertisementsComponent {
    constructor(private _advertisementService: AdvertisementService) { }
    advertisements = this._advertisementService.list();
}