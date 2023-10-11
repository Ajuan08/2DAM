package com.example.listaconbotones;

import android.os.Bundle;
import android.view.View;
import android.widget.Button;
import android.widget.TextView;

import androidx.appcompat.app.AppCompatActivity;
public class Botones {

    private  Integer count = 0;


    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_main);

    }


    public void onClickSumar(){
        TextView txt = findViewById(R.id.numeroAcambiar);
        count++;
        txt.setText(count.toString());
    }

    public void onClickRestar(){
        TextView txt = findViewById(R.id.numeroAcambiar);
        count--;
        txt.setText(count.toString());
    }

    public void onClickReset(){
        TextView txt = findViewById(R.id.numeroAcambiar);
        count = 0;
        txt.setText(count.toString());
    }


    @Override
    public void onClick(View view) {

        if (view.getId() == R.id.btnSumar){
            onClickSumar();
        } else if (view.getId() == R.id.btnRestar) {
            onClickRestar();
        }else if(view.getId() == R.id.btnReset){
            onClickReset();
        }

    }
}
