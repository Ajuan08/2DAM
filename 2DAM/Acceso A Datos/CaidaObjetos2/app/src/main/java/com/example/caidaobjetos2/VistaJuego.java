package com.example.caidaobjetos2;

import androidx.appcompat.app.AppCompatActivity;

import android.content.Intent;
import android.os.Bundle;
import android.text.Editable;
import android.text.TextWatcher;
import android.view.View;
import android.widget.TextView;

public class VistaJuego extends AppCompatActivity {

    private TextView puntuacion;

    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(getLayoutRes());
        puntuacion = findViewById(R.id.scoreTextView);
        actualizarPuntuacion();
    }

    public void actualizarPuntuacion() {
        puntuacion.setText("Puntuación: " + Constants.puntuacion);
    }

    protected int getLayoutRes() {
        return R.layout.activity_vista_juego;
    }

    public void onClick(View v) {
        switch (getResources().getResourceEntryName(v.getId())) {
            case "buttonVolver":
                Intent volver = new Intent(this, MainActivity.class);
                startActivity(volver);
                break;
        }
    }
}