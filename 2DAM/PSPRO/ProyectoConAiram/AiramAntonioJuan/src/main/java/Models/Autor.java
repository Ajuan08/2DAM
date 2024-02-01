package Models;

import java.util.List;
import javax.persistence.*;

@Entity
public class Autor {
    
    @Id
    @GeneratedValue(strategy = GenerationType.IDENTITY)
    private Long id;
    
    private String nombre;

    @OneToMany(mappedBy = "autor")
    private List<Libro> libros;

}
