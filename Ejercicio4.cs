using UnityEngine;
using UnityEngine.UI;

public class Ejercicio4 : MonoBehaviour
{
    [SerializeField] private Image image;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        //Primera versión
        //foreach (Transform child in transform)
        //{
        //    Button boton = child.GetComponent<Button>();
        //    boton.image = image;
        //    if (boton != null) boton.image = image;
        //}

        //Forma Recursiva
        CambiarImagenBotones(transform);
    }

    // Update is called once per frame
    void Update()
    {

    }

    void CambiarImagenBotones(Transform parent)
    {
        foreach (Transform child in parent)
        {
            Button boton = child.GetComponent<Button>();
            if(boton != null) boton.image = image;
            CambiarImagenBotones(child);
        }
    }

    //¿Por qué no hay return en la función?
    //Porque la función está declarada como void, es decir, que no devuelve ningún valor.

    //¿Cuál es la talla del problema?
    //Talla del problema: N, donde N es el número total de GameObjects

    //Coste espacial y temporal en mejor(si hay) y peor caso
    //Coste temporal: O(N) (donde N es el número total de descendientes)
    //Mejor y peor caso iguales.
    //Coste espacial: O(H) (donde H es la altura máxima del árbol, es decir, cúantos niveles de padres e hijos hay uno dentro de otro.
    //Cada vez que la función se llama a si misma se añade un nivel a la pila de llamadas.
}
