import { APP_BOOTSTRAP_LISTENER, NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
// import { appendFile } from 'fs';
import { AboutComponent } from './about/about.component';
import { AppComponent } from './app.component';


const routes: Routes = [
  { path: 'about', component: AboutComponent },
  // { path: '/', component: AppComponent },
  { path: '', redirectTo: '/', pathMatch: 'full' }
];



@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
