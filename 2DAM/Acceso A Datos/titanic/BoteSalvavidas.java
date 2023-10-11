package titanic;

public class BoteSalvavidas {
    private int id;
    private int numeroPlazas;
    private String zona;

    public BoteSalvavidas(int id, int numeroPlazas, String zona) {
        this.id = id;
        this.numeroPlazas = numeroPlazas;
        this.zona = zona;
    }

    public int getId() {
        return id;
    }

    public int getNumeroPlazas() {
        return numeroPlazas;
    }

    public String getZona() {
        return zona;
    }
}
