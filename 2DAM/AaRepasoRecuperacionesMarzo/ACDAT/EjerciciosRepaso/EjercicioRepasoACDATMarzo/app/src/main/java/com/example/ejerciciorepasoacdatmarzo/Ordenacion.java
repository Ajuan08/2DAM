package com.example.ejerciciorepasoacdatmarzo;

import androidx.appcompat.app.AppCompatActivity;

import android.content.Intent;
import android.os.Bundle;
import android.view.View;
import android.widget.ArrayAdapter;
import android.widget.ListView;

import java.util.List;

public class Ordenacion extends BaseActivity implements View.OnClickListener {

    ListView listView;
    List<String> listaPersonas;

    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(getLayoutRes());
        listView = findViewById(R.id.listViewPersonaOrdenada);
        listaPersonas = db.getPersonasNombre(dbRead);
        listaPersonas.sort(String::compareTo);
        setListView();
    }

    public void setListView() {
        ArrayAdapter adapter = new ArrayAdapter(this, android.R.layout.simple_list_item_1, listaPersonas);
        listView.setAdapter(adapter);
    }

    protected int getLayoutRes() {
        return R.layout.activity_ordenacion;
    }



    @Override
    public void onClick(View v) {
        switch (getResources().getResourceEntryName(v.getId())) {
            case "botonvolv":
                Intent main = new Intent(this, Inicio.class);
                startActivity(main);
                break;


        }

    }
}