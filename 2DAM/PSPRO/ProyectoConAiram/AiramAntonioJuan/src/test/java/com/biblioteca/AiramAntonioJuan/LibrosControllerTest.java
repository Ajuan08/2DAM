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
        // Simulamos datos de libros
        Libro libro1 = new Libro();
        libro1.setId(1L);
        libro1.setTitulo("Libro 1");

        Libro libro2 = new Libro();
        libro2.setId(2L);
        libro2.setTitulo("Libro 2");

        List<Libro> libros = Arrays.asList(libro1, libro2);

        // Configuramos el comportamiento del mock para el método findAll
        when(libroRepository.findAll()).thenReturn(libros);

        // Realizamos la solicitud HTTP y verificamos el resultado
        mockMvc.perform(get("/api/libros"))
                .andExpect(status().isOk()) // Esperamos que la respuesta sea OK (código de estado 200)
                .andExpect(content().contentType(MediaType.APPLICATION_JSON)) // Esperamos que el tipo de contenido sea JSON
                .andExpect(jsonPath("$[0].titulo").value("Libro 1")) // Esperamos que el primer libro tenga el título "Libro 1"
                .andExpect(jsonPath("$[1].titulo").value("Libro 2")); // Esperamos que el segundo libro tenga el título "Libro 2"
    }

    @Test
    public void testGetLibroById() throws Exception {
        // Simulamos un libro existente con ID 1
        Libro libro = new Libro();
        libro.setId(1L);
        libro.setTitulo("Libro Existente");

        // Configuramos el comportamiento del mock para el método findById
        when(libroRepository.findById(1L)).thenReturn(java.util.Optional.of(libro));

        // Realizamos la solicitud HTTP y verificamos el resultado
        mockMvc.perform(get("/api/libros/1"))
                .andExpect(status().isOk()) // Esperamos que la respuesta sea OK (código de estado 200)
                .andExpect(content().contentType(MediaType.APPLICATION_JSON)) // Esperamos que el tipo de contenido sea JSON
                .andExpect(jsonPath("$.titulo").value("Libro Existente")); // Esperamos que el libro tenga el título "Libro Existente"
    }

    @Test
    public void testCreateLibro() throws Exception {
        // Simulamos un nuevo libro a crear
        Libro nuevoLibro = new Libro();
        nuevoLibro.setId(3L);
        nuevoLibro.setTitulo("Nuevo Libro");

        // Configuramos el comportamiento del mock para el método save
        when(libroRepository.save(any(Libro.class))).thenReturn(nuevoLibro);

        // Realizamos la solicitud HTTP y verificamos el resultado
        mockMvc.perform(post("/api/libros")
                .contentType(MediaType.APPLICATION_JSON)
                .content("{\"id\":3,\"titulo\":\"Nuevo Libro\"}")) // Enviamos el libro como JSON en el cuerpo de la solicitud
                .andExpect(status().isOk()) // Esperamos que la respuesta sea OK (código de estado 200)
                .andExpect(content().contentType(MediaType.APPLICATION_JSON)) // Esperamos que el tipo de contenido sea JSON
                .andExpect(jsonPath("$.titulo").value("Nuevo Libro")); // Esperamos que el libro creado tenga el título "Nuevo Libro"
    }

    @Test
    public void testUpdateLibro() throws Exception {
        // Simulamos un libro existente con ID 1
        Libro libroExistente = new Libro();
        libroExistente.setId(1L);
        libroExistente.setTitulo("Libro Existente");

        // Configuramos el comportamiento del mock para el método findById
        when(libroRepository.findById(1L)).thenReturn(java.util.Optional.of(libroExistente));

        // Simulamos el libro actualizado
        Libro libroActualizado = new Libro();
        libroActualizado.setId(1L);
        libroActualizado.setTitulo("Libro Actualizado");

        // Configuramos el comportamiento del mock para el método save
        when(libroRepository.save(any(Libro.class))).thenReturn(libroActualizado);

        // Realizamos la solicitud HTTP y verificamos el resultado
        mockMvc.perform(put("/api/libros/1")
                .contentType(MediaType.APPLICATION_JSON)
                .content("{\"id\":1,\"titulo\":\"Libro Actualizado\"}")) // Enviamos el libro actualizado como JSON en el cuerpo de la solicitud
                .andExpect(status().isOk()) // Esperamos que la respuesta sea OK (código de estado 200)
                .andExpect(content().contentType(MediaType.APPLICATION_JSON)) // Esperamos que el tipo de contenido sea JSON
                .andExpect(jsonPath("$.titulo").value("Libro Actualizado")); // Esperamos que el libro actualizado tenga el título "Libro Actualizado"
    }

    @Test
    public void testDeleteLibro() throws Exception {
        // Realizamos la solicitud HTTP de eliminación y verificamos el resultado
        mockMvc.perform(delete("/api/libros/1"))
                .andExpect(status().isOk()); // Esperamos que la respuesta sea OK (código de estado 200)
    }
}