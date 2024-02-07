package com.example.juegoconsprite;

import android.graphics.Bitmap;
import android.graphics.Canvas;
import android.graphics.Rect;

import java.util.ArrayList;
import java.util.List;
import java.util.Random;

public class Sprite {
    private static final int BMP_ROWS = 4;
    private static final int BMP_COLUMNS = 3;
    private static final int MAX_SPEED = 15;
    private int x = 0;
    private int y = 0;
    private int xSpeed = 24;
    private int ySpeed;

    private MoverFiguras moverFiguras;
    private Bitmap bmp;
    private int currentFrame = 0;
    private int width;
    private int height;



    public Sprite(MoverFiguras moverFiguras, Bitmap bmp) {
        this.moverFiguras = moverFiguras;
        this.bmp = bmp;
        this.width = bmp.getWidth() / BMP_COLUMNS;
        this.height = bmp.getHeight() / BMP_ROWS;
        Random rnd = new Random();
        xSpeed = rnd.nextInt(MAX_SPEED * 2) -MAX_SPEED;
        ySpeed = rnd.nextInt(MAX_SPEED * 2) -MAX_SPEED;
    }

    private void update() {

        if (x > moverFiguras.getWidth() - bmp.getWidth() - xSpeed || x + xSpeed < 0) {
            xSpeed = -xSpeed;
        }

        x = x + xSpeed;


        if (y > moverFiguras.getHeight() - bmp.getHeight() - ySpeed || y + ySpeed < 0) {
            ySpeed = -ySpeed;
        }

        y = y + ySpeed;


        currentFrame = ++currentFrame % BMP_COLUMNS;
    }

    public void onDraw(Canvas canvas) {

        update();

        int srcX = currentFrame * width;
        int srcY = getAnimationRow() * height;
        Rect src = new Rect(srcX, srcY, srcX + width, srcY + height);
        Rect dst = new Rect(x, y, x + width, y + height);

        canvas.drawBitmap(bmp, src, dst, null);
    }

    private int getAnimationRow() {
        double dirDouble = (Math.atan2(xSpeed, ySpeed) / (Math.PI / 2) + 2);
        int direction = (int) Math.round(dirDouble) % BMP_ROWS;
        return direction;
    }

    public boolean isCollition(float x2, float y2) {
        return x2 > x && x2 < x + width && y2 > y && y2 < y + height;
    }
}
