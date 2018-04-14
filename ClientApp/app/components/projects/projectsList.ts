import { Component, Inject } from "@angular/core";
import { Http } from "@angular/http";

@Component({
    selector: "projects",
    templateUrl: "./projectsList.html",
    styleUrls: ['../app/app.component.css']
})
export class ProjectsListComponent {

    private projects: Project[];
    private clients: Client[];
    searchTerm: string = "";

    refreshList() {
        this.http.get(this.baseUrl + "api/ProjectsController/List" + (this.searchTerm ? "/" + this.searchTerm : "")).subscribe(result => {
            this.projects = result.json() as Project[];
        }, error => console.error(error));

        this.http.get(this.baseUrl + "api/ClientsController/List" + (this.searchTerm ? "/" + this.searchTerm : "")).subscribe(result => {
            this.clients = result.json() as Client[];
        }, error => console.error(error));

    }

    constructor(private readonly http: Http, @Inject("BASE_URL") private readonly baseUrl: string) {
        this.refreshList();
        
    }

    getClientNameByID(id: string) {
        return this.clients.find(x => x.no == id);
    }
}

export class Project {
    key: string;
    project_ID: string;
    project_Title: string;
    project_Description: string;
    customer_ID: string;
    customer_name: string;
    pM_User_ID: string;
    project_Status: string;
}


export class Client {
    key: string;
    no: string;
    name: string;
    address: string;
    city: string;
}

