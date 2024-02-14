package com.example.caidaobjetos2;

import android.graphics.Canvas;
import android.view.SurfaceHolder;

public class GameThread extends Thread {
    private SurfaceHolder surfaceHolder;
    private MoverFiguras moverFiguras;
    private boolean isRunning;

    public GameThread(SurfaceHolder surfaceHolder, MoverFiguras moverFiguras) {
        this.surfaceHolder = surfaceHolder;
        this.moverFiguras = moverFiguras;
        isRunning = false;
    }

    public void setRunning(boolean isRunning) {
        this.isRunning = isRunning;
    }

    @Override
    public void run() {
        Canvas canvas;

        while (isRunning) {
            canvas = null;

            try {
                canvas = surfaceHolder.lockCanvas(null);
                synchronized (surfaceHolder) {
                    if (canvas != null) {

                        moverFiguras.postInvalidate();
                        moverFiguras.draw(canvas);


                    }
                }
            } finally {
                if (canvas != null) {
                    surfaceHolder.unlockCanvasAndPost(canvas);
                }
            }
        }
    }
}
