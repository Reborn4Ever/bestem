import { Component, Inject } from "@angular/core";
import { Http } from "@angular/http";
import { ActivatedRoute } from "@angular/router";
import { Project } from "./projectsList";

@Component({
    selector: "projectView",
    templateUrl: "./projectsView.html",
    styleUrls: ["../app/app.component.css"]
})
export class ProjectViewComponent {

    project: Project;

    loadData(projectproject_ID: string) {
        if (projectproject_ID != null)
            this.http.get(this.baseUrl + "api/ProjectsController/Read/" + projectproject_ID).subscribe(result => {
                this.project = result.json() as Project;
            },
                error => console.error(error));
    }

    constructor(private readonly http: Http, @Inject("BASE_URL") private readonly baseUrl: string, private readonly route: ActivatedRoute) {
        this.project = new Project();
        route.params.subscribe(params => this.loadData(params["projectproject_ID"]));
    }

}