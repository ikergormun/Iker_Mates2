using UnityEngine;

public class AnalisisLogaritmos : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        //Contar las veces que una cifra c aparece en un entero no negativo n. (Pista: piensa cuál es el resultado de 1234 % 10)

        int n = 1223424463;
        int c = 2;

        int contador = 0;
        int resto;

        while (n > 0)
        {
            resto = n % 10;
            if (c == resto)
            {
                contador++;
            }
            n /= 10;
        }

        Debug.Log("El número " + c + " ha salido " + contador + " vez/veces");

        //Talla del problema: n
        //Coste temporal: O(n)
        //Mejor caso: O(1)
        //Peor caso: O(n)

        //Mostrar en consola las cifras de un número entero no negativo n en orden natural (de menor a mayor), uno en cada línea.

        n = 42115;

        for (int i = 0; i <= 9; i++)
        {
            int temp = n; // Creamos una copia para no perder el valor original de n

            // Comprobamos cada dígito del número
            while (temp > 0)
            {
                int cifra = temp % 10;

                // Si el dígito coincide con el número que estamos buscando (i), lo imprimimos
                if (cifra == i)
                {
                    Debug.Log(i);
                }

                temp /= 10; // Quitamos la última cifra
            }
        }

        // Talla del problema: n
        // Coste temporal: O(n)
        // Mejor caso: O(1)
        // Peor caso: O(n)

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
