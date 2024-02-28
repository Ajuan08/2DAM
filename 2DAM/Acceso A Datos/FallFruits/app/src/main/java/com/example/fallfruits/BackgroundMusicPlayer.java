package com.example.fallfruits;

import android.content.Context;
import android.media.MediaPlayer;

public class BackgroundMusicPlayer {
    private static MediaPlayer mediaPlayer;

    public static synchronized void start(Context context, int musicResource) {
        stop();
        mediaPlayer = MediaPlayer.create(context, musicResource);
        mediaPlayer.setLooping(true);
        mediaPlayer.start();
    }

    public static synchronized void stop() {
        if (mediaPlayer != null && mediaPlayer.isPlaying()) {
            mediaPlayer.stop();
            mediaPlayer.release();
            mediaPlayer = null;
        }
    }
}
