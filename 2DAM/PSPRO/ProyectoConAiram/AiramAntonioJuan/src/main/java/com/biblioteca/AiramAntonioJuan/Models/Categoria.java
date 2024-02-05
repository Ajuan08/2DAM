package com.biblioteca.AiramAntonioJuan.Models;

import com.biblioteca.AiramAntonioJuan.Models.Libro;
import jakarta.persistence.*;
import java.util.List;

@Entity
public class Categoria {
    @Id
    @GeneratedValue(strategy = GenerationType.IDENTITY)
    private Long id;

    private String nombre;
    
    @ManyToMany
    @JoinTable (
        name = "categoria_libros",
        joinColumns = @JoinColumn (name = "id_categoria"),
        inverseJoinColumns = @JoinColumn (name = "id_libros")
    
    )
    private List<Libro>libros;
    // Constructores, getters, setters, etc.
}

