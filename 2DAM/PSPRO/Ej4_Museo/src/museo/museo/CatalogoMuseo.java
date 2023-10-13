package museo;

import java.util.ArrayList;
import java.util.List;


public class CatalogoMuseo 
{
	private ArrayList<ObrasArtisticas> catalogo;
	
	public CatalogoMuseo() 
	{
		catalogo = DAO.getObras();
    } 
	
	public void añadeObra(ObrasArtisticas obra) {
		catalogo.add(obra);
    }
	
	public boolean eliminaObra(int numeroInventario) {
        for (ObrasArtisticas obra : catalogo) {
            if (obra.getNum_inventario() == numeroInventario) {
                catalogo.remove(obra);
                return true;
            }
        }
        return false;
    }
	
	public ObrasArtisticas buscaObra(int numeroInventario) {
        for (ObrasArtisticas obra : catalogo) {
            if (obra.getNum_inventario() == numeroInventario) {
                return obra;
            }
        }
        return null;
    }
	
	public double superficie() {
        double totalSuperficie = 0;
        for (ObrasArtisticas obra : catalogo) {
            if (obra instanceof Pinturas) {
                totalSuperficie += ((Pinturas) obra).getDimensiones();
            }
        }
        return totalSuperficie;
    }
	
	public int masAlta() {
        double alturaMaxima = -1;
        int numInventarioMasAlta = -1;

        for (ObrasArtisticas obra : catalogo) {
            if (obra instanceof Esculturas) {
                double altura = ((Esculturas) obra).getAltura();
                if (altura > alturaMaxima) {
                    alturaMaxima = altura;
                    numInventarioMasAlta = obra.getNum_inventario();
                }
            }
        }

        return numInventarioMasAlta;
    }
}























































/*
public class CatalogoMuseo {
    private List<ObrasArtisticas> obras;

    public CatalogoMuseo() {
        this.obras = new ArrayList<>();
    }

    public void añadeObra(ObrasArtisticas obra) {
        obras.add(obra);
    }

    public boolean eliminaObra(int numeroInventario) {
        for (ObrasArtisticas obra : obras) {
            if (ObrasArtisticas.getNumeroInventario() == numeroInventario) {
                obras.remove(obra);
                return true;
            }
        }
        return false;
    }

    public ObrasArtisticas buscaObra(int numeroInventario) {
        for (ObrasArtisticas obra : obras) {
            if (obra.getNumeroInventario() == numeroInventario) {
                return obra;
            }
        }
        return null;
    }

    public double superficie() {
        double totalSuperficie = 0;
        for (ObrasArtisticas obra : obras) {
            if (obra instanceof Pinturas) {
                totalSuperficie += ((Pinturas) obra).getSuperficie();
            }
        }
        return totalSuperficie;
    }

    public int masAlta() {
        double alturaMaxima = 0;
        int numInventarioMasAlta = -1;

        for (ObrasArtisticas obra : obras) {
            if (obra instanceof Esculturas) {
                double altura = ((Esculturas) obra).getAltura();
                if (altura > alturaMaxima) {
                    alturaMaxima = altura;
                    numInventarioMasAlta = obra.getNumeroInventario();
                }
            }
        }

        return numInventarioMasAlta;
    }

    public void muestraCatalogo() {
        for (ObrasArtisticas obra : obras) {
            System.out.println(obra.toString());
        }
    }
    */
