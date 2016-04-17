import {bootstrap}    from 'angular2/platform/browser';
import {AppComponent} from './app.component';
import {bind} from 'angular2/core';
import {ROUTER_PROVIDERS, LocationStrategy, HashLocationStrategy} from "angular2/router";


bootstrap(AppComponent,
    [ROUTER_PROVIDERS,
    bind(LocationStrategy).toClass(HashLocationStrategy)
    ]);

