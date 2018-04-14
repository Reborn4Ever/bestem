import { Component, Inject } from "@angular/core";
import { Http, Headers } from "@angular/http";
import { ActivatedRoute } from "@angular/router";
import { Project } from "./projectsList";
import { ToastsManager } from "ng2-toastr";
import "ng2-toastr/ng2-toastr.css";

@Component({
    selector: "project",
    templateUrl: "./projectsEdit.html",
    styleUrls: ["../app/app.component.css"]
})
export class ProjectComponent {

    project: Project;

    loadData(projectproject_Title: string) {
        if (projectproject_Title != "")
            this.http.get(this.baseUrl + "api/ProjectsController/Read/" + projectproject_Title).subscribe(result => {
                this.project = result.json() as Project;
            },
                error => console.error(error));
    }

    save() {
        const headers = new Headers();
        headers.append('Content-Type', 'application/json');
        this.http.post(this.baseUrl + "api/ProjectsController/Save", JSON.stringify(this.project), { headers: headers }).subscribe(result => {
            this.project = result.json() as Project;
            this.toastsManager.info("Proiectul a fost salvat cu succes");
        }, error => console.error(error));
    }

    constructor(private readonly http: Http, @Inject("BASE_URL") private readonly baseUrl: string, private readonly route: ActivatedRoute, private readonly toastsManager: ToastsManager) {
        this.project = new Project();
        route.params.subscribe(params => this.loadData(params["projectproject_Title"]));
    }

}