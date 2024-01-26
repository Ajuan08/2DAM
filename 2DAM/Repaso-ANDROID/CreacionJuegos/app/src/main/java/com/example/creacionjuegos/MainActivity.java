package com.example.creacionjuegos;

import android.app.Activity;
import android.content.Context;
import android.graphics.Bitmap;
import android.graphics.BitmapFactory;
import android.graphics.Canvas;
import android.graphics.Color;
import android.graphics.Paint;
import android.os.Bundle;
import android.view.View;
import android.view.Window;
import android.view.WindowManager;

import java.util.Random;

public class MainActivity extends Activity {
    Paint paint;
    class RenderView extends View {


        public RenderView(Context context){
            super(context);
            paint = new Paint();
        }
        protected void onDraw(Canvas canvas){
            Bitmap bmp = BitmapFactory.decodeResource(getResources(),R.drawable.ic_launcher_background);
            Bitmap img = bmp.createScaledBitmap(bmp,canvas.getWidth()*0.2,canvas.getHeight()*0.2,true);

            Canvas.drawBitmap(img,posx,posy,null);

            canvas.drawRGB(255,255,255);
            paint.setColor(Color.RED);
            canvas.drawLine(0,0,canvas.getWidth()-1,getHeight()-1,paint);

            paint.setStyle(Paint.Style.STROKE);
            paint.setColor(0xff00ff00);
            canvas.drawCircle(canvas.getWidth() /2, canvas.getHeight() /2,40,paint);

            paint.setStyle(Paint.Style.FILL);
            paint.setColor(0x770000ff);
            canvas.drawRect(100,100,200,200,paint);
            //invalidate();
        }
    }

    @Override
    public void onCreate(Bundle savedInstanceState){
        super.onCreate(savedInstanceState);
        requestWindowFeature(Window.FEATURE_NO_TITLE);
        getWindow().setFlags(WindowManager.LayoutParams.FLAG_FULLSCREEN,WindowManager.LayoutParams.FLAG_FULLSCREEN);
        setContentView(new RenderView(this));

    }
}
