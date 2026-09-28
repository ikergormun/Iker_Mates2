using UnityEngine;

public class Ejercicio2 : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        //Un método que reciba un float (de 0.0 a 1.0, si no, no hará nada) y devuelva el equivalente en % de probabilidad.

        float valor = -0.2f;
        float porcentaje;

        if((valor > 0.0f) && (valor < 1.0))
        {
            porcentaje = valor * 100f;
            Debug.Log(porcentaje +"%");
        }

        else
        {
            Debug.Log("El valor ingresado está fuera del rango (0.0 - 1.1)");
        }

        //Un método que reciba un % de probabilidad (de 0% a 100%, si no, no hará nada) y devuelva el equivalente en decimales (float)

        porcentaje = 20f;

        if((porcentaje > 0.0f) && (porcentaje < 100.0f))
        {
            valor = porcentaje / 100f;
            Debug.Log(valor);
        }

        else
        {
            Debug.Log("El valor ingresado está fuera del rango (0% - 100%");
        }

        //Un método que calcule la probabilidad con la fórmula básica. Recibirá número de resultados buscados entre número de resultados posibles. Se devolverá en formato %.

        float resultadosbuscados = 3;
        float resultadosposibles = 10;
        float probabilidad = resultadosbuscados / resultadosposibles;
        porcentaje = probabilidad * 100f;

        if((resultadosbuscados < 0) || (resultadosposibles < 0))
        {
            Debug.Log("Introduzca valores positivos");
        }
        else
        {
            Debug.Log(porcentaje + "%");
        }

        //Un método que calcule la probabilidad que suceda un evento O de que suceda otro. (Ej: probabilidad de sacar una figura O un As en la baraja: 12/52 + 4/52 = 16/52).
        float evento1 = 4;
        float evento2 = 10;

        resultadosposibles = 50;

        float probabilidad1 = evento1 / resultadosposibles;
        float probabilidad2 = evento2 / resultadosposibles;
        float probabilidadtotal = probabilidad1 + probabilidad2;

        if ((evento1 < 0) || (evento2 < 0) || (resultadosposibles < 0))
        {
            Debug.Log("Introduzca valores positivos");
        }
        else
        {
            Debug.Log(probabilidadtotal);
        }

        //Un método que calcule la probabilidad que suceda un evento Y de que suceda otro. (Ej: probabilidad de sacar un As Y de que sea diamante: 4/52 x 13/52 = 16/52).

        evento1 = 4;
        evento2 = 10;

        resultadosposibles = 50;

        probabilidad1 = evento1 / resultadosposibles;
        probabilidad2 = evento2 / resultadosposibles;
        probabilidadtotal = probabilidad1 * probabilidad2;

        if ((evento1 < 0) || (evento2 < 0) || (resultadosposibles < 0))
        {
            Debug.Log("Introduzca valores positivos");
        }
        else
        {
            Debug.Log(probabilidadtotal);
        }

        //Un método que sea como un dado de seis lados (D6). Al llamar al método devolverá un número entre el 1 y el 6 inclusive.

        int tirarDado = Random.Range(1, 7);
        Debug.Log(tirarDado);

        //Un método que se le pase por parámetro una cantidad de lados y devuelva un número entre el 1 y la cantidad de lados inclusive.

        int carasDado = 10;

        if(carasDado < 0)
        {
            Debug.Log("Introduzca valores positivos");
        }
        else
        {
            tirarDado = Random.Range(1, carasDado);
            Debug.Log(tirarDado);
        }

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
