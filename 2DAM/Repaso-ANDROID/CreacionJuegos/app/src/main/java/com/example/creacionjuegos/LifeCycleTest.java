package com.example.creacionjuegos;

import androidx.appcompat.app.AppCompatActivity;

import android.app.Activity;
import android.os.Bundle;
import android.util.Log;
import android.widget.TextView;

public class LifeCycleTest extends AppCompatActivity {

    public class LifeCycleTest2 extends Activity {
        StringBuilder builder = new StringBuilder();
        TextView textView;

        private void log(String text){
            Log.d("LifeCycleTest",text);
            builder.append(text);
            builder.append('\n');
            textView.setText(builder.toString());
        }

        @Override
        public void onCreate(Bundle savedInstanceState) {
            super.onCreate(savedInstanceState);
            textView = new TextView(this);
            textView.setText(builder.toString());


            setContentView(textView);
            log("created");
        }

        @Override
        protected void onResume(){
            super.onResume();
            log("resumed");
        }

        @Override
        protected void onPause(){
            super.onPause();
            log("paused");

            if(isFinishing()){
                log("Finishing");
            }
        }
    }
}