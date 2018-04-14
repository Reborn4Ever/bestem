import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { FormsModule } from '@angular/forms';
import { HttpModule } from '@angular/http';
import { RouterModule } from '@angular/router';

import { AppComponent } from './components/app/app.component';
import { NavMenuComponent } from './components/navmenu/navmenu.component';
import { FooterComponent } from './components/footer/footer.component';
import { HomeComponent } from './components/home/home.component';
import { ClientsListComponent } from "./components/clients/clientsList";
import { ClientComponent } from "./components/clients/clientEdit";
import { ClientViewComponent } from "./components/clients/clientView";
import { ToastModule } from "ng2-toastr";
import { BrowserModule } from "@angular/platform-browser"
import { BrowserAnimationsModule } from "@angular/platform-browser/animations"
import { ProjectsListComponent, Project } from "./components/projects/projectsList";
import { ProjectComponent } from "./components/projects/projectsEdit";

@NgModule({
    declarations: [
        AppComponent,
        NavMenuComponent,
        FooterComponent,
        ClientsListComponent,
        ClientComponent,
        ClientViewComponent,
        HomeComponent,
        ProjectsListComponent,
        ProjectComponent
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
            { path: 'projects', component: ProjectsListComponent },
            { path: 'projects/:projectproject_Title', component: ProjectComponent },
            { path: 'client/:clientNo', component: ClientComponent },
            { path: 'client', component: ClientComponent },
            { path: 'clientView/:clientNo', component: ClientViewComponent},
            { path: '**', redirectTo: 'home' }
        ])
    ]
})
export class AppModuleShared {
}
