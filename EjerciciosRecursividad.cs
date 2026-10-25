using UnityEngine;

public class EjerciciosRecursividad : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        //Ej 1.
        int numero = 235621;

        Debug.Log("[Recursivo] Cifras de " + numero + ": " + ContarCifrasRecursivo(numero));
        Debug.Log("[Iterativo] Cifras de " + numero + ": " + ContarCifrasIterativo(numero));

        //Coste Temporal: Recursiva O(n) - Iterativa O(n)
        //Coste Espacial: Recursiva O(n) - Iterativa O(1)
        //Mejor caso: que n sea un dígito.
        //Peor caso: que n sea más de un dígito.

        //Ej 2.
        int numero2 = 12342;
        int cifraBuscada = 2;

        int resultado = ContarCifraRecursivo(numero2, cifraBuscada);
        Debug.Log("La cifra " + cifraBuscada + " aparece " + resultado + " veces.");
        resultado = ContarCifraIterativo(numero, cifraBuscada);
        Debug.Log("La cifra " + cifraBuscada + " aparece " + resultado + " veces.");

        //Coste Temporal: Recursiva O(n) - Iterativa O(n)
        //Coste Espacial: Recursiva O(n) - Iterativa O(1)
        //Mejor caso: que n sea un dígito.
        //Peor caso: que n sea más de un dígito.

        //Ej 3.
        int numero3 = 2468;

        Debug.Log("¿Son todas las cifras pares? " + TodasParesRecursivo(numero3));
        Debug.Log("¿Son todas las cifras pares? " + TodasParesIterativo(numero3));

        //Coste Temporal: Recursiva O(n) - Iterativa O(n)
        //Coste Espacial: Recursiva O(n) - Iterativa O(1)
        //Mejor caso: que la primera cifra contada sea impar o n una sola cifra.
        //Peor caso: si todas las cifras de n son pares o la última contada impar.

        //Ej 4.
        int[] vector = { 5, 2, 9, 1, 7 };
        int datoBuscado = 9;

        // Llamamos a la función empezando desde la última posición del vector (vector.Length - 1)
        bool encontrado = BuscarRecursivo(vector, datoBuscado, vector.Length - 1);

        Debug.Log("¿Aparece el dato en el vector? " + encontrado);


        encontrado = BuscarIterativo(vector, datoBuscado);

        Debug.Log("¿Aparece el dato en el vector? " + encontrado);

        //Coste Temporal: Recursiva O(v.length) / O(n) - Iterativa O(v.length) / O(n)
        //Coste Espacial: Recursiva O(v.length) / O(n) - Iterativa O(1)
        //Mejor caso: el dato está en la primera posición comprobada o la longitud del vector es 1.
        //Peor caso: el dato no está en el vector o es el último comprobado.

        //Ej 5.
        int[] vector2 = { 2, 5, 2, 8, 2, 1 };
        int datoBuscado5 = 2;

        // Empezamos desde la última posición del vector
        int resultado5 = ContarOcurrenciasRecursivo(vector2, datoBuscado5, vector2.Length - 1);

        Debug.Log("El dato " + datoBuscado5 + " aparece " + resultado5 + " veces.");


        resultado5 = ContarOcurrenciasIterativo(vector2, datoBuscado5);

        Debug.Log("El dato " + datoBuscado5 + " aparece " + resultado5 + " veces.");
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    //Ej 1.
    public int ContarCifrasRecursivo(int n)
    {
        // Caso Base: si el número tiene un solo dígito (0-9)
        if (n < 10) return 1;

        // Caso Recursivo: 1 dígito sumado + el conteo del resto del número
        return 1 + ContarCifrasRecursivo(n / 10);
    }

    public int ContarCifrasIterativo(int n)
    {
        int contador = 1;

        while (n >= 10)
        {
            contador++;
            n /= 10; // n = n / 10
        }

        return contador;
    }

    //Ej 2.
    int ContarCifraRecursivo(int n, int c)
    {
        // Caso Base: si el número ya es 0, terminamos
        if (n == 0) return 0;

        int coincide;

        if (n % 10 == c)
        {
            coincide = 1; // Si el último dígito es igual a la cifra buscada
        }
        else
        {
            coincide = 0; // Si no es igual
        }

        // Caso Recursivo: sumamos si coincidía + la llamada con el número sin la última cifra
        return coincide + ContarCifraRecursivo(n / 10, c);
    }

    int ContarCifraIterativo(int n, int c)
    {
        int contador = 0;

        while (n > 0)
        {
            // Si el último dígito coincide con la cifra buscada
            if (n % 10 == c)
            {
                contador++;
            }

            // Quitamos la última cifra
            n = n / 10;
        }

        return contador;
    }

    //Ej 3.
    bool TodasParesRecursivo(int n)
    {
        // Caso Base 1: Si ya hemos procesado todo el número y no falló nada, son todas pares
        if (n == 0) return true;

        // Cogemos el último dígito
        int ultimoDigito = n % 10;

        // Caso Base 2: Si encontramos UN solo dígito impar, ya es falso
        if (ultimoDigito % 2 != 0) return false;

        // Caso Recursivo: Si el último era par, seguimos comprobando el resto del número (n / 10)
        return TodasParesRecursivo(n / 10);
    }

    bool TodasParesIterativo(int n)
    {
        while (n > 0)
        {
            int ultimoDigito = n % 10;

            if (ultimoDigito % 2 != 0) return false; // En cuanto hay un impar, salimos devolviendo false

            n = n / 10;
        }

        return true; // Si el bucle termina sin encontrar impares, todas eran pares
    }

    //Ej 4.
    bool BuscarRecursivo(int[] v, int d, int i)
    {
        // Caso Base 1: Si el índice es menor que 0, hemos revisado todo y no está
        if (i < 0)
        {
            return false;
        }

        // Caso Base 2: Si lo encontramos en la posición actual
        if (v[i] == d)
        {
            return true;
        }

        // Caso Recursivo: Buscamos en la posición anterior (i - 1)
        return BuscarRecursivo(v, d, i - 1);
    }

    bool BuscarIterativo(int[] v, int d)
    {
        for (int i = 0; i < v.Length; i++)
        {
            // Si encontramos el dato, devolvemos true inmediatamente
            if (v[i] == d)
            {
                return true;
            }
        }

        // Si el bucle acaba y no ha retornado true, es que no está
        return false;
    }

    //Ej 5.
    int ContarOcurrenciasRecursivo(int[] v, int d, int i)
    {
        // Caso Base: si el índice baja de 0, ya hemos terminado de revisar el vector
        if (i < 0)
        {
            return 0;
        }

        // Comprobamos si el elemento actual coincide con el buscado (1 si coincide, 0 si no)
        int coincide;
        if(v[i] == d)
        {
            coincide = 1;
        }
        else
        {
            coincide = 0;
        }

        // Caso Recursivo: sumamos la coincidencia actual + el resultado del resto del vector
        return coincide + ContarOcurrenciasRecursivo(v, d, i - 1);
    }

    int ContarOcurrenciasIterativo(int[] v, int d)
    {
        int contador = 0;

        for (int i = 0; i < v.Length; i++)
        {
            // Si el elemento coincide, sumamos uno al contador
            if (v[i] == d)
            {
                contador++;
            }
        }

        return contador;
    }
}
