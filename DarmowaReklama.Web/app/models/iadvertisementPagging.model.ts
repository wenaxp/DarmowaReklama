import {IAdvertisement} from './iadvertisement.model';

export interface IAdvertisementPaging {
    TotalPages: number;
    PageNo: number;
    PageSize: number;
    SortColumn: string;
    IsAsc: boolean;
    CityId: number;
    VoivodeshipId: number;
    AgeFrom: number;
    AgeTo: number;
    WeightFrom: number;
    WeightTo: number;
    BustSizeFrom: number;
    BustSizeTo: number;
    IsEnglish: boolean;
    IsGerman: boolean;
    IsRussian: boolean;
    Price1hFrom: number;
    Price1hTo: number;
    Price30minFrom: number;
    Price30minTo: number;
    Price15minFrom: number;
    Price15minTo: number;
    PriceAllNightFrom: number;
    PriceAllNightTo: number;
    OutCallsId: number;
    List: IAdvertisement[];
}