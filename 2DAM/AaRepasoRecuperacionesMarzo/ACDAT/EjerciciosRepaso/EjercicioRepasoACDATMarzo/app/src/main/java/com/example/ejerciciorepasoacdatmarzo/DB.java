package com.example.ejerciciorepasoacdatmarzo;

import static android.content.Context.MODE_PRIVATE;

import android.content.ContentValues;
import android.content.Context;
import android.content.SharedPreferences;
import android.database.Cursor;
import android.database.sqlite.SQLiteDatabase;
import android.database.sqlite.SQLiteOpenHelper;
import android.preference.PreferenceManager;

import androidx.annotation.Nullable;

import java.util.ArrayList;
import java.util.List;

public class DB extends SQLiteOpenHelper {

    private static final int DATABASE_VERSION = 1;
    private static final String DATABASE_NOMBRE = "RepasoACDATMarzo";
    public static final String NOMBRE_TABLA = "t_personas";
    private List<String> listaPersonas;

    public DB(@Nullable Context context) {
        super(context, DATABASE_NOMBRE, null, DATABASE_VERSION);
    }

    @Override
    public void onCreate(SQLiteDatabase db) {
        db.execSQL("CREATE TABLE " + NOMBRE_TABLA + "(" +
                "id INTEGER PRIMARY KEY AUTOINCREMENT," +
                "nombre TEXT NOT NULL," +
                "edad INTEGER NOT NULL," +
                "estadoPersona TEXT NOT NULL)");

        insertarPersonaPredeterminados(db, "Antonio Juan" , 22, "Muy buena");
        insertarPersonaPredeterminados(db, "Silvia",21, "Muy buena");

    }

    @Override
    public void onUpgrade(SQLiteDatabase db, int oldVersion, int newVersion) {

    }

    public void insertarPersona(SQLiteDatabase db, String nombre, int edad) {
        ContentValues values = new ContentValues();
        values.put("nombre", nombre);
        values.put("edad", edad);
        values.put("estadoPersona", "Mala");
        db.insert(NOMBRE_TABLA, null, values);
    }

    public void insertarPersonaPredeterminados(SQLiteDatabase db, String nombre, int edad, String estadoPersona) {
        ContentValues values = new ContentValues();
        values.put("nombre", nombre);
        values.put("edad", edad);
        values.put("estadoPersona", estadoPersona);
        db.insert(NOMBRE_TABLA, null, values);
    }

    public void borrarPersona(SQLiteDatabase db, String nombre, int edad) {
        db.delete(NOMBRE_TABLA, "nombre = ? AND edad = ?", new String[]{nombre, String.valueOf(edad)});
    }

   public void modificarPersona(SQLiteDatabase db, String nombre, int edad, String nuevoNombre, int nuevaEdad) {
        ContentValues values = new ContentValues();
        values.put("nombre", nuevoNombre);
        values.put("edad", nuevaEdad);
        db.update(NOMBRE_TABLA, values, "nombre = ? AND edad = ?", new String[]{nombre, String.valueOf(edad)});
    }

    public List<String> getPersonas(SQLiteDatabase db) {
        listaPersonas = new ArrayList<>();
        Cursor cursor = db.rawQuery("SELECT * FROM " + NOMBRE_TABLA, null);
        if (cursor.moveToFirst()) {
            do {
                listaPersonas.add("Nombre: "+ cursor.getString(1) + "\n"+ " Edad: " + cursor.getInt(2)+ "\n"+ " Estado: " + cursor.getString(3));

            } while (cursor.moveToNext());
        }
        return listaPersonas;
    }

    public List<String> getPersonasNombre(SQLiteDatabase db) {
        listaPersonas = new ArrayList<>();
        Cursor cursor = db.rawQuery("SELECT * FROM " + NOMBRE_TABLA, null);
        if (cursor.moveToFirst()) {
            do {
                listaPersonas.add(cursor.getString(1));
            } while (cursor.moveToNext());
        }
        return listaPersonas;
    }




}