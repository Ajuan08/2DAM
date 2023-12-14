package com.example.examenandroid;

import androidx.appcompat.app.AppCompatActivity;

import android.content.Intent;
import android.os.Bundle;
import android.view.View;
import android.widget.ArrayAdapter;
import android.widget.Spinner;

import java.util.ArrayList;

public class DificultadConfig extends AppCompatActivity implements View.OnClickListener {

    private Spinner spinner;
    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_dificultad_config);
        spinner();
    }

    private void spinner(){
        ArrayList<String> listaSpinner = new ArrayList<>();
        listaSpinner.add("Medio(15 palabras)");
        listaSpinner.add("Fácil(10 palabras)");
        listaSpinner.add("Difícil(20 palabras)");

        ArrayAdapter<String> adapter = new ArrayAdapter<String>(this, android.R.layout.simple_list_item_1, listaSpinner);

        adapter.setDropDownViewResource(android.R.layout.simple_spinner_dropdown_item);

        spinner = findViewById(R.id.spinner);

        spinner.setAdapter(adapter);


    }

    @Override
    public void onClick(View v) {
        switch (v.getResources().getResourceEntryName(v.getId())) {
            case "buttonVolverConfig":
                Intent volverConfig = new Intent(this, Configurar.class);
                startActivity(volverConfig);
                break;
        }
    }
}