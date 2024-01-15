package com.example.creacionjuegos;

import android.view.SurfaceHolder;

import androidx.compose.ui.graphics.Canvas;

public class Hilo extends Thread {
    private SurfaceHolder sh;
    private SingleTouchTest st;
    private boolean run;

    public Hilo(SurfaceHolder sh, SingleTouchTest st){
        this.sh = sh;
        this.st = st;
        run = false;
    }

    public void setRunning(boolean run){ this.run = run;}

    public void run(){

        Canvas canvas;
        while(run){
            canvas = null;
            try{
                canvas = sh.lockCanvas(null);
                st.postInvalidate();
            }finally{
                if(canvas != null){
                    sh.unlockCanvasAndPost(canvas);
                }
            }
        }


    }
}
