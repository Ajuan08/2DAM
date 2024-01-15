package com.example.creacionjuegos;

public class Rectangulo extends Figura{
    private int Ancho;
    private int Alto;

   public Rectangulo(){

   }

    public Rectangulo(int xpos, int ypos, int ancho, int alto) {
        super(xpos, ypos);
        Ancho = ancho;
        Alto = alto;
    }

    public int getAncho() {
        return Ancho;
    }

    public void setAncho(int ancho) {
        Ancho = ancho;
    }

    public int getAlto() {
        return Alto;
    }

    public void setAlto(int alto) {
        Alto = alto;
    }
}
