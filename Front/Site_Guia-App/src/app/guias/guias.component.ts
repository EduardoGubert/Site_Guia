import { HttpClient } from '@angular/common/http';
import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'app-guias',
  templateUrl: './guias.component.html',
  styleUrls: ['./guias.component.scss']
})
export class GuiasComponent implements OnInit {

  public guias: any;

  constructor(private http: HttpClient) { }

  ngOnInit(): void {
    this.getSites();
  }

  public getSites(): void {

    this.http.get('https://localhost:5001/Site').subscribe(
      response => this.guias = response,
      error => console.log(error)
    )

  }

}
