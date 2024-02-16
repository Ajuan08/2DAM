/*
 * Click nbfs://nbhost/SystemFileSystem/Templates/Licenses/license-default.txt to change this license
 * Click nbfs://nbhost/SystemFileSystem/Templates/Classes/Class.java to edit this template
 */
package com.biblioteca.AiramAntonioJuan;

/**
 *
 * @author anton
 */
import com.biblioteca.AiramAntonioJuan.Controllers.CategoriaController;
import com.biblioteca.AiramAntonioJuan.Interfaces.CategoriaRepository;
import com.biblioteca.AiramAntonioJuan.Models.Categoria;
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
public class CategoriaControllerTest {

    @Autowired
    private MockMvc mockMvc;

    @Mock
    private CategoriaRepository categoriaRepository;

    @InjectMocks
    private CategoriaController categoriaController;

    @BeforeEach
    public void setUp() {
        MockitoAnnotations.initMocks(this);
        mockMvc = MockMvcBuilders.standaloneSetup(categoriaController).build();
    }

    @Test
    public void testGetAllCategorias() throws Exception {
        Categoria categoria1 = new Categoria();
        categoria1.setId(1L);
        categoria1.setNombre("Categoria 1");

        Categoria categoria2 = new Categoria();
        categoria2.setId(2L);
        categoria2.setNombre("Categoria 2");

        List<Categoria> categorias = Arrays.asList(categoria1, categoria2);

        when(categoriaRepository.findAll()).thenReturn(categorias);

        mockMvc.perform(get("/api/categorias"))
                .andExpect(status().isOk()) 
                .andExpect(content().contentType(MediaType.APPLICATION_JSON)) 
                .andExpect(jsonPath("$[0].nombre").value("Categoria 1")) 
                .andExpect(jsonPath("$[1].nombre").value("Categoria 2"));
    }

    @Test
    public void testGetCategoriaById() throws Exception {
        Categoria categoria = new Categoria();
        categoria.setId(1L);
        categoria.setNombre("Categoria Existente");

        when(categoriaRepository.findById(1L)).thenReturn(java.util.Optional.of(categoria));

        mockMvc.perform(get("/api/categorias/1"))
                .andExpect(status().isOk()) 
                .andExpect(content().contentType(MediaType.APPLICATION_JSON)) 
                .andExpect(jsonPath("$.nombre").value("Categoria Existente"));
    }

    @Test
    public void testCreateCategoria() throws Exception {
        Categoria nuevaCategoria = new Categoria();
        nuevaCategoria.setId(3L);
        nuevaCategoria.setNombre("Nueva Categoria");

        when(categoriaRepository.save(any(Categoria.class))).thenReturn(nuevaCategoria);

        mockMvc.perform(post("/api/categorias")
                .contentType(MediaType.APPLICATION_JSON)
                .content("{\"id\":3,\"nombre\":\"Nueva Categoria\"}")) 
                .andExpect(status().isOk()) 
                .andExpect(content().contentType(MediaType.APPLICATION_JSON)) 
                .andExpect(jsonPath("$.nombre").value("Nueva Categoria"));
    }

    @Test
    public void testUpdateCategoria() throws Exception {
        Categoria categoriaExistente = new Categoria();
        categoriaExistente.setId(1L);
        categoriaExistente.setNombre("Categoria Existente");

        when(categoriaRepository.findById(1L)).thenReturn(java.util.Optional.of(categoriaExistente));

        Categoria categoriaActualizada = new Categoria();
        categoriaActualizada.setId(1L);
        categoriaActualizada.setNombre("Categoria Actualizada");

        when(categoriaRepository.save(any(Categoria.class))).thenReturn(categoriaActualizada);

        mockMvc.perform(put("/api/categorias/1")
                .contentType(MediaType.APPLICATION_JSON)
                .content("{\"id\":1,\"nombre\":\"Categoria Actualizada\"}")) 
                .andExpect(status().isOk()) 
                .andExpect(content().contentType(MediaType.APPLICATION_JSON)) 
                .andExpect(jsonPath("$.nombre").value("Categoria Actualizada")); 
    }

    @Test
    public void testDeleteCategoria() throws Exception {
        mockMvc.perform(delete("/api/categorias/1"))
                .andExpect(status().isOk()); 
    }
}