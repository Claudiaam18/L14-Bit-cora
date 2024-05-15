class Personaje
{
    public int x = 0;
    public int y = 0;

    public int GetX()
    {
        return x;
    }

    public int GetY()
    {
        return y;
    }

    public Personaje(int x, int y)
    {
        this.x = x;
        this.y = y;
    }

    public void MoverHaciaAbajo(int cantidad)
    {
        y-= cantidad;
    }

    public void MoverHaciaArriba(int cantidad)
    {
        y+= cantidad;
    }

    public void MoverHaciaDerecha(int cantidad)
    {
        x+= cantidad;
    }

    public void MoverHaciaIzquierda(int cantidad)
    {
        x-= cantidad;
    }
}