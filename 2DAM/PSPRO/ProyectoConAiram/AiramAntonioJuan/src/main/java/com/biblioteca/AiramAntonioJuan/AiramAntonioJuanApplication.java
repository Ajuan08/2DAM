package com.biblioteca.AiramAntonioJuan;

import Controllers.LibrosController;
import org.springframework.boot.SpringApplication;
import org.springframework.boot.autoconfigure.SpringBootApplication;
import org.springframework.web.bind.annotation.GetMapping;
import org.springframework.web.bind.annotation.RestController;

@SpringBootApplication
@RestController
public class AiramAntonioJuanApplication {

    @GetMapping("/hola")
    public String hola(){
        return "Hola Mundo";
    }
    public static void main(String[] args) {
        SpringApplication.run(AiramAntonioJuanApplication.class, args);
        
        LibrosController libros = new LibrosController();
    }

    
}
