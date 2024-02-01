package Controllers;

import Models.Libro;
import Servicios.LibroService;
import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.stereotype.Controller;
import org.springframework.web.bind.annotation.GetMapping;
import org.springframework.web.servlet.ModelAndView;

@Controller
public class VistaController {

    @Autowired
    private LibroService libroService;

     @GetMapping("/vistaLibros")
    public ModelAndView mostrarVistaLibros() {
        ModelAndView modelAndView = new ModelAndView("View/vistaLibros");

        // Obtén la lista de libros desde el servicio
        modelAndView.addObject("libros", libroService.obtenerLibrosDTO());

        return modelAndView;
    }
}
