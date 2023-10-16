package com.example.ej_calculadora;

import android.os.Bundle;
import android.view.View;
import android.widget.Button;
import android.widget.TextView;
import androidx.appcompat.app.AppCompatActivity;

public class MainActivity extends AppCompatActivity {
    TextView pantalla;
    String operacion = "";

    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_main);

        pantalla = findViewById(R.id.pantalla);
    }

    public void onClickNumero(View v) {
        Button btn = (Button) v;
        operacion += btn.getText().toString();
        pantalla.setText(operacion);
    }

    public void onClickOperador(View v) {
        if (!operacion.equals("")) {
            Button btn = (Button) v;
            operacion += btn.getText().toString();
            pantalla.setText(operacion);
        }
    }

    public void onClickIgual(View v) {
        if (!operacion.equals("")) {
            String[] terminos = operacion.split("[+\\-X/]");
            if (terminos.length == 2) {
                double num1 = Double.parseDouble(terminos[0]);
                double num2 = Double.parseDouble(terminos[1]);
                char operador = operacion.charAt(terminos[0].length());

                double resultado;
                switch (operador) {
                    case '+':
                        resultado = num1 + num2;
                        break;
                    case '-':
                        resultado = num1 - num2;
                        break;
                    case 'X':
                        resultado = num1 * num2;
                        break;
                    case '/':
                        resultado = num1 / num2;
                        break;
                    default:
                        resultado = 0; //
                        break;
                }

                operacion = String.valueOf(resultado);
                pantalla.setText(operacion);
            }
        }
    }

    public void onClickReset(View v) {
        operacion = "";
        pantalla.setText("0");
    }
}
