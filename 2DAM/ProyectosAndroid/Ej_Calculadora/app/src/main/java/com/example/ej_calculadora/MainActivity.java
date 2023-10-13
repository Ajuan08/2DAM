package com.example.ej_calculadora;

import androidx.appcompat.app.AppCompatActivity;

import android.os.Bundle;
import android.view.View;
import android.widget.Button;
import android.widget.EditText;
import android.widget.TextView;

public class MainActivity extends AppCompatActivity {

    private TextView tv;
    private String numeroActual = "";
    private String operador = "";
    private double resultado = 0;

    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_main);

        tv = (TextView) findViewById(R.id.pantalla);
    }

    public void enClickBoton(View vista) {
        Button boton = (Button) vista;
        String textoBoton = boton.getText().toString();

        switch (textoBoton) {
            case "=":
                calcular();
                break;
            case "C":
                limpiar();
                break;
            default:
                actualizarPantalla(textoBoton);
                break;
        }
    }

    private void actualizarPantalla(String textoBoton) {
        numeroActual += textoBoton;
        tv.setText(numeroActual);
    }

    private void calcular() {
        double segundoNumero = Double.parseDouble(numeroActual);

        switch (operador) {
            case "+":
                resultado += segundoNumero;
                break;
            case "-":
                resultado -= segundoNumero;
                break;
            case "*":
                resultado *= segundoNumero;
                break;
            case "/":
                resultado /= segundoNumero;
                break;
            default:
                resultado = segundoNumero;
                break;
        }

        tv.setText(String.valueOf(resultado));
        numeroActual = "";
        operador = "";
    }

    private void limpiar() {
        numeroActual = "";
        operador = "";
        resultado = 0;
        tv.setText("");
    }
}