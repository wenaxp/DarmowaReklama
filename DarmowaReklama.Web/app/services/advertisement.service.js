System.register(['angular2/core', 'angular2/http', 'rxjs/Rx', '../app.settings'], function(exports_1, context_1) {
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
    var core_1, http_1, Rx_1, app_settings_1;
    var AdvertisementService;
    return {
        setters:[
            function (core_1_1) {
                core_1 = core_1_1;
            },
            function (http_1_1) {
                http_1 = http_1_1;
            },
            function (Rx_1_1) {
                Rx_1 = Rx_1_1;
            },
            function (app_settings_1_1) {
                app_settings_1 = app_settings_1_1;
            }],
        execute: function() {
            AdvertisementService = (function () {
                function AdvertisementService(http) {
                    this.http = http;
                    this.add = function (advertisement) {
                    };
                }
                AdvertisementService.prototype.getAdvertisementPaging = function () {
                    return this.http.get(app_settings_1.AppSettings.ApiEndPoint + "/Advertisement/GetList")
                        .map(function (response) { return response.json(); })
                        .catch(this.handleError);
                };
                ;
                AdvertisementService.prototype.handleError = function (error) {
                    console.error(error);
                    return Rx_1.Observable.throw(error.json().error || 'Server error');
                };
                AdvertisementService = __decorate([
                    core_1.Injectable(), 
                    __metadata('design:paramtypes', [http_1.Http])
                ], AdvertisementService);
                return AdvertisementService;
            }());
            exports_1("AdvertisementService", AdvertisementService);
        }
    }
});
//# sourceMappingURL=advertisement.service.js.map