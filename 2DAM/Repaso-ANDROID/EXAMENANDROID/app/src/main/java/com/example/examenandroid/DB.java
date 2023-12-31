package com.example.examenandroid;

import android.content.ContentValues;
import android.content.Context;
import android.database.sqlite.SQLiteDatabase;
import android.database.sqlite.SQLiteOpenHelper;

import androidx.annotation.Nullable;

public class DB extends SQLiteOpenHelper {

    private static final int DATABASE_VERSION = 1;
    private static final String DATABASE_NOMBRE = "BrainTest";
    public static final String TABLE_PALABRAS = "t_palabras";

    public DB(@Nullable Context context) {
        super(context, DATABASE_NOMBRE, null, DATABASE_VERSION);
    }

    @Override
    public void onCreate(SQLiteDatabase db) {
        db.execSQL("CREATE TABLE " + TABLE_PALABRAS + "(" +
                "palabra TEXT NOT NULL)");

        insertarPalabra(db, "belleza");
        insertarPalabra(db, "basket");
        insertarPalabra(db, "alarma");
        insertarPalabra(db, "sufrir");
        insertarPalabra(db, "café");
        insertarPalabra(db, "serenidad");
        insertarPalabra(db, "hojaldre");
        insertarPalabra(db, "normal");
        insertarPalabra(db, "codigo");
    }

    @Override
    public void onUpgrade(SQLiteDatabase db, int oldVersion, int newVersion) {

    }

    private void insertarPalabra(SQLiteDatabase db, String palabra) {
        ContentValues Cvalues = new ContentValues();
        Cvalues.put("palabra", palabra);
        db.insert(TABLE_PALABRAS, null, Cvalues);
    }
}
