System.register(['angular2/core', '../services/advertisement.service'], function(exports_1, context_1) {
    "use strict";
    var __moduleName = context_1 && context_1.id;
    var __decorate = (this && this.__decorate) || function (decorators, target, key, desc) {
        var c = arguments.length, r = c < 3 ? target : desc === null ? desc = Object.getOwnPropertyDescriptor(target, key) : desc, d;
        if (typeof Reflect === "object" && typeof Reflect.decorate === "function") r = Reflect.decorate(decorators, target, key, desc);
        else for (var i = decorators.length - 1; i >= 0; i--) if (d = decorators[i]) r = (c < 3 ? d(r) : c > 3 ? d(target, key, r) : d(target, key)) || r;
        return c > 3 && r && Object.defineProperty(target, key, r), r;
    };
    var __metadata = (this && this.__metadata) || function (k, v) {
        if (typeof Reflect === "object" && typeof Reflect.metadata === "function") return Reflect.metadata(k, v);
    };
    var core_1, advertisement_service_1;
    var AdvertisementsComponent;
    return {
        setters:[
            function (core_1_1) {
                core_1 = core_1_1;
            },
            function (advertisement_service_1_1) {
                advertisement_service_1 = advertisement_service_1_1;
            }],
        execute: function() {
            AdvertisementsComponent = (function () {
                function AdvertisementsComponent(_advertisementService) {
                    this._advertisementService = _advertisementService;
                }
                AdvertisementsComponent.prototype.ngOnInit = function () {
                    var _this = this;
                    this._advertisementService.getAdvertisementPaging()
                        .subscribe(function (advertisementPaging) {
                        _this.advertisementPaging = advertisementPaging;
                        console.log(advertisementPaging);
                    }, function (error) {
                        console.error('TO:' + error);
                    });
                };
                AdvertisementsComponent = __decorate([
                    core_1.Component({
                        selector: 'advertisements',
                        templateUrl: '/app/advertisement/advertisement.list.component.html',
                        providers: [advertisement_service_1.AdvertisementService]
                    }), 
                    __metadata('design:paramtypes', [advertisement_service_1.AdvertisementService])
                ], AdvertisementsComponent);
                return AdvertisementsComponent;
            }());
            exports_1("AdvertisementsComponent", AdvertisementsComponent);
        }
    }
});
//# sourceMappingURL=advertisement.list.component.js.map