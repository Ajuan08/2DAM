package com.example.caidaobjetos2;

import android.app.Activity;
import android.content.Context;
import android.graphics.Bitmap;
import android.graphics.BitmapFactory;
import android.graphics.Canvas;
import android.os.Looper;
import android.util.AttributeSet;
import android.util.Log;
import android.view.MotionEvent;
import android.view.SurfaceHolder;
import android.view.SurfaceView;
import android.widget.TextView;

import org.w3c.dom.Text;

import java.util.ArrayList;
import java.util.List;
import java.util.logging.Handler;
import java.util.logging.LogRecord;

public class MoverFiguras extends SurfaceView implements SurfaceHolder.Callback {
    private Sprite sprite;
    private GameThread gameThread;
    private float previousX;

    private List<Fruta> frutas = new ArrayList<>();

    private List<Fruta> frutasPorSalir = new ArrayList<>();

    private List<Fruta> frutaAanadir = new ArrayList<>();

    private int TotalLista = 0;

    TextView puntuacion;

    TextView labelDerrotas;

    private boolean hasPerdido = false;

    private VistaJuego vistaJuego;


    public MoverFiguras(Context context, AttributeSet attrs) {
        super(context, attrs);
        init(context);
        Constants.VelocidadCaida = 5;
        Constants.numeroLista = 0;
        Constants.VelocidadMaxima = 30;
        Constants.puntuacion = 0;

    }

    private void init(Context context) {
        getHolder().addCallback(this);

        Bitmap originalBitmap = BitmapFactory.decodeResource(getResources(), R.drawable.cesta);
        int newWidth = originalBitmap.getWidth() / 5;
        int newHeight = originalBitmap.getHeight() / 5;
        Bitmap scaledBitmap = Bitmap.createScaledBitmap(originalBitmap, newWidth, newHeight, true);
        sprite = new Sprite(scaledBitmap, this);

        Bitmap platanoSprite = BitmapFactory.decodeResource(getResources(), R.drawable.platano);
        int newWidthPlatano = platanoSprite.getWidth() / 3;
        int newHeightPlatano = platanoSprite.getHeight() / 3;
        Bitmap scaledPlatano = Bitmap.createScaledBitmap(platanoSprite, newWidthPlatano, newHeightPlatano, true);
        frutas.add(new Fruta(scaledPlatano, this, false));

        Bitmap manzanaSprite = BitmapFactory.decodeResource(getResources(), R.drawable.manzana);
        int newWidthManzana = manzanaSprite.getWidth() / 3;
        int newHeightManzana = manzanaSprite.getHeight() / 3;
        Bitmap scaledManzana = Bitmap.createScaledBitmap(manzanaSprite, newWidthManzana, newHeightManzana, true);
        frutasPorSalir.add(new Fruta(scaledManzana, this, false));

        Bitmap peraSprite = BitmapFactory.decodeResource(getResources(), R.drawable.pera);
        int newWidthPera = peraSprite.getWidth() / 3;
        int newHeightPera = peraSprite.getHeight() / 3;
        Bitmap scaledPera = Bitmap.createScaledBitmap(peraSprite, newWidthPera, newHeightPera, true);
        frutasPorSalir.add(new Fruta(scaledPera, this,false));

        Bitmap fresaSprite = BitmapFactory.decodeResource(getResources(), R.drawable.cereza);
        int newWidthFresa = fresaSprite.getWidth() / 3;
        int newHeightFresa = fresaSprite.getHeight() / 3;
        Bitmap scaledFresa = Bitmap.createScaledBitmap(fresaSprite, newWidthFresa, newHeightFresa, true);
        frutasPorSalir.add(new Fruta(scaledFresa, this,false));

        Bitmap pinaSprite = BitmapFactory.decodeResource(getResources(), R.drawable.pina);
        int newWidthPina = pinaSprite.getWidth() / 3;
        int newHeightPina = pinaSprite.getHeight() / 3;
        Bitmap scaledPina = Bitmap.createScaledBitmap(pinaSprite, newWidthPina, newHeightPina, true);
        frutasPorSalir.add(new Fruta(scaledPina, this,false));

        Bitmap naranjaSprite = BitmapFactory.decodeResource(getResources(), R.drawable.naranja);
        int newWidthNaranja = naranjaSprite.getWidth() / 3;
        int newHeightNaranja = naranjaSprite.getHeight() / 3;
        Bitmap scaledNaranja = Bitmap.createScaledBitmap(naranjaSprite, newWidthNaranja, newHeightNaranja, true);
        frutasPorSalir.add(new Fruta(scaledNaranja, this,false));

        Bitmap pelotaSprite = BitmapFactory.decodeResource(getResources(), R.drawable.pelota);
        int newWidthPelota = pelotaSprite.getWidth() / 7;
        int newHeightPelota = pelotaSprite.getHeight() / 7;
        Bitmap scaledPelota = Bitmap.createScaledBitmap(pelotaSprite, newWidthPelota, newHeightPelota, true);
        frutasPorSalir.add(new Fruta(scaledPelota, this,true));

        Bitmap platanoSprite2 = BitmapFactory.decodeResource(getResources(), R.drawable.platano);
        int newWidthPlatano2 = platanoSprite2.getWidth() / 3;
        int newHeightPlatano2 = platanoSprite2.getHeight() / 3;
        Bitmap scaledPlatano2 = Bitmap.createScaledBitmap(platanoSprite2, newWidthPlatano2, newHeightPlatano2, true);
        frutasPorSalir.add(new Fruta(scaledPlatano2, this,false));

    }
    @Override
    public void surfaceCreated(SurfaceHolder holder) {
        gameThread = new GameThread(getHolder(), this);
        gameThread.setRunning(true);
        gameThread.start();

        BackgroundMusicPlayer.start(getContext(), R.raw.music_background);
    }

    @Override
    public void surfaceChanged(SurfaceHolder holder, int format, int width, int height) {}

    @Override
    public void surfaceDestroyed(SurfaceHolder holder) {
        boolean retry = true;
        gameThread.setRunning(false);
        BackgroundMusicPlayer.stop();
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
            vistaJuego.runOnUiThread(() -> {
                if(fruta.caidaFruta(sprite.getX(), sprite.getY(), (ArrayList<Fruta>) frutaAanadir, (ArrayList<Fruta>) frutasPorSalir)){
                    if (puntuacion != null) {
                        puntuacion.setText("Puntuación: " + Constants.puntuacion);
                    }

                }
                else  {
                    labelDerrotas.setText("HAS PERDIDO");
                    hasPerdido = true;
                }
            });
        }
        if(TotalLista < frutaAanadir.size()) {
            frutas.add(frutaAanadir.get(TotalLista));
            TotalLista++;
        }
        if(hasPerdido){
            frutaAanadir.clear();
            frutas.clear();
            frutasPorSalir.clear();
            BackgroundMusicPlayer.stop();
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

    public void acutalizarTextViews(VistaJuego vistaJuego){
        this.vistaJuego = vistaJuego;
        puntuacion = vistaJuego.puntuacion;
        labelDerrotas = vistaJuego.labelDerrota;

    }
}