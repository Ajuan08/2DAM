package com.example.examenandroid;

import androidx.appcompat.app.AppCompatActivity;

import android.content.Intent;
import android.os.Bundle;
import android.view.View;
import android.view.ViewGroup;
import android.widget.ArrayAdapter;
import android.widget.ListView;
import android.widget.TextView;

import java.util.ArrayList;

public class Jugar extends AppCompatActivity implements View.OnClickListener {

    private ListView listView;
    private TextView txtLista;
    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_jugar);
        listView = findViewById(R.id.listView);
        mostrarListaPalabras();
    }

    public void mostrarListaPalabras() {
        ArrayList<String> listaPalabras = new ArrayList<>();
        listaPalabras.add("Belleza");
        listaPalabras.add("Basket");
        listaPalabras.add("Alarma");
        listaPalabras.add("Sufrir");
        listaPalabras.add("Café");
        listaPalabras.add("Serenidad");
        listaPalabras.add("Hojaldre");
        listaPalabras.add("Normal");
        listaPalabras.add("Código");

        ArrayAdapter<String> adapter = new ArrayAdapter<String>(this, android.R.layout.simple_list_item_1, listaPalabras) {
            @Override
            public View getView(int position, View convertView, ViewGroup parent) {
                View view = super.getView(position, convertView, parent);

                txtLista = view.findViewById(android.R.id.text1);

                txtLista.setTextSize(20);
                txtLista.setText(listaPalabras.get(position));

                return view;
            }
        };
        listView.setAdapter(adapter);
    }

    @Override
    public void onClick(View v) {
        switch (v.getResources().getResourceEntryName(v.getId())) {
            case "buttonSiguiente":
                Intent botonSig = new Intent(this, Juego2.class);
                startActivity(botonSig);
                break;
        }
    }
}