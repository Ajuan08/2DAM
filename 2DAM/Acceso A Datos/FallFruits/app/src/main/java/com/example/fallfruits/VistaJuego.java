package com.example.fallfruits;

import androidx.appcompat.app.AppCompatActivity;

import android.os.Bundle;
import android.view.View;
import android.widget.TextView;

public class VistaJuego extends AppCompatActivity {

    TextView puntuacion;

    TextView labelDerrota;

    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(getLayoutRes());
        puntuacion = findViewById(R.id.scoreTextView);
        labelDerrota = findViewById(R.id.LabelDerrota);
        MoverFiguras moverFiguras = findViewById(R.id.surfaceView);
        moverFiguras.acutalizarTextViews(this);
    }

    protected int getLayoutRes() {
        return R.layout.activity_vista_juego;
    }

    public void onClick(View v) {
        switch (getResources().getResourceEntryName(v.getId())) {
            case "buttonVolver":
                BackgroundMusicPlayer.stop();
                finish();
                break;
        }
    }
}