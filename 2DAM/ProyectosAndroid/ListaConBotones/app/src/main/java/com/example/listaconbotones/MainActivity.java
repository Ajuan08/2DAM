package com.example.listaconbotones;

import androidx.appcompat.app.AppCompatActivity;

import android.os.Bundle;
import android.view.View;
import android.widget.TextView;

public class MainActivity extends AppCompatActivity implements View.OnClickListener {

    private  Integer count = 0;
    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_main);

    }

    @Override
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