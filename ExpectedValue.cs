using UnityEngine;

public class ExpectedValue : MonoBehaviour
{
    [Header("Numero de cartas")]
    [SerializeField] private int n_As = 4;
    [SerializeField] private int n_Tres = 4, n_Rey = 4, n_Caballo = 4, n_Sota = 4, n_Siete = 4, n_Seis = 4, n_Cinco = 4, n_Cuatro = 4, n_Dos = 4;
    int n_Total = 40;

    [Header("Valores de cartas")]
    [SerializeField] private float v_As = 11;
    [SerializeField] private float v_Tres = 10, v_Rey = 4, v_Caballo = 3, v_Sota = 2, v_Siete = 0, v_Seis = 0, v_Cinco = 0, v_Cuatro = 0, v_Dos = 0;
    public void CalcularProbabilidades()
    {
        //PONER AQUI EL CALCULO DE PROBABILIDADES QUE ESTABA EN EL START
        float p_As = (float)n_As / n_Total;
        Debug.Log(p_As);
        float p_Tres = (float)n_Tres / n_Total;
        Debug.Log(p_Tres);
        float p_Rey = (float)n_Rey / n_Total;
        Debug.Log(p_Rey);
        float p_Caballo = (float)n_Caballo / n_Total;
        Debug.Log(p_Caballo);
        float p_Sota = (float)n_Sota / n_Total;
        Debug.Log(p_Sota);
        float p_Siete = (float)n_Siete / n_Total;
        Debug.Log(p_Siete);
        float p_Seis = (float)n_Seis / n_Total;
        Debug.Log(p_Seis);
        float p_Cinco = (float)n_Cinco / n_Total;
        Debug.Log(p_Cinco);
        float p_Cuatro = (float)n_Cuatro / n_Total;
        Debug.Log(p_Cuatro);
        float p_Dos = (float)n_Dos / n_Total;
        Debug.Log(p_Dos);

        float esp_As = (float)p_As * v_As;
        Debug.Log(esp_As);
        float esp_Tres = (float)p_Tres * v_Tres;
        Debug.Log(esp_Tres);
        float esp_Rey = (float)p_Rey * v_Rey;
        Debug.Log(esp_Rey);
        float esp_Caballo = (float)p_Caballo * v_Caballo;
        Debug.Log(esp_Caballo);
        float esp_Sota = (float)p_Sota * v_Sota;
        Debug.Log(esp_Sota);
        float esp_Siete = (float)p_Siete * v_Siete;
        Debug.Log(esp_Siete);
        float esp_Seis = (float)p_Seis * v_Seis;
        Debug.Log(esp_Seis);
        float esp_Cinco = (float)p_Cinco * v_Cinco;
        Debug.Log(esp_Cinco);
        float esp_Cuatro = (float)p_Cuatro * v_Cuatro;
        Debug.Log(esp_Cuatro);
        float esp_Dos = (float)p_Dos * v_Dos;
        Debug.Log(esp_Dos);
    }
}