package com.example.examenacdatrecu;

import androidx.appcompat.app.AlertDialog;
import androidx.appcompat.app.AppCompatActivity;

import android.content.Intent;
import android.os.Bundle;
import android.view.View;
import android.widget.RadioButton;

public class Configuracion extends BaseActivity implements View.OnClickListener {
    RadioButton r1;
    RadioButton r2;
    RadioButton r3;
    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(getLayoutRes());
        r1 = findViewById(R.id.r1);
        r2 = findViewById(R.id.r2);
        r3 = findViewById(R.id.r3);
    }

    @Override
    protected int getLayoutRes() {
        return R.layout.activity_configuracion;
    }

    @Override
    public void onClick(View v) {
        switch (getResources().getResourceEntryName(v.getId())) {
            case "buttonGuardarConf":
                if (r1.isChecked()) {
                    guardarConf(1);
                    AlertDialog.Builder builder = new AlertDialog.Builder(this);
                    builder.setMessage("Configuracion guardada");
                    builder.setPositiveButton("Aceptar", null);
                    builder.create().show();
                } else if (r2.isChecked()) {
                    guardarConf(2);
                    AlertDialog.Builder builder = new AlertDialog.Builder(this);
                    builder.setMessage("Configuracion guardada");
                    builder.setPositiveButton("Aceptar", null);
                    builder.create().show();
                } else if (r3.isChecked()) {
                    guardarConf(3);
                    AlertDialog.Builder builder = new AlertDialog.Builder(this);
                    builder.setMessage("Configuracion guardada");
                    builder.setPositiveButton("Aceptar", null);
                    builder.create().show();

                }
                break;
            case "buttonVolverMain":
                Intent list = new Intent(this, MainActivity.class);
                startActivity(list);
                break;

        }
    }
}