package com.example.creacionjuegos;

public class Rectangulo extends Figura{
    private int Ancho;
    private int Alto;
    private float radio;

   public Rectangulo(){

   }

    public Rectangulo(int xpos, int ypos, int ancho, int alto) {
        super(xpos, ypos);
        Ancho = ancho;
        Alto = alto;
    }

    public boolean estaDentro(int posx, int posy){
        boolean dentro = false;
        int distanciaX = posx - getXpos();
        int distanciaY = posy - getYpos();

        if(distanciaX > 0 && distanciaX < Ancho && distanciaY > 0 && distanciaY < Alto){
            dentro = true;
        }
        return dentro;
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
