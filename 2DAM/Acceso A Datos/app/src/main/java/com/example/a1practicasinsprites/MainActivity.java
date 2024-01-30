package com.example.a1practicasinsprites;

import android.content.Intent;
import android.os.Bundle;
import android.view.View;
import android.widget.Button;

import androidx.appcompat.app.AppCompatActivity;

public class MainActivity extends AppCompatActivity {

    private Button btnJugarMenu, btnSalir, btnReiniciar;

    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_main);

        btnJugarMenu = findViewById(R.id.btnJugarMenu);
        btnSalir = findViewById(R.id.btnSalir);
        btnReiniciar = findViewById(R.id.btnReiniciar);

        btnJugarMenu.setOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View view) {
                // Iniciar la actividad del juego
                Intent intent = new Intent(MainActivity.this, JuegoActivity.class);
                startActivity(intent);
            }
        });

        btnSalir.setOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View view) {
                finish();
            }
        });

        btnReiniciar.setOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View view) {
                // Agrega la lógica de reinicio según tus necesidades
            }
        });
    }
}
