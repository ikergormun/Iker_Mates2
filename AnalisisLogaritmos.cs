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
            if(c == resto)
            {
                contador++;
            }
            n /= 10;
        }

        Debug.Log("El número " + c + " ha salido " + contador + " vez/veces");

        //Talla del problema: c
        //Coste temporal: O(n)
        //Mejor caso: 0<=n<=9
        //Peor caso: n>=10

        //Mostrar en consola las cifras de un número entero no negativo n en orden natural (de menor a mayor), uno en cada línea.


    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
