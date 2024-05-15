class Operaciones
{
    public double obtenerAreaTriangulo(double bases, double altura)
    {
        double area = (bases * altura)/2; 
        return area;
    }
    public double obtenerAreaCuadrado(double lado)
    {
        double area = lado * lado; 
        return area;
    }
    public double obtenerAreaRectangulo(double bases, double altura)
    {
        double area = (bases * altura)/2; 
        return area;
    }
    public double obtenerAreaCirculo(double radio)
    {
        double area = (3.1416*radio); 
        return area;
    }

}