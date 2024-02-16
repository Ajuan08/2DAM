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
        Autor autor1 = new Autor();
        autor1.setId(1L);
        autor1.setNombre("Autor 1");

        Autor autor2 = new Autor();
        autor2.setId(2L);
        autor2.setNombre("Autor 2");

        List<Autor> autores = Arrays.asList(autor1, autor2);

        when(autorRepository.findAll()).thenReturn(autores);

        mockMvc.perform(get("/api/autores"))
                .andExpect(status().isOk()) 
                .andExpect(content().contentType(MediaType.APPLICATION_JSON)) 
                .andExpect(jsonPath("$[0].nombre").value("Autor 1")) 
                .andExpect(jsonPath("$[1].nombre").value("Autor 2")); 
    }

    @Test
    public void testGetAutorById() throws Exception {
        Autor autor = new Autor();
        autor.setId(1L);
        autor.setNombre("Antonio Juan");

        when(autorRepository.findById(1L)).thenReturn(Optional.of(autor));

        mockMvc.perform(get("/api/autores/1"))
                .andExpect(status().isOk()) 
                .andExpect(content().contentType(MediaType.APPLICATION_JSON)) 
                .andExpect(jsonPath("$.nombre").value("Antonio Juan")); 
    }

    @Test
    public void testCreateAutor() throws Exception {
        Autor nuevoAutor = new Autor();
        nuevoAutor.setId(3L);
        nuevoAutor.setNombre("Airam");

        when(autorRepository.save(any(Autor.class))).thenReturn(nuevoAutor);

        mockMvc.perform(post("/api/autores")
                .contentType(MediaType.APPLICATION_JSON)
                .content("{\"id\":3,\"nombre\":\"Nuevo Autor\"}")) 
                .andExpect(status().isOk()) 
                .andExpect(content().contentType(MediaType.APPLICATION_JSON)) 
                .andExpect(jsonPath("$.nombre").value("Airam")); 
    }

    @Test
    public void testUpdateAutor() throws Exception {
        Autor autorExistente = new Autor();
        autorExistente.setId(1L);
        autorExistente.setNombre("Autor Existente");

        when(autorRepository.findById(1L)).thenReturn(Optional.of(autorExistente));

        Autor autorActualizado = new Autor();
        autorActualizado.setId(1L);
        autorActualizado.setNombre("Autor Actualizado");

        when(autorRepository.save(any(Autor.class))).thenReturn(autorActualizado);

        mockMvc.perform(put("/api/autores/1")
                .contentType(MediaType.APPLICATION_JSON)
                .content("{\"id\":1,\"nombre\":\"Autor Actualizado\"}"))
                .andExpect(status().isOk()) 
                .andExpect(content().contentType(MediaType.APPLICATION_JSON)) 
                .andExpect(jsonPath("$.nombre").value("Autor Actualizado")); 
    }

    @Test
    public void testDeleteAutor() throws Exception {
        mockMvc.perform(delete("/api/autores/1"))
                .andExpect(status().isOk());
    }
}