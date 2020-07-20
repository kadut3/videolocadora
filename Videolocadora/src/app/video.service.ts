import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';  
import { HttpHeaders } from '@angular/common/http';  
import { Observable } from 'rxjs';  
import { Video } from './video'; 

var httpOptions = {headers: new HttpHeaders({"Content-Type": "application/json"})};

@Injectable({
  providedIn: 'root'
})

export class VideoService {

  url = 'http://localhost:55029/api/FilmesAtributos';  
  constructor(private http: HttpClient) { }
  getAllVideos(): Observable<Video[]> {  
    return this.http.get<Video[]>(this.url);  
  }  
  getVideoById(codVideo: string): Observable<Video> {  
    const apiurl = `${this.url}/${codVideo}`;
    return this.http.get<Video>(apiurl);  
  } 
  createVideo(video: Video): Observable<Video> {  
    return this.http.post<Video>(this.url, video, httpOptions);  
  }  
  updateVideo(codVideo: string, video: Video): Observable<Video> {  
    const apiurl = `${this.url}/${codVideo}`;
    return this.http.put<Video>(apiurl,video, httpOptions);  
  }  
  deleteVideoById(codVideo: string): Observable<number> {  
    const apiurl = `${this.url}/${codVideo}`;
    return this.http.delete<number>(apiurl, httpOptions);  
  }  
}
