import { Component, Inject } from "@angular/core";
import { Http, Headers } from "@angular/http";
import { ActivatedRoute } from "@angular/router";
import { Task } from "./tasksList";
import { ToastsManager } from "ng2-toastr";
import "ng2-toastr/ng2-toastr.css";

@Component({
    selector: "task",
    templateUrl: "./tasksEdit.html",
    styleUrls: ["../app/app.component.css"]
})
export class TaskComponent {

    task: Task;

    loadData(task_ID: string) {
        if (task_ID != null)
            this.http.get(this.baseUrl + "api/TasksController/Read/" + task_ID).subscribe(result => {
                this.task = result.json() as Task;
            },
                error => console.error(error));
    }

    save() {
        const headers = new Headers();
        headers.append('Content-Type', 'application/json');
        console.log(this.task);
        this.http.post(this.baseUrl + "api/TasksController/Save", JSON.stringify(this.task), { headers: headers }).subscribe(result => {
            this.task = result.json() as Task;
            this.toastsManager.info("Task-ul a fost adaugat cu succes");
        }, error => console.error(error));
    }

    constructor(private readonly http: Http, @Inject("BASE_URL") private readonly baseUrl: string, private readonly route: ActivatedRoute, private readonly toastsManager: ToastsManager) {
        this.task = new Task();
        route.params.subscribe(params => this.loadData(params["task_ID"]));
    }

}