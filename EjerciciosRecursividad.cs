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

        //Ej6.
        int[] vector6 = { 10, 20, 30, 40 };

        // Empezamos a imprimir desde la posición 0
        ImprimirRecursivo(vector6, 0);

        ImprimirIterativo(vector6);

        //Coste Temporal: Recursiva O(v.length) / O(n) - Iterativa O(v.length) / O(n)
        //Coste Espacial: Recursiva O(v.length) / O(n) - Iterativa O(1)
        //Mejor y peor caso iguales.

        //Ej 7.
        int[] vector7 = { 10, 20, 30, 40 };

        // Empezamos a imprimir desde la última posición (vector.Length - 1)
        ImprimirInversoRecursivo(vector7, vector7.Length - 1);

        ImprimirInversoIterativo(vector7);

        //Coste Temporal: Recursiva O(v.length) / O(n) - Iterativa O(v.length) / O(n)
        //Coste Espacial: Recursiva O(v.length) / O(n) - Iterativa O(1)
        //Mejor y peor caso iguales.

        //Ej 8.
        int[] vector8 = { 1, 3, 5, 7, 9 };

        // Empezamos a comprobar desde la posición 0
        bool ordenado8 = EsOrdenadoRecursivo(vector8, 0);

        Debug.Log("¿Está ordenado de menor a mayor? " + ordenado8);

        ordenado8 = EsOrdenadoIterativo(vector8);

        Debug.Log("¿Está ordenado de menor a mayor? " + ordenado8);

        //Coste Temporal: Recursiva O(v.length) / O(n) - Iterativa O(v.length) / O(n)
        //Coste Espacial: Recursiva O(v.length) / O(n) - Iterativa O(1)
        //Mejor caso: que los primeros númerosesten desordenados o solo contenga un número
        //Peor caso: que todos los números esten ordenados o los 2 últimos no lo esten.

        //Ej 9.
        int[] vector9 = { 7, 2, 9, 4, 1, 5 };

        int min9 = EncontrarMinimoRecursivo(vector9, 0);

        Debug.Log("El menor elemento es: " + min9);

        min9 = EncontrarMinimoIterativo(vector9);

        Debug.Log("El menor elemento es: " + min9);

        //Coste Temporal: Recursiva O(v.length) / O(n) - Iterativa O(v.length) / O(n)
        //Coste Espacial: Recursiva O(v.length) / O(n) - Iterativa O(1)
        //Mejor y peor caso iguales.

        //Ej 10.
        int[] vector10 = { 5, 8, 12, 6 };
        int d10 = 3;

        // Empezamos a comprobar desde la posición 0
        bool todosMayores = SonTodosMayoresRecursivo(vector10, d10, 0);

        Debug.Log("¿Son todos mayores que " + d10 + "? " + todosMayores);

        todosMayores = SonTodosMayoresIterativo(vector10, d10);

        Debug.Log("¿Son todos mayores que " + d10 + "? " + todosMayores);

        //Coste Temporal: Recursiva O(v.length) / O(n) - Iterativa O(v.length) / O(n)
        //Coste Espacial: Recursiva O(v.length) / O(n) - Iterativa O(1)
        //Mejor caso: si el primer incumple la condición
        //Peor caso: si ningún número incumple la condición o justo es el último.
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

    //Ej 6.
    void ImprimirRecursivo(int[] v, int i)
    {
        // Caso Base: si el índice llega al final del vector, terminamos
        if (i >= v.Length) return;

        // 1. Imprimimos el elemento actual primero (orden natural)
        Debug.Log(v[i]);

        // 2. Llamamos a la función para que procese la siguiente posición
        ImprimirRecursivo(v, i + 1);
    }

    void ImprimirIterativo(int[] v)
    {
        for (int i = 0; i < v.Length; i++)
        {
            Debug.Log(v[i]);
        }
    }

    //Ej7.
    void ImprimirInversoRecursivo(int[] v, int i)
    {
        // Caso Base: si el índice baja de 0, hemos terminado
        if (i < 0) return;

        // 1. Imprimimos el elemento actual primero
        Debug.Log(v[i]);

        // 2. Llamamos a la función con la posición anterior (i - 1)
        ImprimirInversoRecursivo(v, i - 1);
    }

    void ImprimirInversoIterativo(int[] v)
    {
        // Empezamos desde el final y vamos restando hasta llegar a 0
        for (int i = v.Length - 1; i >= 0; i--)
        {
            Debug.Log(v[i]);
        }
    }

    //Ej 8.
    bool EsOrdenadoRecursivo(int[] v, int i)
    {
        // Caso Base 1: Si llegamos al final sin fallos, está ordenado
        if (i >= v.Length - 1)
        {
            return true;
        }

        // Caso Base 2: Si el elemento actual es mayor que el siguiente, se rompe el orden
        if (v[i] > v[i + 1]) return false;

        // Caso Recursivo: Comprobamos el siguiente par de elementos (i + 1)
        return EsOrdenadoRecursivo(v, i + 1);
    }

    bool EsOrdenadoIterativo(int[] v)
    {
        for (int i = 0; i < v.Length - 1; i++)
        {
            // Si un elemento es mayor que el siguiente, no está ordenado
            if (v[i] > v[i + 1]) return false;
        }

        return true;
    }

    //Ej 9.
    int EncontrarMinimoRecursivo(int[] v, int i)
    {
        // Caso Base: si estamos en el último elemento, él mismo es su propio mínimo
        if (i == v.Length - 1)
        {
            return v[i];
        }

        // Paso Recursivo: encontramos el mínimo del resto del vector
        int minResto = EncontrarMinimoRecursivo(v, i + 1);

        // Comparamos el elemento actual con el mínimo del resto usando un if/else
        if (v[i] < minResto)
        {
            return v[i]; // Si el actual es más pequeño, devolvemos el actual
        }
        else
        {
            return minResto; // Si no, devolvemos el mínimo que venía del resto
        }
    }

    int EncontrarMinimoIterativo(int[] v)
    {
        int min = v[0];

        for (int i = 1; i < v.Length; i++)
        {
            if (v[i] < min)
            {
                min = v[i];
            }
        }

        return min;
    }

    //Ej 10.
    bool SonTodosMayoresRecursivo(int[] v, int d, int i)
    {
        // Caso Base 1: Si hemos llegado al final sin fallos, todos son mayores
        if (i >= v.Length) return true;

        // Caso Base 2: Si encontramos un elemento menor o igual a d, fallamos al instante
        if (v[i] <= d) return false;

        // Caso Recursivo: Comprobamos el resto del vector avanzando el índice
        return SonTodosMayoresRecursivo(v, d, i + 1);
    }

    bool SonTodosMayoresIterativo(int[] v, int d)
    {
        for (int i = 0; i < v.Length; i++)
        {
            // Si encontramos uno que no sea mayor, devolvemos false al momento
            if (v[i] <= d)
            {
                return false;
            }
        }

        return true;
    }
}
