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


}