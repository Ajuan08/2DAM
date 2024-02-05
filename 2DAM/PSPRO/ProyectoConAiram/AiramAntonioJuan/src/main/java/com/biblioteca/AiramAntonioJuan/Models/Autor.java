package com.biblioteca.AiramAntonioJuan.Models;

import com.biblioteca.AiramAntonioJuan.Models.Libro;
import java.util.List;
import jakarta.persistence.*;

@Entity
@Table(name = "autor")
public class Autor {
    @Id
    @GeneratedValue(strategy = GenerationType.IDENTITY)
    private Long id;
    
    private String nombre;

    @OneToMany(mappedBy = "Autor")
    private List<Libro> libros;
}
