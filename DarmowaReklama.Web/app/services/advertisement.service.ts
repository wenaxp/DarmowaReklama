import {Component, Injectable} from 'angular2/core';
import {Http, HTTP_PROVIDERS, Response} from 'angular2/http';
import {IAdvertisement} from '../models/iadvertisement.model';
import {IAdvertisementPaging} from '../models/iadvertisementPagging.model';
import { Observable } from 'rxjs/Rx';
import {AppSettings} from '../app.settings';

@Injectable()
export class AdvertisementService {
    constructor(private http: Http) { }
    getAdvertisementPaging() {
        return this.http.get(`${AppSettings.ApiEndPoint}/Advertisement/GetList`)
            .map((response: Response) => <IAdvertisementPaging>response.json())
            .catch(this.handleError);
    };
    add = (advertisement: IAdvertisement) => {

    };

    private handleError(error: Response) {
        console.error(error);
        return Observable.throw(error.json().error || 'Server error');
    }
}