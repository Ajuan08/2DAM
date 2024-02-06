package com.example.juegosinsprites;

import android.graphics.Canvas;
import android.view.SurfaceHolder;

public class GameThread extends Thread {
    private SurfaceHolder surfaceHolder;
    private MoverFiguras moverFiguras;
    private boolean run;

    static final long FPS = 10;

    public GameThread(SurfaceHolder surfaceHolder, MoverFiguras moverFiguras) {
        this.surfaceHolder = surfaceHolder;
        this.moverFiguras = moverFiguras;
        run = false;
    }

    public void setRunning(boolean run) {
        this.run = run;
    }

    public void run() {
        Canvas canvas;
        long ticksPS = 1000 / FPS;
        long startTime;
        long sleepTime;

        while (run) {
            canvas = null;
            startTime = System.currentTimeMillis();

            try {
                canvas = surfaceHolder.lockCanvas(null);

                synchronized (surfaceHolder) {
                    moverFiguras.postInvalidate();
                }

            } finally {
                if (canvas != null) {
                    surfaceHolder.unlockCanvasAndPost(canvas);
                }
            }
            sleepTime = ticksPS - (System.currentTimeMillis() - startTime);
            try {
                if (sleepTime > 0) {
                    sleep(sleepTime);
                } else {
                    sleep(10);
                }
            } catch (Exception e) {
                e.printStackTrace();
            }
        }
        moverFiguras.postInvalidate();
    }
}

