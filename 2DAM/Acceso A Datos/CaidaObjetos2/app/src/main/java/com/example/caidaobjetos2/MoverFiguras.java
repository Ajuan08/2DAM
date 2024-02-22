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

import java.util.ArrayList;
import java.util.List;

public class MoverFiguras extends SurfaceView implements SurfaceHolder.Callback {
    private Sprite sprite;
    private GameThread gameThread;
    private float previousX;

    private float xCesta;
    private float yCesta;

    private List<Fruta> frutas = new ArrayList<>();

    private List<Fruta> frutasPorSalir = new ArrayList<>();

    private List<Fruta> frutaAanadir = new ArrayList<>();

    private int TotalLista = 0;

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
        int newWidth = originalBitmap.getWidth() / 5;
        int newHeight = originalBitmap.getHeight() / 5;
        Bitmap scaledBitmap = Bitmap.createScaledBitmap(originalBitmap, newWidth, newHeight, true);
        sprite = new Sprite(scaledBitmap, this);

        Bitmap platanoSprite = BitmapFactory.decodeResource(getResources(), R.drawable.platano);
        int newWidthPlatano = platanoSprite.getWidth() / 7;
        int newHeightPlatano = platanoSprite.getHeight() / 7;
        Bitmap scaledPlatano = Bitmap.createScaledBitmap(platanoSprite, newWidthPlatano, newHeightPlatano, true);
        frutas.add(new Fruta(scaledPlatano, this));

        Bitmap manzanaSprite = BitmapFactory.decodeResource(getResources(), R.drawable.manzana);
        int newWidthManzana = manzanaSprite.getWidth() / 7;
        int newHeightManzana = manzanaSprite.getHeight() / 7;
        Bitmap scaledManzana = Bitmap.createScaledBitmap(manzanaSprite, newWidthManzana, newHeightManzana, true);
        frutasPorSalir.add(new Fruta(scaledManzana, this));

        Bitmap peraSprite = BitmapFactory.decodeResource(getResources(), R.drawable.pera);
        int newWidthPera = peraSprite.getWidth() / 7;
        int newHeightPera = peraSprite.getHeight() / 7;
        Bitmap scaledPera = Bitmap.createScaledBitmap(peraSprite, newWidthPera, newHeightPera, true);
        frutasPorSalir.add(new Fruta(scaledPera, this));

        Bitmap fresaSprite = BitmapFactory.decodeResource(getResources(), R.drawable.fresa);
        int newWidthFresa = fresaSprite.getWidth() / 7;
        int newHeightFresa = fresaSprite.getHeight() / 7;
        Bitmap scaledFresa = Bitmap.createScaledBitmap(fresaSprite, newWidthFresa, newHeightFresa, true);
        frutasPorSalir.add(new Fruta(scaledFresa, this));

        Bitmap pinaSprite = BitmapFactory.decodeResource(getResources(), R.drawable.pina);
        int newWidthPina = pinaSprite.getWidth() / 7;
        int newHeightPina = pinaSprite.getHeight() / 7;
        Bitmap scaledPina = Bitmap.createScaledBitmap(pinaSprite, newWidthPina, newHeightPina, true);
        frutasPorSalir.add(new Fruta(scaledPina, this));

        Bitmap platanoSprite2 = BitmapFactory.decodeResource(getResources(), R.drawable.platano);
        int newWidthPlatano2 = platanoSprite2.getWidth() / 7;
        int newHeightPlatano2 = platanoSprite2.getHeight() / 7;
        Bitmap scaledPlatano2 = Bitmap.createScaledBitmap(platanoSprite2, newWidthPlatano2, newHeightPlatano2, true);
        frutasPorSalir.add(new Fruta(scaledPlatano2, this));

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
        for (Fruta fruta : frutas) {
            fruta.draw(canvas);
            fruta.caidaFruta(sprite.getX(), sprite.getY(), (ArrayList<Fruta>) frutaAanadir, (ArrayList<Fruta>) frutasPorSalir);
        }
        if(TotalLista < frutaAanadir.size()) {
            frutas.add(frutaAanadir.get(TotalLista));
            TotalLista++;
        }
    }

    @Override
    public boolean onTouchEvent(MotionEvent event) {
        switch (event.getAction()) {
            case MotionEvent.ACTION_DOWN:
                Log.d("MoverFiguras", "Click en " + event.getX());
                previousX = event.getX();
                break;
            case MotionEvent.ACTION_MOVE:
                Log.d("MoverFiguras", " Hay movimiento");
                Log.d("MoverFiguras", "Nueva posicion en " + event.getX());
                float currentX = event.getX();
                float deltaX = currentX - previousX;
                sprite.move(deltaX);
                previousX = currentX;
                break;
        }
        return true;
    }
}