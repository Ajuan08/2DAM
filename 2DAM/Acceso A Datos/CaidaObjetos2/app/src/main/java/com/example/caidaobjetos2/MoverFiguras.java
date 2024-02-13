package com.example.caidaobjetos2;

import android.content.Context;
import android.graphics.Bitmap;
import android.graphics.BitmapFactory;
import android.graphics.Canvas;
import android.util.AttributeSet;
import android.util.Log;
import android.view.MotionEvent;
import android.view.SurfaceHolder;
import android.view.SurfaceView;

public class MoverFiguras extends SurfaceView implements SurfaceHolder.Callback {
    private Sprite sprite;
    private GameThread gameThread;

    // Variables para rastrear la posición anterior del toque
    private float previousX;
    private float previousY;

    public MoverFiguras(Context context) {
        super(context);
        init(context);
    }

    public MoverFiguras(Context context, AttributeSet attrs) {
        super(context, attrs);
        init(context);
    }

    public MoverFiguras(Context context, AttributeSet attrs, int defStyle) {
        super(context, attrs, defStyle);
        init(context);
    }

    private void init(Context context) {
        getHolder().addCallback(this);

        Bitmap originalBitmap = BitmapFactory.decodeResource(getResources(), R.drawable.cesta);
        int newWidth = originalBitmap.getWidth() / 4;
        int newHeight = originalBitmap.getHeight() / 4;
        Bitmap scaledBitmap = Bitmap.createScaledBitmap(originalBitmap, newWidth, newHeight, true);
        sprite = new Sprite(scaledBitmap);
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

    @Override
    public void draw(Canvas canvas) {
        super.draw(canvas);
        sprite.draw(canvas);
    }

    public void update() {
        sprite.update();
    }

    @Override
    public boolean onTouchEvent(MotionEvent event) {
        switch (event.getAction()) {
            case MotionEvent.ACTION_DOWN:
                Log.d("MoverFiguras", "Clic recibido en X: " + event.getX());
                previousX = event.getX();
                break;
            case MotionEvent.ACTION_MOVE:
                float currentX = event.getX();
                float deltaX = currentX - previousX;

                sprite.move(deltaX);

                previousX = currentX;
                break;
        }
        return true;
    }


}
