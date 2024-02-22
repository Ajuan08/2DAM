package com.example.caidaobjetos2;

import android.graphics.Bitmap;
import android.graphics.Canvas;

public class Sprite {
    private Bitmap bitmap;
    private int x = 0, y = 1380;
    private int width;
    private int height;

    public int getX() {
        return x;
    }

    public int getY() {
        return y;
    }

    private MoverFiguras moverFiguras;

    public Sprite(Bitmap bitmap, MoverFiguras moverFiguras) {
        this.bitmap = bitmap;
        this.width = bitmap.getWidth();
        this.height = bitmap.getHeight();
        this.moverFiguras = moverFiguras;

    }

    public void draw(Canvas canvas) {
        canvas.drawBitmap(bitmap, x, y, null);
    }

    public void move(float deltaX) {
        int newX = x + (int) deltaX;
        int LimiteIzq = 0;
        int LimiteDer = moverFiguras.getWidth() - width;
        if (newX >= LimiteIzq && newX <= LimiteDer) {
            x = newX;
        } else if (newX < LimiteIzq) {
            x = LimiteIzq;
        } else {
            x = LimiteDer;
        }
    }


}
