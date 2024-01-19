package com.example.examenacdatrecu;

import androidx.appcompat.app.AppCompatActivity;

import android.content.Intent;
import android.os.Bundle;
import android.view.View;
import android.widget.ArrayAdapter;
import android.widget.ListView;

import java.util.List;

public class ListarCitas extends BaseActivity implements View.OnClickListener {
    ListView listView;

    List<String> listaPalabras;
    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(getLayoutRes());
        listView = findViewById(R.id.listView);
        listaPalabras = db.getPalabras(dbRead);
        setListView();


    }

    @Override
    protected int getLayoutRes() {
        return R.layout.activity_listar_citas;
    }

    public void setListView() {
        ArrayAdapter<String> adapter = new ArrayAdapter<String>(this, android.R.layout.simple_list_item_1, listaPalabras) ;
        listView.setAdapter(adapter);
    }

    @Override
    public void onClick(View v) {
        switch (getResources().getResourceEntryName(v.getId())) {
            case "buttonVolverCitas":
                Intent vlv = new Intent(this, Citas.class);
                startActivity(vlv);
                break;
        }
    }
}