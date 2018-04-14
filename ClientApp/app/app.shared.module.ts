import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { FormsModule } from '@angular/forms';
import { HttpModule } from '@angular/http';
import { RouterModule } from '@angular/router';

import { AppComponent } from './components/app/app.component';
import { NavMenuComponent } from './components/navmenu/navmenu.component';
import { HomeComponent } from './components/home/home.component';
import { ClientsListComponent } from "./components/clients/clientsList";
import { ClientComponent } from "./components/clients/clientEdit";
import { ClientViewComponent } from "./components/clients/clientView";
import { ToastModule } from "ng2-toastr";
import { BrowserModule } from "@angular/platform-browser"
import { BrowserAnimationsModule } from "@angular/platform-browser/animations"

@NgModule({
    declarations: [
        AppComponent,
        NavMenuComponent,
        ClientsListComponent,
        ClientComponent,
        ClientViewComponent,
        HomeComponent
    ],
    imports: [
        CommonModule,
        HttpModule,
        FormsModule,
        BrowserModule,
        BrowserAnimationsModule,
        ToastModule,
        ToastModule.forRoot(),
        RouterModule.forRoot([
            { path: '', redirectTo: 'home', pathMatch: 'full' },
            { path: 'home', component: HomeComponent },
            { path: 'clients', component: ClientsListComponent },
            { path: 'client/:clientNo', component: ClientComponent },
            { path: 'client', component: ClientComponent },
            { path: 'clientView/:clientNo', component: ClientViewComponent},
            { path: '**', redirectTo: 'home' }
        ])
    ]
})
export class AppModuleShared {
}
