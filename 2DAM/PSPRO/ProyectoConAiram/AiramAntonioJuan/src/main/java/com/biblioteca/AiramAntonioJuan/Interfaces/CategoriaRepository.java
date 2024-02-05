/*
 * Click nbfs://nbhost/SystemFileSystem/Templates/Licenses/license-default.txt to change this license
 * Click nbfs://nbhost/SystemFileSystem/Templates/SpringFramework/Repository.java to edit this template
 */
package com.biblioteca.AiramAntonioJuan.Interfaces;

import com.biblioteca.AiramAntonioJuan.Models.Categoria;
import org.springframework.data.jpa.repository.JpaRepository;

/**
 *
 * @author anton
 */
public interface CategoriaRepository extends JpaRepository<Categoria, Long> {
    
}
