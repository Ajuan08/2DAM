/*
 * Click nbfs://nbhost/SystemFileSystem/Templates/Licenses/license-default.txt to change this license
 * Click nbfs://nbhost/SystemFileSystem/Templates/Classes/Class.java to edit this template
 */
package com.biblioteca.AiramAntonioJuan;

/**
 *
 * @author anton
 */
import com.biblioteca.AiramAntonioJuan.Controllers.LibrosController;
import com.biblioteca.AiramAntonioJuan.Models.Libro;
import com.biblioteca.AiramAntonioJuan.Interfaces.LibroRepositorio;
import org.junit.jupiter.api.BeforeEach;
import org.junit.jupiter.api.Test;
import org.junit.jupiter.api.extension.ExtendWith;
import org.mockito.InjectMocks;
import org.mockito.Mock;
import org.mockito.MockitoAnnotations;
import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.boot.test.autoconfigure.web.servlet.AutoConfigureMockMvc;
import org.springframework.boot.test.context.SpringBootTest;
import org.springframework.http.MediaType;
import org.springframework.test.context.junit.jupiter.SpringExtension;
import org.springframework.test.web.servlet.MockMvc;
import org.springframework.test.web.servlet.setup.MockMvcBuilders;

import java.util.Arrays;
import java.util.List;

import static org.mockito.Mockito.*;
import static org.springframework.test.web.servlet.request.MockMvcRequestBuilders.*;
import static org.springframework.test.web.servlet.result.MockMvcResultMatchers.*;

@ExtendWith(SpringExtension.class)
@SpringBootTest
@AutoConfigureMockMvc
public class LibrosControllerTest {

    @Autowired
    private MockMvc mockMvc;

    @Mock
    private LibroRepositorio libroRepository;

    @InjectMocks
    private LibrosController librosController;

    @BeforeEach
    public void setUp() {
        MockitoAnnotations.initMocks(this);
        mockMvc = MockMvcBuilders.standaloneSetup(librosController).build();
    }

    @Test
    public void testGetAllLibros() throws Exception {
        
        Libro libro1 = new Libro();
        libro1.setId(1L);
        libro1.setTitulo("Libro 1");

        Libro libro2 = new Libro();
        libro2.setId(2L);
        libro2.setTitulo("Libro 2");

        List<Libro> libros = Arrays.asList(libro1, libro2);

        when(libroRepository.findAll()).thenReturn(libros);

        mockMvc.perform(get("/api/libros"))
                .andExpect(status().isOk()) 
                .andExpect(content().contentType(MediaType.APPLICATION_JSON)) 
                .andExpect(jsonPath("$[0].titulo").value("Libro 1")) 
                .andExpect(jsonPath("$[1].titulo").value("Libro 2")); 
    }

    @Test
    public void testGetLibroById() throws Exception {
        
        Libro libro = new Libro();
        libro.setId(1L);
        libro.setTitulo("Libro Existente");

        when(libroRepository.findById(1L)).thenReturn(java.util.Optional.of(libro));

        mockMvc.perform(get("/api/libros/1"))
                .andExpect(status().isOk()) 
                .andExpect(content().contentType(MediaType.APPLICATION_JSON)) 
                .andExpect(jsonPath("$.titulo").value("Libro Existente")); 
    }

    @Test
    public void testCreateLibro() throws Exception {
        
        Libro nuevoLibro = new Libro();
        nuevoLibro.setId(3L);
        nuevoLibro.setTitulo("Nuevo Libro");

        when(libroRepository.save(any(Libro.class))).thenReturn(nuevoLibro);

        mockMvc.perform(post("/api/libros")
                .contentType(MediaType.APPLICATION_JSON)
                .content("{\"id\":3,\"titulo\":\"Nuevo Libro\"}")) 
                .andExpect(status().isOk()) 
                .andExpect(content().contentType(MediaType.APPLICATION_JSON)) 
                .andExpect(jsonPath("$.titulo").value("Nuevo Libro")); 
    }

    @Test
    public void testUpdateLibro() throws Exception {
        
        Libro libroExistente = new Libro();
        libroExistente.setId(1L);
        libroExistente.setTitulo("Libro Existente");

        when(libroRepository.findById(1L)).thenReturn(java.util.Optional.of(libroExistente));

        Libro libroActualizado = new Libro();
        libroActualizado.setId(1L);
        libroActualizado.setTitulo("Libro Actualizado");

        when(libroRepository.save(any(Libro.class))).thenReturn(libroActualizado);

        mockMvc.perform(put("/api/libros/1")
                .contentType(MediaType.APPLICATION_JSON)
                .content("{\"id\":1,\"titulo\":\"Libro Actualizado\"}")) 
                .andExpect(status().isOk()) 
                .andExpect(content().contentType(MediaType.APPLICATION_JSON)) 
                .andExpect(jsonPath("$.titulo").value("Libro Actualizado")); 
    }

    @Test
    public void testDeleteLibro() throws Exception {
        mockMvc.perform(delete("/api/libros/1"))
                .andExpect(status().isOk());
    }
}