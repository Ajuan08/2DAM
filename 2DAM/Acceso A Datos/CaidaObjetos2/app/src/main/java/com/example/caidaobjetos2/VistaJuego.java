package com.example.caidaobjetos2;

import androidx.appcompat.app.AppCompatActivity;

import android.content.Intent;
import android.os.Bundle;
import android.view.View;

public class VistaJuego extends AppCompatActivity {

    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(getLayoutRes());
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