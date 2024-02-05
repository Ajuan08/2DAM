/*
 * Click nbfs://nbhost/SystemFileSystem/Templates/Licenses/license-default.txt to change this license
 * Click nbfs://nbhost/SystemFileSystem/Templates/Classes/Class.java to edit this template
 */
package com.biblioteca.AiramAntonioJuan.Controllers;

import com.biblioteca.AiramAntonioJuan.Interfaces.AutorRepository;
import com.biblioteca.AiramAntonioJuan.Interfaces.LibroRepositorio;
import com.biblioteca.AiramAntonioJuan.Models.Autor;
import com.biblioteca.AiramAntonioJuan.Models.Libro;
import java.util.List;
import jakarta.persistence.*;
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
 * @author dam
 */
@RestController
@RequestMapping("/api/autor")
public class AutorController {

    @Autowired
    private AutorRepository autorRepository;

    @GetMapping
    public List<Autor> getAll() {
        return autorRepository.findAll();
    }

    @GetMapping("/{id}")
    public Autor getById(@PathVariable Long id) throws Exception {
        return autorRepository.findById(id).orElseThrow(() -> new Exception("Autor no encontrado"));
    }

    @PostMapping
    public Autor create(@RequestBody Autor autor) {
        return autorRepository.save(autor);
    }

    @PutMapping("/{id}")
    public Autor update(@PathVariable Long id, @RequestBody Autor autor) throws Exception {
        Autor autorToUpdate = autorRepository.findById(id).orElseThrow(() -> new Exception("Autor no encontrado"));
//        libroToUpdate.setTitulo(libro.getTitulo());
//        libroToUpdate.setAutor(libro.getAutor());
        // ...
        return autorRepository.save(autorToUpdate);
    }

    @DeleteMapping("/{id}")
    public void delete(@PathVariable Long id) {
        autorRepository.deleteById(id);
    }
}
