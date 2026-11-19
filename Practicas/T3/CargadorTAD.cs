using UnityEngine;

public class CargadorTAD
{
    // === ENCAPSULACIÓN ===
    //Las variables de almacenamiento físico son private para evitar accesos indebidos desde otros scripts.
    private int[] arrayBalas;
    private int cantidadActual;
    private int capacidadMaxima;

    //Contructor: inicializa el cargador con una capacidad máxima N y lo deja lleno por defecto.
    public CargadorTAD(int capacidadN)
    {
        capacidadMaxima = capacidadN;
        arrayBalas = new int[capacidadMaxima];
        cantidadActual = capacidadMaxima;

        for (int i = 0; i < capacidadMaxima; i++)
        {
            arrayBalas[i] = 1;
        }
    }

    // === MÉTODOS DE ACCESO ===
    // (Métodos auxiliares de consulta)
    public bool EstaVacia()
    {
        return cantidadActual == 0;
    }

    public bool EstaLlena()
    {
        return cantidadActual == capacidadMaxima;
    }

    public int BalasRestantes()
    {
        return cantidadActual;
    }

    //(Métodos de acceso)
    public bool Disparar()
    {
        if (EstaVacia())
        {
            return false;
        }

        cantidadActual--;
        arrayBalas[cantidadActual] = 0;
        return true;
    }
}
    

