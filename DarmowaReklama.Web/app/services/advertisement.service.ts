import {Component} from 'angular2/core';
import {Http, HTTP_PROVIDERS} from 'angular2/http';
import {IAdvertisement} from '../models/iadvertisement.model';



@Injectable()
export class AdvertisementService {
    constructor() {

    }
    list = () => {
        return [
            { id: 1, title: "dafdf" },
            { id: 2, title: "dafdf" }
        ]
    };
    add = (advertisement: IAdvertisement) => {

    };
}