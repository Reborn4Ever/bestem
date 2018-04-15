import { Component, Inject } from "@angular/core";
import { Http } from "@angular/http";

@Component({
    selector: "tasks",
    templateUrl: "./tasksList.html",
    styleUrls: ['../app/app.component.css']
})
export class TasksListComponent {

    private tasks: Task[];
    private projects: Project[];
    private clients: Client[];
    searchTerm: string = "";

    refreshList() {
        this.http.get(this.baseUrl + "api/ClientsController/List" + (this.searchTerm ? "/" + this.searchTerm : "")).subscribe(result => {
            this.clients = result.json() as Client[];
        }, error => console.error(error));

        this.http.get(this.baseUrl + "api/ProjectsController/List" + (this.searchTerm ? "/" + this.searchTerm : "")).subscribe(result => {
            this.projects = result.json() as Project[];
        }, error => console.error(error));

        this.http.get(this.baseUrl + "api/TasksController/List" + (this.searchTerm ? "/" + this.searchTerm : "")).subscribe(result => {
            this.tasks = result.json() as Task[];
        }, error => console.error(error));
        //console.log(this.projects);
       // console.log(this.clients);
       // console.log(this.tasks);
    }

    constructor(private readonly http: Http, @Inject("BASE_URL") private readonly baseUrl: string) {
        this.refreshList();
        
    }

    getClientNameByID(id: string) {
    //    console.log(id);
        return this.clients.find(x => x.no == id);
    }
    getProjectNameByID(id: string) {
        console.log(id);
        return this.projects.find(x => x.project_ID == id);
    }

}

export class Task {
    owner_User_ID: string;
    project_ID: string;
    task_ID: string;
    task_Title: string;    
    task_Description: string;
    task_Status: string;
    priority: string;
    estimated_Analysis_Hours: string;
    estimated_Design_Hours: string;
    estimated_Development_Hours: string;
    estimated_Testing_Hours: string;
    required_Due_Date: string;
    estimated_Analysis_Due_Date: string;
    actual_Analysis_Due_Date: string;
    estimated_Design_Due_Date: string;
    actual_Design_Due_Date: string;
    estimated_Development_Due_Date: string;
    actual_Development_Due_Date: string;
    estimated_Testing_Due_Date: string;
    actual_Testing_Due_Date: string;
    initial_Task_Type: string;
    current_Task_Type: string;
    license_Details: string;
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
