package com.example.caidaobjetos2;

import android.graphics.Bitmap;
import android.graphics.Canvas;

public class Sprite {
    private Bitmap bitmap;
    private int x, y;
    private int speedX = 10;

    public Sprite(Bitmap bitmap) {
        this.bitmap = bitmap;
        this.x = 0;
        this.y = 1300;
    }

    public void update() {
        x += speedX;
    }

    public void draw(Canvas canvas) {
        canvas.drawBitmap(bitmap, x, y, null);
    }

    public void move(float deltaX) {
        x += deltaX;
    }
}
