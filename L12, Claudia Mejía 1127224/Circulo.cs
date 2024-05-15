using System.Formats.Asn1;

namespace L12__Claudia_Mejía_1127224;

public class Circulo
{
    double radio = 0;
    
    public Circulo(double radio)
    {
        this.radio = radio;
    }

    private double ObtenerPerimetro(double radioP)
    {
        return 2 * 3.1415926535 * radioP;
    }
    private double ObtenerArea(double radioA)
    {
        return 3.1415926535 * (radioA * radioA);
    }
    private double ObtenerVolumen(double radioV)
    {
        return (4 * 3.1415926535 * (radioV * radioV * radioV))/3;
    }

    public CalcularGeometria()
    {
        
    }
}
