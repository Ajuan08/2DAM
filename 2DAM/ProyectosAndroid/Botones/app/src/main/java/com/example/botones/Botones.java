package com.example.botones;

import android.os.Bundle;
import android.view.View;
import android.widget.TextView;

import androidx.appcompat.app.AppCompatActivity;

public class Botones extends AppCompatActivity implements  View.OnClickListener {

    private Integer count = 0;

    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_main);
    }

    public void onClickSumar(){
        TextView txt = findViewById(R.id.contador);
        count++;
        txt.setText(count.toString());
    }

    public void onClickRestar(){
        TextView txt = findViewById(R.id.contador);
        count--;
        txt.setText(count.toString());
    }
    public void onClickReset(){
        TextView txt = findViewById(R.id.contador);
        count = 0;
        txt.setText(count.toString());
    }
    @Override
    public void onClick(View view) {

        if (view.getId() == R.id.botonSumar){
            onClickSumar();
        } else if (view.getId() == R.id.botonRestar) {
            onClickRestar();
        }else if(view.getId() == R.id.botonReset){
            onClickReset();
        }
    }
}
