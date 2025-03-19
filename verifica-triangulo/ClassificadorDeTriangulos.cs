namespace verifica_triangulo;

public static class ClassificadorDeTriangulos
{
    public static bool MedidasFormamTrianguloValido(int ladoX, int ladoY, int ladoZ)
    {
        bool medidasTrianguloValidas =
            ladoX + ladoY > ladoZ &&
            ladoX + ladoZ > ladoY &&
            ladoY + ladoZ > ladoX;

        return medidasTrianguloValidas;
    }

    public static string ClassificarTriangulo(int ladoX, int ladoY, int ladoZ)
    {
        string tipoTriangulo = "Não classificado";

        if (ladoX == ladoY && ladoY == ladoZ)
        {
            tipoTriangulo = "Equilátero";
        }
        else if (ladoX != ladoY && ladoY != ladoZ && ladoX != ladoZ)
        {
            tipoTriangulo = "Escaleno";
        }
        else
        {
            tipoTriangulo = "Isósceles";
        }

        return tipoTriangulo;
    }
} 
