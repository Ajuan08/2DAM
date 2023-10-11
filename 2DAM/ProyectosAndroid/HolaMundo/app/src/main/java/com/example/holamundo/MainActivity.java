package com.example.holamundo;

import androidx.appcompat.app.AppCompatActivity;

import android.os.Bundle;
import android.view.View;
import android.widget.Button;
import android.widget.TextView;

public class MainActivity extends AppCompatActivity {

    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_main);

        Button btnSaludar = (Button) findViewById(R.id.btn_saludar);

        //TextView texto = new TextView(this);
        //texto.setText("Hello. Android");
        //setContentView(texto);
    }

    public void cambiarMensaje(View view)
    {
        TextView txtMensaje = (TextView) findViewById(R.id.TxtSaludo);
        txtMensaje.setText("Esto funciona!!");
    }


}