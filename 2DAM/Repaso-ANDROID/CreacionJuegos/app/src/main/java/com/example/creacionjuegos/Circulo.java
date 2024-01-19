package com.example.creacionjuegos;

public class Circulo extends Figura {
    private int Radio;

    public Circulo(){

    }

    public Circulo(int xpos, int ypos, int radio) {
        super(xpos, ypos);
        Radio = radio;
    }

    public int getRadio() {
        return Radio;
    }

    public void setRadio(int radio) {
        Radio = radio;
    }


}
