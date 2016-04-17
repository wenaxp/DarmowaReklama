System.register(['angular2/core', './advertisement/advertisement.list.component', './advertisement/advertisement.add.component', "angular2/router", 'angular2/http'], function(exports_1, context_1) {
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
    var core_1, advertisement_list_component_1, advertisement_add_component_1, router_1, http_1;
    var AppComponent;
    return {
        setters:[
            function (core_1_1) {
                core_1 = core_1_1;
            },
            function (advertisement_list_component_1_1) {
                advertisement_list_component_1 = advertisement_list_component_1_1;
            },
            function (advertisement_add_component_1_1) {
                advertisement_add_component_1 = advertisement_add_component_1_1;
            },
            function (router_1_1) {
                router_1 = router_1_1;
            },
            function (http_1_1) {
                http_1 = http_1_1;
            }],
        execute: function() {
            AppComponent = (function () {
                function AppComponent(router) {
                    var _this = this;
                    this.router = router;
                    this.isActive = function (name) {
                        console.log(name + " | " + _this.router.hostComponent.name);
                        return name == _this.router.hostComponent.name;
                    };
                }
                AppComponent = __decorate([
                    core_1.Component({
                        selector: 'my-app',
                        templateUrl: '/app/app.component.html',
                        directives: [advertisement_list_component_1.AdvertisementsComponent, advertisement_add_component_1.AdvertisementAddComponent, router_1.ROUTER_DIRECTIVES],
                        providers: [http_1.HTTP_PROVIDERS]
                    }),
                    router_1.RouteConfig([
                        { path: "/advertisements", name: "Advertisements", component: advertisement_list_component_1.AdvertisementsComponent, useAsDefault: true },
                        { path: "/add-advertisement", name: "AdvertisementAdd", component: advertisement_add_component_1.AdvertisementAddComponent }
                    ]), 
                    __metadata('design:paramtypes', [router_1.Router])
                ], AppComponent);
                return AppComponent;
            }());
            exports_1("AppComponent", AppComponent);
        }
    }
});
//# sourceMappingURL=app.component.js.map