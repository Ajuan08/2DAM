package museo.museo;
import java.time.LocalDate;
import java.util.ArrayList;

public class DAOObras {

	private static DAOObras DAO=null;
	private ArrayList<Obra> obras;
	
	private DAOObras()
	{
		obras = new ArrayList<Obra>();
		Artista artista = new Artista("Airam","Linares",LocalDate.of(2000, 9, 24),null);
		obras.add(new Pintura("One Piece", 1, artista, 2000, 30.7, 12.5, "Papel"));
		obras.add(new Escultura("Pistola de Goma", 3, artista, 2008, "Madera", 500));
		
	}
	
	public static DAOObras getInstance() {
		if (DAO == null) DAO = new DAOObras();
		
		return DAO;
	}
	
	public ArrayList<Obra> getObras()
	{
		return obras;
	}

}