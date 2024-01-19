package com.example.creacionjuegos;

import android.content.Context;
import android.graphics.Canvas;
import android.graphics.Color;
import android.view.MotionEvent;
import android.view.SurfaceHolder;
import android.view.SurfaceView;

import androidx.annotation.NonNull;

import java.util.ArrayList;

public class MoverFiguras extends SurfaceView implements SurfaceHolder.Callback {

    private ArrayList<Figura> figuras;
    private int figuraActiva;
    public MoverFiguras(Context context) {
        super(context);
    }

    @Override
    public void surfaceCreated(@NonNull SurfaceHolder holder) {
        int id = 0;
        figuras = new ArrayList<Figura>();
        figuras.add(new Rectangulo(id++,100,100,200));
        figuras.add(new Circulo(id++,200,200));

    }

    }

    @Override
    public void surfaceChanged(@NonNull SurfaceHolder holder, int format, int width, int height) {

    }

    @Override
    public void surfaceDestroyed(@NonNull SurfaceHolder holder) {

        boolean retry = true;
        thread.setRunning(false);

        while(retry){
            try{
                thread.join();
                retry = false;
            }catch(InterruptedException e) {
        }
    }

    @Override
    public void onDraw(Canvas canvas){
        setBackgroundColor(Color.BLACK);
    }

    @Override
    public boolean onTouchEvent(MotionEvent event){

        return false;
    }


}
