/*
 * Click nbfs://nbhost/SystemFileSystem/Templates/Licenses/license-default.txt to change this license
 * Click nbfs://nbhost/SystemFileSystem/Templates/Classes/Class.java to edit this template
 */
package View;

import Models.Libro;
import javax.swing.*;
import java.awt.*;
import java.util.ArrayList;
import java.util.List;

public class vistaLibros extends JFrame {

    private List<Libro> libros;

    public vistaLibros(List<Libro> libros) {
        this.libros = libros;
        initComponents();
    }

    private void initComponents() {
        setTitle("Vista de Libros");
        setDefaultCloseOperation(JFrame.EXIT_ON_CLOSE);
        setSize(400, 300);

        JPanel panel = new JPanel(new BorderLayout());

        DefaultListModel<String> listModel = new DefaultListModel<>();
        for (Libro libro : libros) {
            listModel.addElement(libro.getTitulo() + " - " + libro.getAutor());
        }

        JList<String> libroList = new JList<>(listModel);
        JScrollPane scrollPane = new JScrollPane(libroList);

        panel.add(scrollPane, BorderLayout.CENTER);

        getContentPane().add(panel);

        setLocationRelativeTo(null);
        setVisible(true);
    }

    public static void main(String[] args) {
        // Crear algunos libros de ejemplo
        List<Libro> libros = new ArrayList<>();
        libros.add(new Libro("El señor de los anillos", "J.R.R. Tolkien"));
        libros.add(new Libro("1984", "George Orwell"));
        libros.add(new Libro("Cien años de soledad", "Gabriel García Márquez"));

        // Crear la vista de libros
        SwingUtilities.invokeLater(() -> new VistaLibros(libros));
    }
}

