package com.example.juegoconsprite;

import android.content.Context;
import android.graphics.Bitmap;
import android.graphics.BitmapFactory;
import android.graphics.Canvas;
import android.graphics.Color;
import android.graphics.Paint;
import android.graphics.Path;
import android.view.MotionEvent;
import android.view.SurfaceHolder;
import android.view.SurfaceView;

import androidx.annotation.NonNull;

import java.util.ArrayList;
import java.util.List;

public class MoverFiguras extends SurfaceView implements SurfaceHolder.Callback {
    private GameThread gameThread;

    private Bitmap bmp;
    private Sprite sprite;
    private Rectangulo rectangulo;
    private Circulo circulo;
    private Linea linea;
    private Paint paint;
    private Paint linePaint;
    private long lastClick;
    private List<Figura> figuras = new ArrayList<>();
    private List<Sprite> sprites = new ArrayList<Sprite>();
    private List<Sangre> sang = new ArrayList<Sangre>();
    private Bitmap bmpsangre;


    public MoverFiguras(Context context) {
        super(context);

        getHolder().addCallback(this);
        rectangulo = new Rectangulo(200, 400, 700, 500);
        figuras.add(rectangulo);

        circulo = new Circulo(100, 100, 100);
        figuras.add(circulo);

        linea = new Linea();

        paint = new Paint();
        linePaint = new Paint();
        setBackgroundColor(Color.BLACK);
    }

    @Override
    protected void onDraw(Canvas canvas) {
        super.onDraw(canvas);
        sprite.onDraw(canvas);
        canvas.drawColor(Color.BLACK);
        for(Sprite sprite : sprites){
            sprite.onDraw(canvas);
        }
        for(int i = sang.size() - 1; i >= 0; i--) {
            sang.get(i).onDraw(canvas);
        }

    }

    @Override
    public boolean onTouchEvent(MotionEvent event) {
        if(System.currentTimeMillis() - lastClick > 500) {
            lastClick = System.currentTimeMillis();
            synchronized (getHolder()) {
                for (int i = sprites.size() - 1; i >= 0; i--) {
                    Sprite sprite = sprites.get(i);
                    if (sprite.isCollition(event.getX(), event.getY())) {
                        sprites.remove(sprite);
                        sprites.add(createSprites(R.drawable.bad1));
                        sang.add(new Sangre(sang, this, event.getX(), event.getY(), bmpsangre));
                        //sprites.add(createSprites(R.drawable.bad2));
                        //sprites.add(createSprites(R.drawable.bad3));
                        break;
                    }
                }
            }
        }
        switch (event.getAction()) {
            case MotionEvent.ACTION_DOWN:
                for (Figura figura : figuras) {
                    if (figura.isHovered(event.getX(), event.getY())) {
                        figura.setxInicial(event.getX());
                        figura.setyInicial(event.getY());
                    }
                }

                linea.guardarPuntoInicial(event.getX(), event.getY());
                break;
            case MotionEvent.ACTION_MOVE:
                for (Figura figura : figuras) {
                    figura.mover(event.getX(), event.getY());
                }

                linea.guardarPunto(event.getX(), event.getY());
                break;
            case MotionEvent.ACTION_CANCEL:
                break;
            case MotionEvent.ACTION_UP:
                for (Figura figura : figuras) {
                    figura.setxInicial(null);
                    figura.setyInicial(null);
                }

                break;
        }

        return true;
    }

    @Override
    public void surfaceCreated(@NonNull SurfaceHolder surfaceHolder) {
        gameThread = new GameThread(getHolder(), this);
        gameThread.setRunning(true);
        gameThread.start();
        bmp = BitmapFactory.decodeResource(getResources(), R.drawable.bad1);
        bmpsangre = BitmapFactory.decodeResource(getResources(), R.drawable.blood1);
        sprite = new Sprite(this, bmp);
        createSprites();
    }

    @Override
    public void surfaceChanged(@NonNull SurfaceHolder surfaceHolder, int i, int i1, int i2) {

    }

    @Override
    public void surfaceDestroyed(@NonNull SurfaceHolder surfaceHolder) {
        boolean retry = true;
        gameThread.setRunning(false);

        while(retry) {
            try {
                gameThread.join();
                retry = false;
            } catch (InterruptedException e) {

            }
        }
    }

    public void createSprites(){
       sprites.add(createSprites(R.drawable.bad1));
        sprites.add(createSprites(R.drawable.bad2));
        sprites.add(createSprites(R.drawable.bad3));
    }

    private Sprite createSprites(int resouce){
        bmp = BitmapFactory.decodeResource(getResources(), resouce);
        return new Sprite(this, bmp);
    }
}
