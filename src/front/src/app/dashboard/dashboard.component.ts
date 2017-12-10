import { Component, OnInit } from '@angular/core';
import { Observable } from 'rxjs/Observable';
import { Router } from '@angular/router';

@Component({
  selector: 'app-dashboard',
  templateUrl: './dashboard.component.html',
  styleUrls: ['./dashboard.component.css']
})
export class DashboardComponent implements OnInit {

  title = '[sant]AI\'NNOV';
  days = 0;
  hours = 0;
  minutes = 0;
  seconds = 0;

  constructor(private router: Router) { }

  ngOnInit() {
    const countDownDate = new Date(2017, 11, 6, 15, 10, 0, 0).getTime();
    
    Observable
      .interval(1000)
      .subscribe((val) => {
        const distance = Math.abs(countDownDate - new Date().getTime());

        // Time calculations for days, hours, minutes and seconds
        this.days = Math.floor(distance / (1000 * 3600 * 24));
        this.hours = Math.floor((distance % (1000 * 60 * 60 * 24)) / (1000 * 60 * 60));
        this.minutes = Math.floor((distance % (1000 * 60 * 60)) / (1000 * 60));
        this.seconds = Math.floor((distance % (1000 * 60)) / 1000);
      });
  }

  openShop(){
    console.log('activating route');
    this.router.navigate(['/products']);
  }
}
