package com.example.repasoandroidrecu;

import androidx.appcompat.app.AppCompatActivity;

import android.app.AlertDialog;
import android.content.DialogInterface;
import android.content.Intent;
import android.os.Bundle;
import android.view.View;

public class MainActivity extends AppCompatActivity {

    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_main);
    }
    public void onClick(View v) {
        switch (v.getResources().getResourceEntryName(v.getId())) {
            case "buttonJugar":
                Intent jugar = new Intent(this, PantallaJuego.class);
                startActivity(jugar);
                break;
            case "buttonPuntuaciones":
                Intent punt = new Intent(this, Puntuaciones.class);
                startActivity(punt);
                break;
            case "buttonConfigurar":
                Intent conf = new Intent(this, Configurar.class);
                startActivity(conf);
                break;
            case "buttonSalir":
                mostrarDialogoSalida();
                break;


        }
    }
    private void mostrarDialogoSalida() {
        new AlertDialog.Builder(this)
                .setMessage("¿Deseas salir?")
                .setCancelable(false)
                .setPositiveButton("Sí", new DialogInterface.OnClickListener() {
                    @Override
                    public void onClick(DialogInterface dialog, int which) {
                        finish();
                    }
                })
                .setNegativeButton("No", new DialogInterface.OnClickListener() {
                    @Override
                    public void onClick(DialogInterface dialog, int which) {
                        dialog.cancel();
                    }
                })
                .show();
    }
}