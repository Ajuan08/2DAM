package com.example.caidaobjetos2;

import android.graphics.Bitmap;
import android.graphics.Canvas;

public class Sprite {
    private MoverFiguras moverFiguras;
    private Bitmap bmp;
    private int x, y;
    private int speedX;

    public Sprite(MoverFiguras moverFiguras, Bitmap bmp) {
        this.moverFiguras = moverFiguras;
        this.bmp = bmp;
        this.x = 0;
        this.y = 0;
        this.speedX = 5;
    }

    public void update() {
        x += speedX;
    }

    public void draw(Canvas canvas) {
        canvas.drawBitmap(bmp, x, y, null);
    }

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
