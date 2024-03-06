package com.example.ejerciciorepasoacdatmarzo;

import androidx.appcompat.app.AlertDialog;
import androidx.appcompat.app.AppCompatActivity;

import android.content.Context;
import android.content.Intent;
import android.content.SharedPreferences;
import android.os.Bundle;
import android.view.View;
import android.widget.ArrayAdapter;
import android.widget.RadioButton;
import android.widget.Switch;

public class Configuracion extends BaseActivity implements View.OnClickListener {
    RadioButton radioMuyBueno;
    RadioButton radioRegular;
    RadioButton radioMalo;

    Switch fondo;

    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(getLayoutRes());
        radioMuyBueno = findViewById(R.id.radioMuyBuena);
        radioRegular = findViewById(R.id.radioRegular);
        radioMalo = findViewById(R.id.radioMala);
        fondo = findViewById(R.id.switchColorFondo);

        fondo.setChecked(getBackgroundColorPreference());
    }

    protected int getLayoutRes() {
        return R.layout.activity_configuracion;
    }

    @Override
    public void onClick(View v) {
        switch (getResources().getResourceEntryName(v.getId())) {
            case "botonGuardarConf":
                if (radioMuyBueno.isChecked()) {
                    SharedPreferences.Editor editor = getSharedPreferences("estadoPersona", MODE_PRIVATE).edit();
                    editor.putString("estadoPersona", "Muy buena");
                    editor.apply();
                    mostrarAlerta();

                } else if (radioRegular.isChecked()) {
                    SharedPreferences.Editor editor = getSharedPreferences("estadoPersona", MODE_PRIVATE).edit();
                    editor.putString("estadoPersona", "Regular");
                    editor.apply();
                    mostrarAlerta();
                } else if (radioMalo.isChecked()) {
                    SharedPreferences.Editor editor = getSharedPreferences("estadoPersona", MODE_PRIVATE).edit();
                    editor.putString("estadoPersona", "Mala");
                    editor.apply();
                    mostrarAlerta();
                }
                break;
            case "botonVolver":
                Intent main = new Intent(this, MainActivity.class);
                startActivity(main);
                break;
            case "switchColorFondo":
            boolean esColor2 = fondo.isChecked();
            saveBackgroundColorPreference(esColor2);
            changeBackgroundColor(esColor2 ? color2 : color1);
            break;
        }
    }

    public void mostrarAlerta(){
        AlertDialog alertDialog = new AlertDialog.Builder(this).create();
        alertDialog.setTitle("Aviso");
        alertDialog.setMessage("Tu opcion se ha guardado correctamente");
        alertDialog.setButton(AlertDialog.BUTTON_POSITIVE, "OK", (dialog, which) -> {
            dialog.cancel();
        });
        alertDialog.show();
    }




}