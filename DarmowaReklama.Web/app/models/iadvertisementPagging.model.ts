import {IAdvertisement} from './iadvertisement.model';

export interface IAdvertisementPaging {
    totalPages: number;
    pageNo: number;
    pageSize: number;
    sortColumn: string;
    isAsc: boolean;
    cityId: number;
    voivodeshipId: number;
    ageFrom: number;
    ageTo: number;
    weightFrom: number;
    weightTo: number;
    heightFrom:number;
    heightTo:number;
    breastSizeFrom: number;
    breastSizeTo: number;
    isEnglish: boolean;
    isGerman: boolean;
    isRussian: boolean;
    price1hFrom: number;
    price1hTo: number;
    price30minFrom: number;
    price30minTo: number;
    price15minFrom: number;
    price15minTo: number;
    priceAllNightFrom: number;
    priceAllNightTo: number;
    outCallsId: number;
    list: IAdvertisement[];
}