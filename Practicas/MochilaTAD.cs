using UnityEngine;

public class MochilaTAD
{
    //public class Jugador : MonoBehaviour
    //{
    //  public MochilaTAD mochila = new MochilaTAD(50); creando una mochila 


    // === ENCAPSULACIÓN ===
    // Nadie fuera de esta clase puede tocar directamente este array ni el contador
    private string[] huecos;
    private int cantidadActual;

    // Constructor: inicializa la estructura interna con capacidad máxima N
    public MochilaTAD(int capacidadMaxima)
    {
        huecos = new string[capacidadMaxima];
        cantidadActual = 0;
    }

    // === MÉTODOS DE ACCESO ===
    public bool EstaVacia()
    {
        return cantidadActual == 0;
    }

    public bool EstaLlena()
    {
        return cantidadActual == huecos.Length;
    }

    public int VerCantidad()
    {
        return cantidadActual;
    }

    public bool Guardar(string nuevoItem)
    {
        if (EstaLlena())
        {
            return false; // No cabe más en la mochila
        }
        huecos[cantidadActual] = nuevoItem;
        cantidadActual++;
        return true;
    }

    public string SacarUltimo()
    {
        if (EstaVacia())
        {
            return null;
        }
        cantidadActual--;
        string itemExtraido = huecos[cantidadActual];
        huecos[cantidadActual] = null; // Limpiamos la casilla
        return itemExtraido;
    }

    public string SacarMedio()
    {
        if (EstaVacia())
        {
            return null;
        }
        int indiceMedio = cantidadActual / 2;
        string itemExtraido = huecos[indiceMedio];

        //Desplazamos una posición a la izquierda los elementos posteriores
        for(int i = indiceMedio; i < cantidadActual - 1; i++)
        {
            huecos[i] = huecos[i + 1];
            //Se puede añadir un if para optimizar un bucle y parar cuando se encuentre con un null
        }

        //Asegurar que el último es null
        cantidadActual--;
        huecos[cantidadActual] = null;

        return itemExtraido;
    }
}