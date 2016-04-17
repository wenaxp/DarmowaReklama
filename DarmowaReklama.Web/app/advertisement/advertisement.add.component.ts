import {Component} from 'angular2/core';
import { AdvertisementService } from '../services/advertisement.service';

@Component({
    selector:'advertisement-add',
    templateUrl:'/app/advertisement/advertisement.add.component.html',
    providers: [AdvertisementService]
})
export class AdvertisementAddComponent {
    constructor(private _advertisementService: AdvertisementService) { }
    advertisementAdd = this._advertisementService.add;
    title:string;
}