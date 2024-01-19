package com.example.examenacdatrecu;

import android.content.ContentValues;
import android.content.Context;
import android.database.Cursor;
import android.database.sqlite.SQLiteDatabase;
import android.database.sqlite.SQLiteOpenHelper;

import androidx.annotation.Nullable;

import java.util.ArrayList;
import java.util.List;

public class DB extends SQLiteOpenHelper {

    private static final int DATABASE_VERSION = 1;
    private static final String DATABASE_NOMBRE = "RepasoACDAT";
    public static final String TABLE_PALABRAS = "t_nombre";
    private List<String> listaPalabras;

    public DB(@Nullable Context context) {
        super(context, DATABASE_NOMBRE, null, DATABASE_VERSION);
    }

    @Override
    public void onCreate(SQLiteDatabase db) {
        db.execSQL("CREATE TABLE " + TABLE_PALABRAS + "(" +
                "id INTEGER PRIMARY KEY AUTOINCREMENT," +
                "nombre TEXT NOT NULL)");

        insertarPalabra(db, "HOLA ESTO ES UNA CITA");
        insertarPalabra(db, "hola esto es otra cita");
        insertarPalabra(db, "Prueba de cita");
        insertarPalabra(db, "CITA 4");
        insertarPalabra(db, "CITA 5");

    }

    @Override
    public void onUpgrade(SQLiteDatabase db, int oldVersion, int newVersion) {

    }

    public List getPalabras(SQLiteDatabase db) {
        Cursor cursor = db.rawQuery("SELECT * FROM " + TABLE_PALABRAS, null);
        listaPalabras = new ArrayList<>();

        if (cursor.moveToFirst()) {
            do {
                String pablabra = cursor.getString(cursor.getColumnIndex("nombre"));

                listaPalabras.add(pablabra);
            } while (cursor.moveToNext());
        }
        return listaPalabras;
    }

    public List borrarTodosDatos(SQLiteDatabase db) {
        Cursor cursor = db.rawQuery("DELETE FROM " + TABLE_PALABRAS, null);
        listaPalabras = new ArrayList<>();

        if (cursor.moveToFirst()) {
            do {
                String pablabra = cursor.getString(cursor.getColumnIndex("nombre"));

                listaPalabras.add(pablabra);
            } while (cursor.moveToNext());
        }
        return listaPalabras;
    }

    public List getPalabrasN(SQLiteDatabase db, int conf) {
        Cursor cursor = db.rawQuery("SELECT * FROM " + TABLE_PALABRAS + " LIMIT " + conf, null);
        listaPalabras = new ArrayList<>();
        if (cursor.moveToFirst()) {
            do {
                String pablabra = cursor.getString(cursor.getColumnIndex("nombre"));

                listaPalabras.add(pablabra);
            } while (cursor.moveToNext());
        }
        return listaPalabras;
    }



    public void insertarPalabra(SQLiteDatabase db, String nombre) {
        ContentValues values = new ContentValues();
        values.put("nombre", nombre);
        db.insert(TABLE_PALABRAS, null, values);
    }

    public void borrarPalabra(SQLiteDatabase db, String nombre) {
        db.delete(TABLE_PALABRAS, "nombre=?", new String[]{nombre});
    }

}
