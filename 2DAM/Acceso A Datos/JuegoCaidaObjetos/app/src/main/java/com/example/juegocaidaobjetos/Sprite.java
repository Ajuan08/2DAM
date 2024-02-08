package com.example.juegocaidaobjetos;

import android.graphics.Bitmap;
import android.graphics.Canvas;

import com.example.juegocaidaobjetos.MoverFiguras;

public class Sprite {
    private MoverFiguras moverFiguras;
    private Bitmap bmp;
    private int x, y;
    private int speedX;

    public Sprite(MoverFiguras moverFiguras, Bitmap bmp) {
        this.moverFiguras = moverFiguras;
        this.bmp = bmp;
        this.x = 0; // Establece la posición inicial en (0, 0)
        this.y = 0;
        this.speedX = 5;
    }

    public void update() {
        x += speedX;
    }

    public void draw(Canvas canvas) {
        canvas.drawBitmap(bmp, x, y, null);
    }

    // Métodos getters y setters para la posición x e y
    public int getX() {
        return x;
    }

    public void setX(int x) {
        this.x = x;
    }

    public int getY() {
        return y;
    }

    public void setY(int y) {
        this.y = y;
    }
}
