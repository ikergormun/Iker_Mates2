using UnityEngine;
using UnityEngine.UI;

public class Examen856B : MonoBehaviour
{
    int contador;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        CalcularCartas(transform);
        Debug.Log("Total cartas: " + contador);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void CalcularCartas(Transform parent)
    {
        foreach (Transform child in parent)
        {
            Button boton = child.GetComponent<Button>();
            if (boton != null) contador++;

            CalcularCartas(child);
        }
    }

    public void Esperanza()
    {

    }

    //Ej 5.
    //a) Talla del problema ej 2: número de hijos en Card
    //   Talla del problema ej 3: valor de la carta
    //   Talla del problema ej 4: valor de la carta
    //b) Coste espacial ej 2: O(n)
    //   Mejor caso: que solo haya un hijo
    //   Coste espacial ej 3: O(n)
    //   Coste espacial ej 4: Recursivo O(n) Iterativo O(1)
    //c) Coste temporal ej 2: O(n)
    //   Coste temporal ej 3: O(n)
    //   Coste temporal ej 4: Recursivo O(n) Iterativo O(n)
}
