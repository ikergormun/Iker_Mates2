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
}
