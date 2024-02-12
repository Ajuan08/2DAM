package com.example.caidaobjetos2;

import android.content.Context;
import android.graphics.Bitmap;
import android.graphics.BitmapFactory;
import android.view.SurfaceHolder;
import android.view.SurfaceView;

public class MoverFiguras extends SurfaceView implements SurfaceHolder.Callback {
    private Sprite sprite;
    private SurfaceHolder holder;
    private GameThread drawThread;

    private Bitmap bmp;

    public MoverFiguras(Context context) {
        super(context);
        holder = getHolder();
        holder.addCallback(this);
    }

    @Override
    public void surfaceCreated(SurfaceHolder holder) {
        drawThread = new GameThread(holder, this);
        drawThread.setRunning(true);
        drawThread.start();
        Bitmap spriteBitmap = BitmapFactory.decodeResource(getResources(), R.drawable.cesta);
        sprite = new Sprite(this, spriteBitmap);
    }

    @Override
    public void surfaceChanged(SurfaceHolder holder, int format, int width, int height) {
    }

    @Override
    public void surfaceDestroyed(SurfaceHolder holder) {
        boolean retry = true;
        drawThread.setRunning(false);
        while (retry) {
            try {
                drawThread.join();
                retry = false;
            } catch (InterruptedException e) {
                e.printStackTrace();
            }
        }
    }
}

