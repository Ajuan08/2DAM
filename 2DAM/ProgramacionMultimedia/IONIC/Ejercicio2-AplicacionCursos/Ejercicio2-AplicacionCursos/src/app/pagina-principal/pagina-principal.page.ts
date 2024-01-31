import { Component, OnInit } from '@angular/core';
import { Observable } from 'rxjs';

@Component({
  selector: 'app-pagina-principal',
  templateUrl: './pagina-principal.page.html',
  styleUrls: ['./pagina-principal.page.scss'],
})
export class MainPagePage implements OnInit {
  observable: Observable<any>;

  constructor(private coursesService: CoursesService) { 
    this.observable = coursesService.getObservable();
  }

  ngOnInit() {
  }

  addCourse(course: any): void {
    this.coursesService.addCourse(course);
  }

}
