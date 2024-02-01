package Models;

import javax.persistence.*;

@Entity
@Table(name = "Categoria_Libro")
public class Categoria_Libro {
    @Id
    @GeneratedValue(strategy = GenerationType.IDENTITY)
    private Long id;

    @ManyToOne
    @JoinColumn(name = "id_libro")
    private Libro libro;

    @ManyToOne
    @JoinColumn(name = "id_categoria")
    private Categoria categoria;
}

