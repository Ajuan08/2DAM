/*
 * Click nbfs://nbhost/SystemFileSystem/Templates/Licenses/license-default.txt to change this license
 * Click nbfs://nbhost/SystemFileSystem/Templates/Classes/Class.java to edit this template
 */
package Controllers;

import Models.Libro;
import Servicios.LibroService;
import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.web.bind.annotation.PostMapping;
import org.springframework.web.bind.annotation.RequestBody;
import org.springframework.web.bind.annotation.RequestMapping;
import org.springframework.web.bind.annotation.RestController;

/**
 *
 * @author airam_fckw728
 */

@RestController
@RequestMapping("/api/libros")
public class LibrosController {
    
    @Autowired
    private LibroService libroService;
    
    @PostMapping("/agregar")
    public Libro agregarLibro(@RequestBody Libro libro) {
        // Llama al servicio para agregar el libro
        return libroService.agregarLibro(libro);
    }
}
