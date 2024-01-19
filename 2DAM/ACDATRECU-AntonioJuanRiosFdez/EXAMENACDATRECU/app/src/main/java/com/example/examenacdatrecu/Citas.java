package com.example.examenacdatrecu;

import androidx.appcompat.app.AlertDialog;
import androidx.appcompat.app.AppCompatActivity;

import android.content.Intent;
import android.os.Bundle;
import android.view.View;
import android.widget.ArrayAdapter;
import android.widget.EditText;
import android.widget.ListView;
import android.widget.Toast;

import java.util.List;

public class Citas extends BaseActivity implements View.OnClickListener {
    ListView listView;

    List<String> listaPalabras;
    EditText txtNombre;
    private String selected;

    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(getLayoutRes());
        listView = findViewById(R.id.listView);
        listaPalabras = db.getPalabras(dbRead);
        txtNombre = findViewById(R.id.txtCita);

        setListView();


        listView.setOnItemClickListener((parent, view, position, id) -> {
            selected = (String) parent.getItemAtPosition(position);
            AlertDialog alertDialog = new AlertDialog.Builder(this).create();
            alertDialog.setTitle("¿Quieres borrar la palabra?");
            alertDialog.setMessage("Selecciona una opcion");
            alertDialog.setButton(AlertDialog.BUTTON_POSITIVE, "Borrar", (dialog, which) -> {
                borrarPalabra(listView.getItemAtPosition(position).toString());
                listView.setAdapter(new ArrayAdapter<String>(this, android.R.layout.simple_list_item_1, listaPalabras));
            });

            alertDialog.setButton(AlertDialog.BUTTON_NEGATIVE, "Cancelar", (dialog, which) -> {
                dialog.cancel();

            });
            alertDialog.show();
        });
    }

    public void setListView() {
        ArrayAdapter<String> adapter = new ArrayAdapter<String>(this, android.R.layout.simple_list_item_1, listaPalabras) ;
        listView.setAdapter(adapter);
    }

    public void borrarPalabra(String nombre)
    {

        this.db.borrarPalabra(dbWrite,nombre);
        this.listaPalabras.remove(nombre);
        this.setListView();
    }

    @Override
    protected int getLayoutRes() {
        return R.layout.activity_citas;
    }

    @Override
    public void onClick(View v) {
        switch (getResources().getResourceEntryName(v.getId())) {
            case "buttonInsertar":
                db.insertarPalabra(dbWrite, txtNombre.getText().toString());
                listaPalabras = db.getPalabras(dbRead);
                setListView();
                break;
            case "buttonListarCitas":
                Intent list = new Intent(this, ListarCitas.class);
                startActivity(list);
                break;
            case "buttonAtras":
                Intent vlv = new Intent(this, MainActivity.class);
                startActivity(vlv);
                break;
            case "buttonCitaAleatoria":
                mostrarCitaAleatoria();
                break;
            case "buttonValorarCita":
                Intent val = new Intent(this, Valoraciones.class);
                startActivity(val);
                break;
        }
    }

    public void mostrarCitaAleatoria() {

        int random = (int) (Math.random() * listaPalabras.size());
        String citaAleatoria = listaPalabras.get(random);


        AlertDialog alertDialog = new AlertDialog.Builder(this).create();
        alertDialog.setTitle("Cita del Día");
        alertDialog.setMessage(citaAleatoria);
        alertDialog.setButton(AlertDialog.BUTTON_POSITIVE, "Aceptar", (dialog, which) -> {
            dialog.dismiss();
        });
        alertDialog.show();
    }

}