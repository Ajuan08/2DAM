/*
 * Click nbfs://nbhost/SystemFileSystem/Templates/Licenses/license-default.txt to change this license
 * Click nbfs://nbhost/SystemFileSystem/Templates/Classes/Class.java to edit this template
 */
package com.biblioteca.AiramAntonioJuan;

/**
 *
 * @author anton
 */
import com.biblioteca.AiramAntonioJuan.Controllers.AutorController;
import com.biblioteca.AiramAntonioJuan.Models.Autor;
import com.biblioteca.AiramAntonioJuan.Interfaces.AutorRepository;
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
import java.util.Optional;

import static org.mockito.Mockito.*;
import static org.springframework.test.web.servlet.request.MockMvcRequestBuilders.*;
import static org.springframework.test.web.servlet.result.MockMvcResultMatchers.*;

@ExtendWith(SpringExtension.class)
@SpringBootTest
@AutoConfigureMockMvc
public class AutorControllerTest {

    @Autowired
    private MockMvc mockMvc;

    @Mock
    private AutorRepository autorRepository;

    @InjectMocks
    private AutorController autorController;

    @BeforeEach
    public void setUp() {
        MockitoAnnotations.initMocks(this);
        mockMvc = MockMvcBuilders.standaloneSetup(autorController).build();
    }

    @Test
    public void testGetAllAutores() throws Exception {
        // Simulamos datos de autores
        Autor autor1 = new Autor();
        autor1.setId(1L);
        autor1.setNombre("Autor 1");

        Autor autor2 = new Autor();
        autor2.setId(2L);
        autor2.setNombre("Autor 2");

        List<Autor> autores = Arrays.asList(autor1, autor2);

        // Configuramos el comportamiento del mock para el método findAll
        when(autorRepository.findAll()).thenReturn(autores);

        // Realizamos la solicitud HTTP y verificamos el resultado
        mockMvc.perform(get("/api/autores"))
                .andExpect(status().isOk()) // Esperamos que la respuesta sea OK (código de estado 200)
                .andExpect(content().contentType(MediaType.APPLICATION_JSON)) // Esperamos que el tipo de contenido sea JSON
                .andExpect(jsonPath("$[0].nombre").value("Autor 1")) // Esperamos que el primer autor tenga el nombre "Autor 1"
                .andExpect(jsonPath("$[1].nombre").value("Autor 2")); // Esperamos que el segundo autor tenga el nombre "Autor 2"
    }

    @Test
    public void testGetAutorById() throws Exception {
        // Simulamos un autor existente con ID 1
        Autor autor = new Autor();
        autor.setId(1L);
        autor.setNombre("Antonio Juan");

        // Configuramos el comportamiento del mock para el método findById
        when(autorRepository.findById(1L)).thenReturn(Optional.of(autor));

        // Realizamos la solicitud HTTP y verificamos el resultado
        mockMvc.perform(get("/api/autores/1"))
                .andExpect(status().isOk()) // Esperamos que la respuesta sea OK (código de estado 200)
                .andExpect(content().contentType(MediaType.APPLICATION_JSON)) // Esperamos que el tipo de contenido sea JSON
                .andExpect(jsonPath("$.nombre").value("Antonio Juan")); // Esperamos que el autor tenga el nombre "Autor 1"
    }

    @Test
    public void testCreateAutor() throws Exception {
        // Simulamos un nuevo autor a crear
        Autor nuevoAutor = new Autor();
        nuevoAutor.setId(3L);
        nuevoAutor.setNombre("Airam");

        // Configuramos el comportamiento del mock para el método save
        when(autorRepository.save(any(Autor.class))).thenReturn(nuevoAutor);

        // Realizamos la solicitud HTTP y verificamos el resultado
        mockMvc.perform(post("/api/autores")
                .contentType(MediaType.APPLICATION_JSON)
                .content("{\"id\":3,\"nombre\":\"Nuevo Autor\"}")) // Enviamos el autor como JSON en el cuerpo de la solicitud
                .andExpect(status().isOk()) // Esperamos que la respuesta sea OK (código de estado 200)
                .andExpect(content().contentType(MediaType.APPLICATION_JSON)) // Esperamos que el tipo de contenido sea JSON
                .andExpect(jsonPath("$.nombre").value("Airam")); // Esperamos que el autor creado tenga el nombre "Nuevo Autor"
    }

    @Test
    public void testUpdateAutor() throws Exception {
        // Simulamos un autor existente con ID 1
        Autor autorExistente = new Autor();
        autorExistente.setId(1L);
        autorExistente.setNombre("Autor Existente");

        // Configuramos el comportamiento del mock para el método findById
        when(autorRepository.findById(1L)).thenReturn(Optional.of(autorExistente));

        // Simulamos el autor actualizado
        Autor autorActualizado = new Autor();
        autorActualizado.setId(1L);
        autorActualizado.setNombre("Autor Actualizado");

        // Configuramos el comportamiento del mock para el método save
        when(autorRepository.save(any(Autor.class))).thenReturn(autorActualizado);

        // Realizamos la solicitud HTTP y verificamos el resultado
        mockMvc.perform(put("/api/autores/1")
                .contentType(MediaType.APPLICATION_JSON)
                .content("{\"id\":1,\"nombre\":\"Autor Actualizado\"}")) // Enviamos el autor actualizado como JSON en el cuerpo de la solicitud
                .andExpect(status().isOk()) // Esperamos que la respuesta sea OK (código de estado 200)
                .andExpect(content().contentType(MediaType.APPLICATION_JSON)) // Esperamos que el tipo de contenido sea JSON
                .andExpect(jsonPath("$.nombre").value("Autor Actualizado")); // Esperamos que el autor actualizado tenga el nombre "Autor Actualizado"
    }

    @Test
    public void testDeleteAutor() throws Exception {
        // Realizamos la solicitud HTTP de eliminación y verificamos el resultado
        mockMvc.perform(delete("/api/autores/1"))
                .andExpect(status().isOk()); // Esperamos que la respuesta sea OK (código de estado 200)
    }
}