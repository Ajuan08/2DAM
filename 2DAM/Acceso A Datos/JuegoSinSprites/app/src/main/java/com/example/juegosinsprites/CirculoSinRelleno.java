package com.example.juegosinsprites;

import android.graphics.Canvas;
import android.graphics.Color;
import android.graphics.Paint;

public class CirculoSinRelleno extends Figura {
    private float radio;

    public CirculoSinRelleno(float x, float y, float radio) {
        super(x, y);
        this.radio = radio;
    }

    @Override
    public boolean isHovered(float x, float y) {
        return false;
    }

    @Override
    public void onDraw(Canvas canvas, Paint paint) {
        paint.setColor(Color.BLUE);
        paint.setStyle(Paint.Style.STROKE);
        canvas.drawCircle(x, y, radio, paint);
    }
}

