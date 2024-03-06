package com.example.ejerciciorepasoacdatmarzo;

import androidx.activity.OnBackPressedCallback;
import androidx.appcompat.app.AlertDialog;
import androidx.appcompat.app.AppCompatActivity;

import android.content.DialogInterface;
import android.content.Intent;
import android.content.SharedPreferences;
import android.os.Bundle;
import android.view.View;
import android.widget.ArrayAdapter;
import android.widget.EditText;
import android.widget.ListView;

import java.util.List;

public class Inicio extends BaseActivity implements View.OnClickListener {

    ListView listView;
    List<String> listaPersonas;
    EditText txtNombre;
    EditText txtEdad;

    String selected;

    String nombre;
    int edad;

    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(getLayoutRes());
        listView = findViewById(R.id.listView);
        listaPersonas = db.getPersonas(dbRead);
        txtNombre = findViewById(R.id.textNombre);
        txtEdad = findViewById(R.id.textEdad);

        setListView();

        listView.setOnItemClickListener((parent, view, position, id) -> {
            selected = (String) parent.getItemAtPosition(position);
            AlertDialog alertDialog = new AlertDialog.Builder(this).create();
            alertDialog.setTitle("¿Quieres editar la persona?");
            alertDialog.setMessage("Selecciona una opcion");
            alertDialog.setButton(AlertDialog.BUTTON_POSITIVE, "Editar", (dialog, which) -> {

                modificarPersona(listView.getItemAtPosition(position).toString());
                listView.setAdapter(new ArrayAdapter<String>(this, android.R.layout.simple_list_item_1, listaPersonas));
            });

            alertDialog.setButton(AlertDialog.BUTTON_NEGATIVE, "Cancelar", (dialog, which) -> {
                dialog.cancel();

            });
            alertDialog.show();
        });

        //CERRAR DESDE EL BOTON DE LA FLECHITA
        OnBackPressedCallback atras = new OnBackPressedCallback(true) {
            @Override
            public void handleOnBackPressed() {mostrarDialogoSalida();}
        };
        getOnBackPressedDispatcher().addCallback(this, atras);
    }

    public void setListView() {
        SharedPreferences sharedPreferences = getSharedPreferences("estadoPersona", MODE_PRIVATE);
        String estadoPersona = sharedPreferences.getString("estadoPersona", "");

        for (int i = 0; i < listaPersonas.size(); i++) {
            String[] parts = listaPersonas.get(i).split("\n");
            String estado = parts[2].split(": ")[1];
            if (!estado.equals(estadoPersona)) {
                listaPersonas.remove(i);
                i--;
            }
        }



        ArrayAdapter adapter = new ArrayAdapter(this, android.R.layout.simple_list_item_1, listaPersonas);
        listView.setAdapter(adapter);
    }

    public void borrarPersona(String nombre) {
        String[] parts = nombre.split("\n");
        String nombrePersona = parts[0].split(": ")[1];
        int edad = Integer.parseInt(parts[1].split(": ")[1]);
        this.db.borrarPersona(dbWrite, nombrePersona, edad);
        this.listaPersonas = db.getPersonas(dbRead);
        this.setListView();
        limpiarTexto();
    }

    public void modificarPersona(String nombre) {

        String[] parts = nombre.split("\n");
        String nombrePersona = parts[0].split(": ")[1];
        int edad = Integer.parseInt(parts[1].split(": ")[1]);
        txtNombre.setText(nombrePersona);
        txtEdad.setText(String.valueOf(edad));
        this.nombre = nombrePersona;
        this.edad = edad;
    }

    protected int getLayoutRes() {
        return R.layout.activity_inicio;
    }

    public void limpiarTexto() {
        txtNombre.setText("");
        txtEdad.setText("");
    }

    @Override
    public void onClick(View v) {

        switch (getResources().getResourceEntryName(v.getId())) {
            case "botonInsertar":
                db.insertarPersona(dbWrite, txtNombre.getText().toString(), Integer.parseInt(txtEdad.getText().toString()));
                listaPersonas = db.getPersonas(dbRead);
                setListView();
                limpiarTexto();
                break;
            case "botonModificar":
                db.modificarPersona(dbWrite, nombre, edad, txtNombre.getText().toString(), Integer.parseInt(txtEdad.getText().toString()));
                listaPersonas = db.getPersonas(dbRead);
                setListView();
                limpiarTexto();
                break;
            case "botonBorrar":
                db.borrarPersona(dbWrite,txtNombre.getText().toString(), Integer.parseInt(txtEdad.getText().toString()));
                listaPersonas = db.getPersonas(dbRead);
                setListView();
                limpiarTexto();
                break;
            case "botonOrdenacion":
                Intent paginaOrdenada = new Intent(this, Ordenacion.class);
                startActivity(paginaOrdenada);
                break;
            case "botonVolverMain":
                Intent main = new Intent(this, MainActivity.class);
                startActivity(main);
                break;


        }

    }

    private void mostrarDialogoSalida() {
        new android.app.AlertDialog.Builder(this)
                .setMessage("¿Deseas salir?")
                .setCancelable(false)
                .setPositiveButton("Sí", new DialogInterface.OnClickListener() {
                    @Override
                    public void onClick(DialogInterface dialog, int which) {
                        finishAffinity();
                    }
                })
                .setNegativeButton("No", new DialogInterface.OnClickListener() {
                    @Override
                    public void onClick(DialogInterface dialog, int which) {
                        dialog.cancel();
                    }
                })
                .show();
    }
}