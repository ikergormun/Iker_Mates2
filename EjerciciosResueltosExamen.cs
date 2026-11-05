using UnityEngine;

public class EjerciciosExamen : MonoBehaviour
{
    
    //2.Contar cartas: Crea un botón, dentro del Canvas que ya hay creado, que al pulsarlo 
    // cuente cuántas cartas hay en total y cuántas cartas de cada número hay (solo de 
    // cada número el palo nos da igual). Para conocer el valor de la carta: el componente 
    // CardDisplay tiene la función GetRankValue() que devuelve el valor numérico de la 
    // carta. Prueba a añadir más cartas y cambiarles el valor para testear bien.

    //Primero creamos una variable para acceder al transform de Hand
    [SerializeField] Transform misCartas;

    //Para ambas soluciones hay que tener en cuenta que GetCardRank devuelve el valor de la carta según las reglas de la brisca
    //solución 1: tener variables para contar cada numero.
    public void ContarCartasSinArray()
    {
        //Version facil contar cartas totales: 
        print("Total cartas: " + misCartas.childCount);

        int ace = 0, dos = 0, tres = 0, cuatro = 0, cinco = 0, seis = 0, siete = 0, sota = 0, caballo = 0, rey = 0;
        foreach(Transform carta in misCartas)
        {
            int rank = (int)carta.GetComponent<CardDisplay>().GetCardData().GetCardRank();
            if(rank == 0) dos++;
            else if(rank == 1) cuatro++;
            else if(rank == 2) cinco++;
            else if(rank == 3) seis++;
            else if(rank == 4) siete++;
            else if(rank == 5) sota++;
            else if(rank == 6) caballo++;
            else if(rank == 7) rey++;
            else if(rank == 8) tres++;
            else if(rank == 9) ace++;
        }

        if(ace != 0) print("Hay " + ace + " ases");
        if(dos != 0) print("Hay " + dos + " dos");
        if(tres != 0) print("Hay " + tres + " ases");
        if(cuatro != 0) print("Hay " + cuatro + " cuatros");
        if(cinco != 0) print("Hay " + cinco + " cincos");
        if(seis != 0) print("Hay " + seis + " seis");
        if(siete != 0) print("Hay " + siete + " sietes");
        if(sota != 0) print("Hay " + sota + " sotas");
        if(caballo != 0) print("Hay " + caballo + " caballos");
        if(rey != 0) print("Hay " + rey + " reyes");
    }

    //opción 2: tener un array para guardar los valores en cada posición correspondiente

    int [] ranksInHand = new int[10]; //<--- ponemos el array fuera porque lo usaremos en el ejercicio 3

    public void ContarCartas()
    {
        print("Total cartas: " + misCartas.childCount);
        
        foreach(Transform carta in misCartas)
        {
            int rank = (int)carta.GetComponent<CardDisplay>().GetCardData().GetCardRank();
            ranksInHand[rank]++; //<--- Piensa bien qué hace esto, prueba a hacerlo en papel
        }

        //Tener en cuenta que:
        //dos --> ranksInHand[0]
        //...
        //tres --> ranksInHand[8]
        //ace --> ranksInHand[9]
        if(ranksInHand[0] != 0) print("Hay " + ranksInHand[0] + " dos");
        if(ranksInHand[8] != 0) print("Hay " + ranksInHand[8] + " tres");
        if(ranksInHand[9] != 0) print("Hay " + ranksInHand[9] + " ases");
    }

    //3. Esperanza: Teniendo en cuenta las cartas que hay en Cards, y suponiendo que no 
    // hay cartas duplicadas, calcula la esperanza total del siguiente juego: 
    // Suponemos que las cartas que hay en “Cards” son la mano del jugador y que hay 
    // un mazo de donde puede coger cartas. Si saca un as o un tres gana la partida, 
    // si saca una figura (sota, caballo o rey) empata y si saca cualquier otra cosa pierde.

    public void Esperanza()
    {
        //Asignamos los valores que queramos a cada situación
        int vGanar = 3;
        int vEmpate = 0;
        int vPerder = -1;

        int totalCartas = 40; //total de cartas en el mazo (pueden ser 48 si hubieran ochos y nueves)
    
        //8, 12 y 16 se podrían cambiar con cálculos
        float pGanar = (8 - (ranksInHand[8] + ranksInHand[9])) / totalCartas;
        float eGanar = pGanar * vGanar;
        float pEmpate = (12 - (ranksInHand[5] + ranksInHand[6] + ranksInHand[7])) / misCartas.childCount;
        float eEmpate = pEmpate * vEmpate;
        float pPerder = (16 - (ranksInHand[0] + ranksInHand[1] + ranksInHand[2] + ranksInHand[3])) / misCartas.childCount;
        float ePerder = pPerder * vPerder;


        float eTotal = eGanar + eEmpate +ePerder;
        print("La esperanza total es: " + eTotal);
    }

    //4. A cuántas gano: Las cartas también tienen el componente “Button”. 
    // Diseña e implementa un algoritmo que, al pulsar una carta, compruebe a 
    // cuántas cartas de la mano puede ganar (es mayor). Haz una versión recursiva y 
    // otra iterativa de este algoritmo.

    //Para este ejercicio tendríamos que poner este script en una carta y asignarle el propio script al componente button de la carta
    int selectedCardRank = 0;
    void Start()
    {
        //Primero de todo asignamos el rank de la carta pulsada
        if(this.GetComponent<CardDisplay>() != null) selectedCardRank = (int)this.GetComponent<CardDisplay>().GetCardData().GetCardRank();
    }
    
    //Versión iterativa
    public void ACuantasGanoIt()
    {
        int contador = 0;
        foreach(Transform card in misCartas)
        {
            int cardRank = (int)card.GetComponent<CardDisplay>().GetCardData().GetCardRank();
            if(selectedCardRank > cardRank) contador++;
        }
        print("Gano a: " + contador);
    }

    //Versión recursiva utilizando una segunda función auxiliar como en las soluciones recursivas de recorrer arrays/vectores
    public void ACuantasGanoRec()
    {
        print("Gano a: " + ACuantasGanoRecAux(misCartas, selectedCardRank, 0, 0));
    }

    private int ACuantasGanoRecAux(Transform hand, int selectedCardRank, int i, int contador)
    {
        if(i >= hand.childCount) return contador;
        if (selectedCardRank > (int)hand.GetChild(i).GetComponent<CardDisplay>().GetCardData().GetCardRank()) contador++;
        return ACuantasGanoRecAux(hand, selectedCardRank, i+1, contador);
    }

    //El ejercicio 5 de análisis de algoritmos hazlo por tu propia cuenta en cada solución propuesta aquí.
}
