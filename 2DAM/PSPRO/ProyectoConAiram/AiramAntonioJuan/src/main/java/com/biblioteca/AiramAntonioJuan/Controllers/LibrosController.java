/*
 * Click nbfs://nbhost/SystemFileSystem/Templates/Licenses/license-default.txt to change this license
 * Click nbfs://nbhost/SystemFileSystem/Templates/Classes/Class.java to edit this template
 */
package com.biblioteca.AiramAntonioJuan.Controllers;

import com.biblioteca.AiramAntonioJuan.Interfaces.LibroRepositorio;
import com.biblioteca.AiramAntonioJuan.Models.Libro;
import java.util.List;
import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.web.bind.annotation.DeleteMapping;
import org.springframework.web.bind.annotation.GetMapping;
import org.springframework.web.bind.annotation.PathVariable;
import org.springframework.web.bind.annotation.PostMapping;
import org.springframework.web.bind.annotation.PutMapping;
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
    private LibroRepositorio libroRepository;

    @GetMapping
    public List<Libro> getAll() {
        return libroRepository.findAll();
    }

    @GetMapping("/{id}")
    public Libro getById(@PathVariable Long id) throws Exception {
        return libroRepository.findById(id).orElseThrow(() -> new Exception("Libro no encontrado"));
    }

    @PostMapping
    public Libro create(@RequestBody Libro libro) {
        return libroRepository.save(libro);
    }

    @PutMapping("/{id}")
    public Libro update(@PathVariable Long id, @RequestBody Libro libro) throws Exception {
        Libro libroToUpdate = libroRepository.findById(id).orElseThrow(() -> new Exception("Libro no encontrado"));
//        libroToUpdate.setTitulo(libro.getTitulo());
//        libroToUpdate.setAutor(libro.getAutor());
        // ...
        return libroRepository.save(libroToUpdate);
    }

    @DeleteMapping("/{id}")
    public void delete(@PathVariable Long id) {
        libroRepository.deleteById(id);
    }
}
