package com.example.myapplication;

import android.content.ContentValues;
import android.content.Context;
import android.database.sqlite.SQLiteDatabase;
import android.database.sqlite.SQLiteOpenHelper;

import androidx.annotation.Nullable;

public class DB extends SQLiteOpenHelper {

    private static final int DATABASE_VERSION = 1;
    private static final String DATABASE_NOMBRE = "Pizzeria";
    public static final String TABLE_CLIENTES = "t_clientes";

    public DB(@Nullable Context context) {
        super(context, DATABASE_NOMBRE, null, DATABASE_VERSION);
    }

    @Override
    public void onCreate(SQLiteDatabase db) {
        db.execSQL("CREATE TABLE " + TABLE_CLIENTES + "(" +
                "id INTEGER PRIMARY KEY AUTOINCREMENT," +
                "nombre TEXT NOT NULL," +
                "contrasena TEXT NOT NULL)");

        insertarCliente(db, "AntonioJuan", "1234");
    }

    @Override
    public void onUpgrade(SQLiteDatabase db, int oldVersion, int newVersion) {

    }

    private void insertarCliente(SQLiteDatabase db, String nombre, String contrasena) {
        ContentValues Cvalues = new ContentValues();
        Cvalues.put("nombre", nombre);
        Cvalues.put("contrasena", contrasena);
        db.insert(TABLE_CLIENTES, null, Cvalues);
    }
}
