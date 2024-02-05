/*
 * Click nbfs://nbhost/SystemFileSystem/Templates/Licenses/license-default.txt to change this license
 * Click nbfs://nbhost/SystemFileSystem/Templates/Classes/Class.java to edit this template
 */
package com.biblioteca.AiramAntonioJuan.Controllers;

import com.biblioteca.AiramAntonioJuan.Interfaces.AutorRepository;
import com.biblioteca.AiramAntonioJuan.Interfaces.CategoriaRepository;
import com.biblioteca.AiramAntonioJuan.Models.Autor;
import com.biblioteca.AiramAntonioJuan.Models.Categoria;
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
 * @author anton
 */
@RestController
@RequestMapping("/api/categoria")
public class CategoriaController {

    @Autowired
    private CategoriaRepository categoriaRepository;

    @GetMapping
    public List<Categoria> getAll() {
        return categoriaRepository.findAll();
    }

    @GetMapping("/{id}")
    public Categoria getById(@PathVariable Long id) throws Exception {
        return categoriaRepository.findById(id).orElseThrow(() -> new Exception("Categoria no encontrado"));
    }

    @PostMapping
    public Categoria create(@RequestBody Categoria categoria) {
        return categoriaRepository.save(categoria);
    }

    @PutMapping("/{id}")
    public Categoria update(@PathVariable Long id, @RequestBody Categoria categoria) throws Exception {
        Categoria categoriaToUpdate = categoriaRepository.findById(id).orElseThrow(() -> new Exception("Categoria no encontrado"));
//        categoriaRepository.setTitulo(libro.getTitulo());
//        categoriaRepository.setAutor(libro.getAutor());
        // ...
        return categoriaRepository.save(categoriaToUpdate);
    }

    @DeleteMapping("/{id}")
    public void delete(@PathVariable Long id) {
        categoriaRepository.deleteById(id);
    }
}
