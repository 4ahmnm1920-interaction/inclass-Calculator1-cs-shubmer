using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Exercise : MonoBehaviour
{
    public int NumeroUno;
    public int NumeroDos;
    public int min1;
    public int min2;

    // Start is called before the first frame update
    void Start()
    {
        Function1();
        Debug.Log(Function2(3, 3));
        Debug.Log(Function3(1.4f, 3.1f));
        Debug.Log(Function4("Cooler", "Codierer"));
    }

    public void Function1() 
    {
        int number1 = 3;
        int number2 = 5;
        Debug.Log(number1 + number2);
    }

    public int Function2(int verena, int maxl)
    {
        return (verena + maxl);
    }

    public float Function3(float var1, float var2)
    { 
        return (var1 + var2);
    }

    public string Function4(string word1, string word2)
    {
        return (word1 + " " + word2);
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log(Random.Range(NumeroUno, NumeroDos) + Random.Range(min1,min2));
    }
}
