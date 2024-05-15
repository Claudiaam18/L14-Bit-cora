using System.ComponentModel;

class Automovil
{
    private int modelo;
    private double precio;
    private string marca;
    private bool disponible;
    private double tipoCambioDolar;
    private double descuentoAplicado;

    public Automovil()
    {
        modelo = 2019;
        precio = 10000.00;
        marca = "";
        disponible = false;
        tipoCambioDolar = 7.50;
        descuentoAplicado = 0.00;
    }

    public void DefinirModelo(int unModelo)
    {
        modelo = unModelo;
    }

    public void DefinirPrecio(double unPrecio)
    {
        precio = unPrecio;
    }

    public void DefinirMarca(string unaMarca)
    {
        marca = unaMarca;
    }

    public void DefinirTipoCambio(double unTipoCambio)
    {
        tipoCambioDolar = unTipoCambio;
    }

    public void CambiarDisponibilidad()
    {
        disponible = !disponible;
    }

    //funcion
    public string MostrarDisponibilidad()
    {
        if (disponible)
            return "Disponible";
        else
            return "No se encuentra disponible actualmente";
    }

    public string MostrarInformacion()
    {
        double precioEnDolares = precio/tipoCambioDolar;
        return "Marca: " + marca + "Modelo: " + modelo + "Precio de venta: Q" + precio + "Precio en dólares: $" + precioEnDolares + "" + MostrarDisponibilidad();
    }

    public void AplicarDescuento(double miDescuento)
    {
        descuentoAplicado = miDescuento;
        double precioDescuento = precio - descuentoAplicado;
        DefinirPrecio(precioDescuento);
    }
}