using UnityEngine;

public class Prueba : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        int n = 16574;
        if (n < 0)
        {
            Debug.Log("Introduzca un valor positivo");
        }
        else if (n == 0)
        {
            Debug.Log("1");
        }
        else
        {
            int contador = 0;
            while (n > 0)
            {
                n /= 10;
                contador++;
            }
            Debug.Log(contador);
        }

        //Talla del problema: cifras del número n;
        //Coste temporal: O(N)
        //Mejor caso: 0<=n<=9
        //Peor caso: n>=10
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
