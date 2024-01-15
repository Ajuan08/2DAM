package com.example.creacionjuegos;

public class Figura {
    private int Xpos;
    private int Ypos;

    public Figura(){

    }

    public Figura(int xpos , int ypos) {
        Xpos = xpos;
        Ypos = ypos;
    }

    public int getXpos() {
        return Xpos;
    }

    public void setXpos(int xpos) {
        Xpos = xpos;
    }

    public boolean estaDentro(int xpos, int ypos){
        return true;
    }
}
