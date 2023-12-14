package com.example.examenandroid;

import androidx.appcompat.app.AppCompatActivity;

import android.app.AlertDialog;
import android.content.DialogInterface;
import android.content.Intent;
import android.os.Bundle;
import android.view.View;

public class Configurar extends AppCompatActivity implements View.OnClickListener {

    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_configurar);
    }

    @Override
    public void onClick(View v) {
        switch (v.getResources().getResourceEntryName(v.getId())) {
            case "buttonDificultad":
                Intent difi = new Intent(this, DificultadConfig.class);
                startActivity(difi);
                break;
            case "buttonListarPalabras":
                Intent listPala = new Intent(this, ListarPalabrasConfig.class);
                startActivity(listPala);
                break;
            case "buttonVolverInicio":
                Intent volverInicio = new Intent(this, PaginaPrincipal.class);
                startActivity(volverInicio);
                break;


        }
    }
}