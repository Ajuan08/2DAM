package com.example.pizzeria;

import android.content.Intent;
import android.os.Bundle;
import android.view.View;
import android.widget.Switch;

public class Configuracion extends MainActivity implements View.OnClickListener {
    private Switch fondo;
    private Switch favorita;

    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(getLayoutRes());
        fondo = findViewById(R.id.fondo);
        favorita = findViewById(R.id.favorita);

        boolean esColor2 = isColorFondo2();
        fondo.setChecked(esColor2);
        if (getFavPreference()) {
            favorita.setChecked(true);
        }
    }

    @Override
    protected int getLayoutRes() {
        return R.layout.activity_configuracion;
    }

    @Override
    public void onClick(View v) {
        switch (getResources().getResourceEntryName(v.getId())) {
            case "fondo":
                boolean esColor2 = fondo.isChecked();
                saveBackgroundColorPreference(esColor2);
                changeBackgroundColor(esColor2 ? color2 : color1);
                break;
            case"volverConfiguracion":
                Intent volver = new Intent(this, Pagina_Principal.class);
                startActivity(volver);
                break;
            case "favorita":
                boolean fav = favorita.isChecked();
                saveFavPreference(fav);
                break;
        }
    }
}