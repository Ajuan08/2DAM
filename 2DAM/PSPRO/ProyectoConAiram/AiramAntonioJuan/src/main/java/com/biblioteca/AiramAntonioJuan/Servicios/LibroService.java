/*
 * Click nbfs://nbhost/SystemFileSystem/Templates/Licenses/license-default.txt to change this license
 * Click nbfs://nbhost/SystemFileSystem/Templates/Classes/Class.java to edit this template
 */
package com.biblioteca.AiramAntonioJuan.Servicios;

import com.biblioteca.AiramAntonioJuan.Interfaces.LibroRepositorio;
import com.biblioteca.AiramAntonioJuan.Models.Libro;
import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.stereotype.Service;

/**
 *
 * @author airam_fckw728
 */
@Service
public class LibroService {
    
    @Autowired
    private static LibroRepositorio libroRepo;
    
    public static Libro agregarLibro(Libro libro) {
        // Utiliza el método save del repositorio para guardar el nuevo libro
        return libroRepo.save(libro);
    }
}
