package com.example.examenandroid;

import android.content.ContentValues;
import android.content.Context;
import android.database.Cursor;
import android.database.sqlite.SQLiteDatabase;
import android.database.sqlite.SQLiteOpenHelper;

import androidx.annotation.Nullable;

import java.util.ArrayList;
import java.util.List;

public class DB extends SQLiteOpenHelper {
    private static final String DATABASE_NAME = "db_brainTest2.db";
    private static final int DATABASE_VERSION = 1;

    public DB(Context context) {
        super(context, DATABASE_NAME, null, DATABASE_VERSION);
    }

    @Override
    public void onCreate(SQLiteDatabase db) {
        String createPalabrasQuery = "CREATE TABLE IF NOT EXISTS palabras ("
                + "id INTEGER PRIMARY KEY AUTOINCREMENT, "
                + "nombre TEXT)";
        db.execSQL(createPalabrasQuery);
        insertPalabras(db);
    }

    @Override
    public void onUpgrade(SQLiteDatabase sqLiteDatabase, int i, int i1) {

    }

    private void insertPalabras(SQLiteDatabase db) {
        List<String> palabras = new ArrayList<>();
        palabras.add("belleza");
        palabras.add("basket");
        palabras.add("alarma");
        palabras.add("sufrir");
        palabras.add("café");
        palabras.add("serenidad");
        palabras.add("hojaldre");
        palabras.add("normal");
        palabras.add("codigo");


        for (String palabra : palabras) {
            ContentValues values = new ContentValues();
            values.put("nombre", palabra);

            db.insert("palabras", null, values);
        }
    }

    public List<String> getPalabras() {
        List<String> palabras = new ArrayList<>();

        SQLiteDatabase db = this.getReadableDatabase();
        Cursor cursor = db.query("palabras", null, null, null, null, null, null);

        while (cursor.moveToNext()) {
            String nombre = cursor.getString(cursor.getColumnIndexOrThrow("nombre"));

            palabras.add(nombre);
        }

        cursor.close();
        db.close();

        return palabras;
    }
}