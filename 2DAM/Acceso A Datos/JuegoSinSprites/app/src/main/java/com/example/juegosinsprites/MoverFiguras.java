package com.example.juegosinsprites;

import android.content.Context;
import android.graphics.Canvas;
import android.graphics.Color;
import android.graphics.Paint;
import android.util.AttributeSet;
import android.view.MotionEvent;
import android.view.SurfaceHolder;
import android.view.SurfaceView;
import android.widget.TextView;

import java.util.ArrayList;
import java.util.List;
import java.util.Random;

public class MoverFiguras extends SurfaceView implements SurfaceHolder.Callback {
    private List<Figura> figuras = new ArrayList<>();
    private GameThread gameThread;
    private Paint paint;
    private TextView scoreTextView;
    private int score = 0;

    public MoverFiguras(Context context, AttributeSet attrs) {
        super(context, attrs);
        getHolder().addCallback(this);

        paint = new Paint();
        paint.setColor(Color.BLACK);
        paint.setStyle(Paint.Style.STROKE);
    }

    @Override
    protected void onDraw(Canvas canvas) {
        super.onDraw(canvas);
        canvas.drawRect(0, 0, getWidth(), getHeight(), paint);

        for (Figura figura : figuras) {
            figura.onDraw(canvas, paint);
        }
    }

    @Override
    public boolean onTouchEvent(MotionEvent event) {
        return true;
    }

    @Override
    public void surfaceCreated(SurfaceHolder holder) {
        gameThread = new GameThread(getHolder(), this);
        gameThread.setRunning(true);
        gameThread.start();
    }

    @Override
    public void surfaceChanged(SurfaceHolder holder, int format, int width, int height) {}

    @Override
    public void surfaceDestroyed(SurfaceHolder holder) {
        boolean retry = true;
        gameThread.setRunning(false);
        while (retry) {
            try {
                gameThread.join();
                retry = false;
            } catch (InterruptedException e) {
                e.printStackTrace();
            }
        }
    }

    public void agregarFiguraAleatoria() {
        Random random = new Random();
        boolean relleno = random.nextBoolean();
        float x = random.nextFloat() * getWidth();
        float y = random.nextFloat() * getHeight();
        float radio = random.nextFloat() * 100 + 50; // Radio entre 50 y 150

        Figura figura;
        if (relleno) {
            figura = new Circulo(x, y, radio);
            score += 10;
        } else {
            figura = new CirculoSinRelleno(x, y, radio);
            score += 5;
        }

        figuras.add(figura);

        invalidate();

        if (scoreTextView != null) {
            scoreTextView.setText("Puntuación: " + score);
        }
    }


    public void setScoreTextView(TextView scoreTextView) {
        this.scoreTextView = scoreTextView;
    }
}


