package com.biblioteca.AiramAntonioJuan;

import org.springframework.boot.SpringApplication;
import org.springframework.boot.autoconfigure.SpringBootApplication;
import org.springframework.data.jpa.repository.config.EnableJpaRepositories;

@SpringBootApplication
@EnableJpaRepositories
public class AiramAntonioJuanApplication {
    
    public static void main(String[] args) {
        SpringApplication.run(AiramAntonioJuanApplication.class, args);
    }
}
