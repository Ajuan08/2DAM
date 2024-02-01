/*
 * Click nbfs://nbhost/SystemFileSystem/Templates/Licenses/license-default.txt to change this license
 * Click nbfs://nbhost/SystemFileSystem/Templates/Classes/Class.java to edit this template
 */
package Servicios;

import Interfaces.LibroRepositorio;
import Models.Libro;
import java.util.List;
import java.util.stream.Collectors;
import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.stereotype.Service;

/**
 *
 * @author airam_fckw728
 */
@Service
public class LibroService {
    
    @Autowired
    private LibroRepositorio libroRepo;
    
    public Libro agregarLibro(Libro libro) {
        // Utiliza el método save del repositorio para guardar el nuevo libro
        return libroRepo.save(libro);
    }
    
     public List<Libro> obtenerLibrosDTO() {
        List<Libro> libros = libroRepo.findAll();

        // Convierte la lista de libros a una lista de Libro
        return libros.stream()
                .collect(Collectors.toList());
    }
}
