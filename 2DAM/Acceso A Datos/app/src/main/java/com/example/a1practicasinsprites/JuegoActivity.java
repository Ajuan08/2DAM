package com.example.a1practicasinsprites;

import android.graphics.Canvas;
import android.graphics.Color;
import android.graphics.Paint;
import android.os.Bundle;
import android.view.MotionEvent;
import android.view.SurfaceHolder;
import android.view.SurfaceView;
import android.view.View;

import androidx.appcompat.app.AppCompatActivity;

import java.util.Random;

public class JuegoActivity extends AppCompatActivity {

    private SurfaceView surfaceView;
    private SurfaceHolder surfaceHolder;

    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_juego);

        surfaceView = findViewById(R.id.surfaceViewJuego);
        surfaceHolder = surfaceView.getHolder();

        surfaceView.setOnTouchListener(new View.OnTouchListener() {
            float startX, startY;

            @Override
            public boolean onTouch(View view, MotionEvent motionEvent) {
                switch (motionEvent.getAction()) {
                    case MotionEvent.ACTION_DOWN:
                        startX = motionEvent.getX();
                        startY = motionEvent.getY();
                        break;
                    case MotionEvent.ACTION_MOVE:
                        float endX = motionEvent.getX();
                        float endY = motionEvent.getY();
                        moveFigure(startX, startY, endX, endY);
                        startX = endX;
                        startY = endY;
                        break;
                }
                return true;
            }
        });

        addRandomFigures();
    }

    private void addRandomFigures() {
        Random random = new Random();
        boolean isRectangulo = random.nextBoolean();
        drawFigure(isRectangulo);
    }

    private void drawFigure(boolean isRectangulo) {
        Canvas canvas = surfaceHolder.lockCanvas();
        if (canvas != null) {
            Paint paint = new Paint();
            paint.setColor(Color.BLACK);
            paint.setStyle(Paint.Style.STROKE);
            paint.setStrokeWidth(5);  // Grosor de los bordes blancos

            // Dibuja el contorno de la figura con bordes blancos
            if (isRectangulo) {
                canvas.drawRect(50, 50, 200, 200, paint);
            } else {
                canvas.drawCircle(150, 150, 100, paint);
            }

            // Dibuja la figura rellena
            paint.setStyle(Paint.Style.FILL);
            paint.setColor(Color.RED);
            if (isRectangulo) {
                canvas.drawRect(250, 50, 400, 200, paint);
            } else {
                canvas.drawCircle(350, 150, 100, paint);
            }

            surfaceHolder.unlockCanvasAndPost(canvas);
        }
    }

    private void moveFigure(float startX, float startY, float endX, float endY) {
        // Implementa la lógica para mover la figura según la interacción con el ratón
    }
}
