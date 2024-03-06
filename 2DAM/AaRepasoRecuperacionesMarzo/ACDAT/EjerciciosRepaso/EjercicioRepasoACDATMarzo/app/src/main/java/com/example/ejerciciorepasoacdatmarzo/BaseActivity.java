package com.example.ejerciciorepasoacdatmarzo;

import android.content.SharedPreferences;
import android.database.sqlite.SQLiteDatabase;
import android.os.Bundle;
import android.view.View;

import androidx.appcompat.app.AppCompatActivity;

public abstract class BaseActivity extends AppCompatActivity {

    SQLiteDatabase dbRead;
    SQLiteDatabase dbWrite;
    DB db;

    public int color1 = R.color.colorFondo1;
    public int color2 = R.color.colorFondo2;

    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(getLayoutRes());
        db = new DB(this);
        dbRead = new DB(this).getReadableDatabase();
        dbWrite = new DB(this).getWritableDatabase();

        int colorFondo = getColorFondo();
        changeBackgroundColor(colorFondo);

    }

    protected boolean isColorFondo2() {
        return getBackgroundColorPreference();
    }

    private int getColorFondo() {
        return isColorFondo2() ? color2 : color1;
    }

    protected void changeBackgroundColor(int color) {
        View contentView = findViewById(android.R.id.content);
        if (contentView != null) {
            contentView.setBackgroundColor(getColor(color));
        }
    }

    public void saveBackgroundColorPreference(boolean esColor1) {
        SharedPreferences sharedPreferences = getSharedPreferences("configuracion", MODE_PRIVATE);
        SharedPreferences.Editor editor = sharedPreferences.edit();
        editor.putBoolean("esColor1", esColor1);
        editor.apply();
    }

    boolean getBackgroundColorPreference() {
        SharedPreferences sharedPreferences = getSharedPreferences("configuracion", MODE_PRIVATE);
        return sharedPreferences.getBoolean("esColor1", false);
    }

    protected abstract int getLayoutRes();




}
