import { Component, Inject } from "@angular/core";
import { Http } from "@angular/http";

@Component({
    selector: "tasks",
    templateUrl: "./tasksList.html",
    styleUrls: ['../app/app.component.css']
})
export class TasksListComponent {

    private tasks: Task[];
    searchTerm: string = "";

    refreshList() {
        this.http.get(this.baseUrl + "api/TasksController/List" + (this.searchTerm ? "/" + this.searchTerm : "")).subscribe(result => {
            this.tasks = result.json() as Task[];
        }, error => console.error(error));
    }

    constructor(private readonly http: Http, @Inject("BASE_URL") private readonly baseUrl: string) {
        this.refreshList();
        
    }
}

export class Task {
    user_ID: string;
    project_ID: string;
    task_ID: string;
    task_Title: string;    
    task_Description: string;
    task_Status: string;
    priority: string;
}
