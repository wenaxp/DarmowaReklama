import {Component, OnInit} from 'angular2/core';
import { AdvertisementService } from '../services/advertisement.service';
import { IAdvertisementPaging } from '../models/iadvertisementPagging.model';

@Component({
    selector: 'advertisements',
    templateUrl: '/app/advertisement/advertisement.list.component.html',
    providers: [AdvertisementService]
})
export class AdvertisementsComponent implements OnInit {
    advertisementPaging: IAdvertisementPaging;
    constructor(private _advertisementService: AdvertisementService) { }

    ngOnInit() {
        this._advertisementService.getAdvertisementPaging()
            .subscribe(advertisementPaging => {
                this.advertisementPaging = advertisementPaging;
            });
    }

}