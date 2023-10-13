package museo;

import java.time.LocalDate;

public class ObrasArtisticas {

	private String titulo;
	private Integer num_inventario;
	private Artistas autor;
	private LocalDate ano;
	
	public ObrasArtisticas(String titulo,Integer num_inventario,Artistas artista,LocalDate ano)
	{
		this.titulo=titulo;
		this.num_inventario=num_inventario;
		this.autor=artista;
		this.ano=ano;
	}
	
	@Override
	public String toString() {
		return "ObrasArtisticas [titulo=" + titulo + ", num_inventario=" + num_inventario + ", autor=" + autor
				+ ", ano=" + ano + "]";
	}

	public String getTitulo() {
		return titulo;
	}

	public void setTitulo(String titulo) {
		this.titulo = titulo;
	}

	public Integer getNum_inventario() {
		return num_inventario;
	}

	public void setNum_inventario(Integer num_inventario) {
		this.num_inventario = num_inventario;
	}

	public Artistas getAutor() {
		return autor;
	}

	public void setAutor(Artistas autor) {
		this.autor = autor;
	}

	public LocalDate getAno() {
		return ano;
	}

	public void setAno(LocalDate ano) {
		this.ano = ano;
	}
}
