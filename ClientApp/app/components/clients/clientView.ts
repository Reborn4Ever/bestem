import { Component, Inject } from "@angular/core";
import { Http} from "@angular/http";
import { ActivatedRoute } from "@angular/router";
import { Client } from "./clientsList";

@Component({
    selector: "clientView",
    templateUrl: "./clientView.html",
    styleUrls: ["../app/app.component.css"]
})
export class ClientViewComponent {

    client: Client;

    loadData(clientNo: string) {
        if (clientNo != null)
            this.http.get(this.baseUrl + "api/ClientsController/Read/" + clientNo).subscribe(result => {
                    this.client = result.json() as Client;
                },
                error => console.error(error));
    }

    constructor(private readonly http: Http, @Inject("BASE_URL") private readonly baseUrl: string, private readonly route: ActivatedRoute) {
        this.client = new Client();
        route.params.subscribe(params => this.loadData(params["clientNo"]));
    }

}