package com.example.examenacdatrecu;

import androidx.appcompat.app.AlertDialog;
import androidx.appcompat.app.AppCompatActivity;

import android.content.Intent;
import android.os.Bundle;
import android.view.View;
import android.widget.RadioButton;

public class Valoraciones extends BaseActivity implements View.OnClickListener {
    RadioButton muyBueno;
    RadioButton bueno;
    RadioButton regular;
    RadioButton malo;
    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(getLayoutRes());
        muyBueno = findViewById(R.id.rMuyBuena);
        bueno = findViewById(R.id.rBuena);
        regular = findViewById(R.id.rRegular);
        malo = findViewById(R.id.rMala);
    }

    @Override
    protected int getLayoutRes() {
        return R.layout.activity_valoraciones;
    }

    @Override
    public void onClick(View v) {
        switch (getResources().getResourceEntryName(v.getId())) {
            case "buttonGuardar":
                if (muyBueno.isChecked()) {
                    guardarValoracion("Muy bueno");
                    AlertDialog.Builder builder = new AlertDialog.Builder(this);
                    builder.setMessage("Valoracion guardada");
                    builder.setPositiveButton("Aceptar", null);
                    builder.create().show();
                } else if (bueno.isChecked()) {
                    guardarValoracion("Bueno");
                    AlertDialog.Builder builder = new AlertDialog.Builder(this);
                    builder.setMessage("Valoracion guardada");
                    builder.setPositiveButton("Aceptar", null);
                    builder.create().show();
                } else if (regular.isChecked()) {
                    guardarValoracion("Regular");
                    AlertDialog.Builder builder = new AlertDialog.Builder(this);
                    builder.setMessage("Valoracion guardada");
                    builder.setPositiveButton("Aceptar", null);
                    builder.create().show();

                }else if (malo.isChecked()) {
                    guardarValoracion("Malo");
                    AlertDialog.Builder builder = new AlertDialog.Builder(this);
                    builder.setMessage("Valoracion guardada");
                    builder.setPositiveButton("Aceptar", null);
                    builder.create().show();

                }
                break;
                    case "buttonAtrasCita":
                        Intent vlv = new Intent(this, Citas.class);
                        startActivity(vlv);
                        break;

        }
    }

}