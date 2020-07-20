import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';

import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { VideoComponent } from './video/video.component';
import { VideoService } from './video.service';  
import { FormsModule, ReactiveFormsModule } from '@angular/forms';  

import { HttpClientModule, HttpClient } from '@angular/common/http';  

import { MatButtonModule  
} from '@angular/material/button';  

import {  
  MatMenuModule
} from '@angular/material/menu';  

import {  
  MatDatepickerModule  
    } from '@angular/material/datepicker';  

    
import {  
  MatIconModule
} from '@angular/material/icon';

import {  
  MatCardModule  
} from '@angular/material/card';  

import {  
  MatSidenavModule
} from '@angular/material/sidenav';

import {  
  MatFormFieldModule  
} from '@angular/material/form-field';  

import {  
  MatInputModule
} from '@angular/material/input';

import {  
  MatTooltipModule  
} from '@angular/material/tooltip';  

import {  
  MatToolbarModule
} from '@angular/material/toolbar';

import { MatRadioModule } from '@angular/material/radio';  
import { BrowserAnimationsModule } from '@angular/platform-browser/animations';

@NgModule({
  declarations: [
    AppComponent,
    VideoComponent
  ],
  imports: [
    BrowserModule,
    FormsModule,  
    ReactiveFormsModule,  
    HttpClientModule,  
    BrowserAnimationsModule,  
    MatButtonModule,  
    MatMenuModule,  
    MatDatepickerModule,  
    MatIconModule,  
    MatRadioModule,  
    MatCardModule,  
    MatSidenavModule,  
    MatFormFieldModule,  
    MatInputModule,  
    MatTooltipModule,  
    MatToolbarModule,  
    AppRoutingModule
  ],
  providers: [HttpClientModule, VideoService, MatDatepickerModule],
  bootstrap: [AppComponent]
})
export class AppModule { }
