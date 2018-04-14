import { Component, Inject } from "@angular/core";
import { Http } from "@angular/http";
import { ActivatedRoute } from "@angular/router";
import { Task } from "./tasksList";

@Component({
    selector: "taskView",
    templateUrl: "./tasksView.html",
    styleUrls: ["../app/app.component.css"]
})
export class TaskViewComponent {

    task: Task;

    loadData(task_ID: string) {
        if (task_ID != null)
            this.http.get(this.baseUrl + "api/TasksController/Read/" + task_ID).subscribe(result => {
                this.task = result.json() as Task;
            },
                error => console.error(error));
    }

    constructor(private readonly http: Http, @Inject("BASE_URL") private readonly baseUrl: string, private readonly route: ActivatedRoute) {
        this.task = new Task();
        route.params.subscribe(params => this.loadData(params["task_ID"]));
    }

}