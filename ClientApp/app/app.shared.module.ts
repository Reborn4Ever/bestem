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
import { TasksListComponent, Task } from "./components/tasks/tasksList";
import { TaskComponent } from "./components/tasks/tasksEdit";
import { TaskViewComponent } from "./components/tasks/tasksView";

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
        ProjectComponent,
        TasksListComponent,
        TaskComponent,
        TaskViewComponent
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
            { path: 'clientView/:clientNo', component: ClientViewComponent },
            { path: 'projects', component: ProjectsListComponent },
            { path: 'project', component: ProjectComponent },
            { path: 'project/:projectproject_Title', component: ProjectComponent },
            { path: 'tasks', component: TasksListComponent },
            { path: 'taskView/:task_ID', component: TaskViewComponent },
            { path: '**', redirectTo: 'home' }
        ])
    ]
})
export class AppModuleShared {
}
