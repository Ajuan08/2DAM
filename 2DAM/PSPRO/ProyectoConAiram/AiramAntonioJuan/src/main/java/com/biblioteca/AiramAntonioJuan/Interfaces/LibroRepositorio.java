/*
 * Click nbfs://nbhost/SystemFileSystem/Templates/Licenses/license-default.txt to change this license
 * Click nbfs://nbhost/SystemFileSystem/Templates/Classes/Class.java to edit this template
 */
package com.biblioteca.AiramAntonioJuan.Interfaces;
import com.biblioteca.AiramAntonioJuan.Models.Libro;
import org.springframework.data.jpa.repository.JpaRepository;
import org.springframework.stereotype.Repository;
/**
 *
 * @author airam_fckw728
 */
@Repository
public interface LibroRepositorio extends JpaRepository<Libro, Long>{}
