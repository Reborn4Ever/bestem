import { Component, Inject } from "@angular/core";
import { Http } from "@angular/http";

@Component({
    selector: "clients",
    templateUrl: "./clientsList.html",
    styleUrls: ['../app/app.component.css']
})
export class ClientsListComponent {

    private clients: Client[];
    searchTerm: string = "";

    refreshList() {
        this.http.get(this.baseUrl + "api/ClientsController/List" + (this.searchTerm ? "/" + this.searchTerm : "")).subscribe(result => {
            this.clients = result.json() as Client[];
        }, error => console.error(error));
    }

    constructor(private readonly http: Http, @Inject("BASE_URL") private readonly baseUrl: string) {
        this.refreshList();
    }
}

export class Client {
    key: string;
    no: string;
    name: string;
    address: string;
    city: string;
}
