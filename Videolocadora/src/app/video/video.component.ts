import { Component, OnInit } from '@angular/core';
import { FormBuilder, Validators } from '@angular/forms';  
import { Observable } from 'rxjs';  
import { VideoService } from '../video.service';  
import { Video } from '../video';  

@Component({
  selector: 'app-video',
  templateUrl: './video.component.html',
  styleUrls: ['./video.component.css']
})

export class VideoComponent implements OnInit {

  dataSaved = false;  
  videoForm: any;  
  allVideos: Observable<Video[]>;  
  codVideoUpdate = null;  
  message = null;  
  
  constructor(private formbulider: FormBuilder, private videoService:VideoService) { }

  ngOnInit() {
    this.videoForm = this.formbulider.group({  
      Nome: ['', [Validators.required]]  
        
    });  
    this.loadAllVideos();  
  }

  loadAllVideos() {  
    this.allVideos = this.videoService.getAllVideos();  
  } 

  onFormSubmit() {  
    this.dataSaved = false;  
    const video = this.videoForm.value;  
    this.CreateVideo(video);  
    this.videoForm.reset();  
  } 

  CreateVideo(video: Video) {  
    if (this.codVideoUpdate == null) {  
      this.videoService.createVideo(video).subscribe(  
        () => {  
          this.dataSaved = true;  
          this.message = 'Registro salvo com sucesso';  
          this.loadAllVideos();  
          this.codVideoUpdate = null;  
          this.videoForm.reset();  
        }  
      );  
    } else {  
      video.codFilme = this.codVideoUpdate;  
      this.videoService.updateVideo(this.codVideoUpdate,video).subscribe(() => {  
        this.dataSaved = true;  
        this.message = 'Registro atualizado com sucesso';  
        this.loadAllVideos();  
        this.codVideoUpdate = null;  
        this.videoForm.reset();  
      });  
    }   
  }  

  loadVideoToEdit(codFilme: string) {  
    this.videoService.getVideoById(codFilme).subscribe(video=> {  
      this.message = null;  
      this.dataSaved = false;  
      this.codVideoUpdate = video.codFilme;  
      this.videoForm.controls['Nome'].setValue(video.nome);  
      this.videoForm.controls['Genero'].setValue(video.genero);
      this.videoForm.controls['Lancamento'].setValue(video.anoLancamento);
      this.videoForm.controls['Imagem'].setValue(video.imagem);
      this.videoForm.controls['Classificacao'].setValue(video.classificacao);
      this.videoForm.controls['Observacao'].setValue(video.observacao);
      this.videoForm.controls['Ativo'].setValue(video.ativo);
      this.videoForm.controls['DataCadastro'].setValue(video.dataCadastro);
    });    
  }
  
  deleteAluno(codFilme: string) {  
    if (confirm("Deseja realmente deletar este filme ?")) {   
      this.videoService.deleteVideoById(codFilme).subscribe(() => {  
        this.dataSaved = true;  
        this.message = 'Registro deletado com sucesso';  
        this.loadAllVideos();  
        this.codVideoUpdate = null;  
        this.videoForm.reset();  
      });  
    }  
  }  


  resetForm() {  
    this.videoForm.reset();  
    this.message = null;  
    this.dataSaved = false;  
  } 

  





}
