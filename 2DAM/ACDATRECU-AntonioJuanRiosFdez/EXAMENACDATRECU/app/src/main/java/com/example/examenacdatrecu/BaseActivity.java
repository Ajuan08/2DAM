package com.example.examenacdatrecu;

import androidx.appcompat.app.AppCompatActivity;

import android.content.SharedPreferences;
import android.database.sqlite.SQLiteDatabase;
import android.os.Bundle;

public abstract class BaseActivity extends AppCompatActivity {

    SQLiteDatabase dbRead;
    SQLiteDatabase dbWrite;
    DB db;

    int conf;
    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(getLayoutRes());
        db = new DB(this);
        dbRead = new DB(this).getReadableDatabase();
        dbWrite = new DB(this).getWritableDatabase();
        //conf = getConf();
    }

    protected abstract int getLayoutRes();


    public void guardarValoracion(String valoracion) {
        SharedPreferences sharedPreferences = getSharedPreferences("valoraciones", MODE_PRIVATE);
        SharedPreferences.Editor editor = sharedPreferences.edit();
        editor.putString("valoracion", valoracion);
        editor.apply();
    }


    public void guardarConf(int conf) {
        SharedPreferences sharedPreferences = getSharedPreferences("configuracion", MODE_PRIVATE);
        SharedPreferences.Editor editor = sharedPreferences.edit();
        editor.putInt("configuracion", conf);
        editor.apply();
    }

    int getConf() {
        SharedPreferences sharedPreferences = getSharedPreferences("configuracion", MODE_PRIVATE);
        return sharedPreferences.getInt("configuracion", 1);
    }

    
}