using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace verifica_triangulo
{
    //Victor Rafael da Silva
    static class CalculadoraTriangulo
    {
        public static bool ValidaTriangulo(List<float> floats)
        {
            float x = floats[0];
            float y = floats[1];
            float z = floats[2];

            float somaXY = x + y;
            float somaXZ = x + z;
            float somaYZ = y + z;

            if (somaXY > z && somaXZ > y && somaYZ > x)
                return true;
            else
                return false;
        }

        public static string TipoTriangulo(List<float> floats)
        {
            float x = floats[0];
            float y = floats[1];
            float z = floats[2];

            bool AllEqual = floats.Distinct().Count() == 1;
            bool AllDifferent = floats.Distinct().Count() == 3;

            if (AllEqual == true)
                return "Equilátero";
            else if (x == y || x == z || z == y)
                return "Isóceles";
            else if (AllDifferent == true)
                return "Escaleno";

                return " ";
        }
    }
}
