import { Component, Inject } from "@angular/core";
import { Http } from "@angular/http";

@Component({
    selector: "projects",
    templateUrl: "./projectsList.html",
    styleUrls: ['../app/app.component.css']
})
export class ProjectsListComponent {

    private projects: Project[];
    searchTerm: string = "";

    refreshList() {
        this.http.get(this.baseUrl + "api/ProjectsController/List" + (this.searchTerm ? "/" + this.searchTerm : "")).subscribe(result => {
            this.projects = result.json() as Project[];
            console.log(this.projects);
        }, error => console.error(error));
    }

    constructor(private readonly http: Http, @Inject("BASE_URL") private readonly baseUrl: string) {
        this.refreshList();
        
    }
}

export class Project {
    key: string;
    project_ID: string;
    project_Title: string;
    project_Description: string;
    customer_ID: string;
    pM_User_ID: string;
    project_Status: string;
}
