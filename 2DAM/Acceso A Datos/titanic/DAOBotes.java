package titanic;

import java.util.ArrayList;
import java.util.List;

public class DAOBotes {
    public static List<BoteSalvavidas> obtenerBotes() {
        List<BoteSalvavidas> botes = new ArrayList<>();

        BoteSalvavidas bote1 = new BoteSalvavidas(1, 20, "proa");
        BoteSalvavidas bote2 = new BoteSalvavidas(2, 10, "popa");
        BoteSalvavidas bote3 = new BoteSalvavidas(3, 50, "babor");
        BoteSalvavidas bote4 = new BoteSalvavidas(4, 30, "babpr");
        BoteSalvavidas bote5 = new BoteSalvavidas(5, 40, "estribor");
        return botes;
    }
}
