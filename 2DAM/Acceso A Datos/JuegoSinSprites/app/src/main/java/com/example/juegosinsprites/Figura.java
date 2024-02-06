package com.example.juegosinsprites;

import android.graphics.Canvas;
import android.graphics.Paint;

public abstract class Figura {
    protected float x, y;

    public Figura(float x, float y) {
        this.x = x;
        this.y = y;
    }

    public abstract boolean isHovered(float x, float y);

    public abstract void onDraw(Canvas canvas, Paint paint);
}
