/*
 * Click nbfs://nbhost/SystemFileSystem/Templates/Licenses/license-default.txt to change this license
 * Click nbfs://nbhost/SystemFileSystem/Templates/Classes/Class.java to edit this template
 */
package Interfaces;
import Models.Libro;
import java.util.List;
import org.springframework.data.jpa.repository.JpaRepository;
/**
 *
 * @author airam_fckw728
 */
public interface LibroRepositorio extends JpaRepository<Libro, Long>{
    List<Libro> findAll();
    Libro save(Libro libro);
    Libro getLibro();
    
}
