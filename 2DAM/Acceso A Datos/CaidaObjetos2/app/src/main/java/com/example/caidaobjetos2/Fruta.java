package com.example.caidaobjetos2;

import android.graphics.Bitmap;
import android.graphics.Canvas;
import android.util.Log;

import java.util.ArrayList;
import java.util.List;
import java.util.Random;

public class Fruta {
    private Bitmap bitmap;

    //Min 10 Max 800
    private int x = 0, y = 20;
    private int width;
    private int height;

    public int getX() {
        return x;
    }

    public int getY() {
        return y;
    }

    private MoverFiguras moverFiguras;

    private boolean esPelota;

    public Fruta(Bitmap bitmap, MoverFiguras moverFiguras, boolean esPelota) {
        this.bitmap = bitmap;
        this.width = bitmap.getWidth();
        this.height = bitmap.getHeight();
        this.moverFiguras = moverFiguras;
        this.esPelota = esPelota;
        Random random = new Random();
        x = random.nextInt((800-10)+1)+10;

    }

    public void draw(Canvas canvas) {
        canvas.drawBitmap(bitmap, x, y, null);
    }

    public boolean caidaFruta(float xCesta, float yCesta, ArrayList<Fruta> frutasAnadir, ArrayList<Fruta> frutaPorSalir) {
        y += Constants.VelocidadCaida;
        if (y > moverFiguras.getHeight()) {
            Random random = new Random();
            x = random.nextInt((800-10)+1)+10;
            y = 20;
        }
        if(isCollition(xCesta, yCesta)) {
            Random random = new Random();
            y = 20;
            if (Constants.VelocidadCaida < Constants.VelocidadMaxima) {
                Constants.VelocidadCaida += 1;
            }
            if (Constants.numeroLista < frutaPorSalir.size() - 1) {
                frutasAnadir.add(frutaPorSalir.get(Constants.numeroLista));
                Constants.numeroLista++;
            }
            x = random.nextInt((800 - 10) + 1) + 30;
            Constants.puntuacion++;

            if (esPelota) {
                return false;
            }
        }
            return true;
    }
    public boolean isCollition(float xCesta, float yCesta) {
        return (xCesta + width > x && xCesta + width < x + width) && (yCesta + height > y && yCesta + height < y + height) || (xCesta > x && xCesta < x + width) && (yCesta + height > y && yCesta + height < y + height);
    }

}
