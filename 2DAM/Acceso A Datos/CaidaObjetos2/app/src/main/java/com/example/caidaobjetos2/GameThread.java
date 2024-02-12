package com.example.caidaobjetos2;

import android.graphics.Canvas;
import android.view.SurfaceHolder;

public class GameThread extends Thread {
    private SurfaceHolder surfaceHolder;
    private MoverFiguras moverFiguras;
    private boolean run;

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

        while (run) {
            canvas = null;

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
        }
        moverFiguras.postInvalidate();
    }
}
