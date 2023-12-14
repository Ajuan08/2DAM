package com.example.examenandroid;

import android.content.Context;
import android.content.SharedPreferences;

public class Palabras {
    private String Nombre;
    private SharedPreferences archivoPalabras;

    public Palabras(Context context, String nombre) {
        guardarPalabra(context, nombre);
    }

    public void guardarPalabra(Context context, String usuario) {
        archivoPalabras = context.getSharedPreferences("DatosUsuario", Context.MODE_PRIVATE);
        SharedPreferences.Editor editor = archivoPalabras.edit();
        editor.putString("Usuario", usuario);
        editor.apply();
    }
}
