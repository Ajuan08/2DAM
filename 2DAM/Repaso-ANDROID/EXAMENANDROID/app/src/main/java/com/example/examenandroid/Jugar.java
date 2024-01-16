package com.example.examenandroid;

import androidx.appcompat.app.AppCompatActivity;

import android.content.Intent;
import android.os.Bundle;
import android.view.View;
import android.view.ViewGroup;
import android.widget.AdapterView;
import android.widget.ArrayAdapter;
import android.widget.Button;
import android.widget.ListView;
import android.widget.TextView;
import android.widget.Toast;

import java.util.ArrayList;
import java.util.List;

public class Jugar extends AppCompatActivity implements View.OnClickListener {

    private ListView listView;
    private TextView txtLista;
    private List<String> palabras;

    private DB db = new DB(this);

    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_jugar);
        Button btnVolver = (Button) findViewById(R.id.buttonVolver);
        listView = findViewById(R.id.listView);
        db = new DB(this);
        palabras = db.getPalabras();
        mostrarListaPalabras();

        btnVolver.setOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View v) {
                Intent intent = new Intent(Jugar.this, PaginaPrincipal.class);
                startActivity(intent);
            }
        });

        palabras = db.getPalabras();
        listView = findViewById(R.id.listView);


        listView.setOnItemClickListener(new AdapterView.OnItemClickListener() {
            @Override
            public void onItemClick(AdapterView<?> parent, View view, int position, long id) {
                String selected = (String) parent.getItemAtPosition(position);
                Toast.makeText(Jugar.this, "Selected:" + selected,Toast.LENGTH_SHORT).show();
            }
        });

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



        ArrayAdapter<String> adapter = new ArrayAdapter<String>(this, android.R.layout.simple_list_item_1, palabras) {
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