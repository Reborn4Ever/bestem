import { Component, Inject } from "@angular/core";
import { Http, Headers } from "@angular/http";
import { ActivatedRoute } from "@angular/router";
import { Client } from "./clientsList";
import { ToastsManager } from "ng2-toastr";
import "ng2-toastr/ng2-toastr.css";

@Component({
    selector: "client",
    templateUrl: "./clientEdit.html",
    styleUrls: ["../app/app.component.css"]
})
export class ClientComponent {

    client: Client;

    loadData(clientNo: string) {
        if (clientNo != null)
            this.http.get(this.baseUrl + "api/ClientsController/Read/" + clientNo).subscribe(result => {
                    this.client = result.json() as Client;
                },
                error => console.error(error));
    }

    save() {
        const headers = new Headers();
        headers.append('Content-Type', 'application/json');
        this.http.post(this.baseUrl + "api/ClientsController/Save", JSON.stringify(this.client), { headers: headers }).subscribe(result => {
            this.client = result.json() as Client;
            this.toastsManager.info("Clientul a fost salvat cu succes");
        }, error => console.error(error));
    }

    constructor(private readonly http: Http, @Inject("BASE_URL") private readonly baseUrl: string, private readonly route: ActivatedRoute, private readonly  toastsManager: ToastsManager) {
        this.client = new Client();
        route.params.subscribe(params => this.loadData(params["clientNo"]));
    }

}