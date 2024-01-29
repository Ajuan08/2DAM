package ProyectoAjuanAiram.ProyectoGesLibros;

import org.springframework.boot.SpringApplication;
import org.springframework.boot.autoconfigure.SpringBootApplication;
import org.springframework.web.bind.annotation.GetMapping;
import org.springframework.web.bind.annotation.RestController;

@SpringBootApplication
@RestController
public class ProyectoGesLibrosApplication {

    @GetMapping("/hola")
    public String hola(){
        return "Hola Mundo";
    }
	public static void main(String[] args) {
		SpringApplication.run(ProyectoGesLibrosApplication.class, args);
	}

}
