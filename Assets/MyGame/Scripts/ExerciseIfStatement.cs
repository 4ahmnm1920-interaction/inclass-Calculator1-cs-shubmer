using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ExerciseIfStatement : MonoBehaviour
{
    public bool condition;
    public string text;
    public string text2;

    // Start is called before the first frame update
    void Start()
    {
        /*if (condition)
        {
            Debug.Log("Diese Aussage(Condition) ist richtig!");
        }
        else
        {
            Debug.Log("Diese Aussage(Condition) ist falsch!");
        }*/
    }

    // Update is called once per frame
    void Update()
    {
        //IF Statement FLoat Value
        /*float var1 = Random.Range(5f, 15f);

        if (var1 < 10)
        {
            Debug.Log("Der Wert ist kleiner als 10");
        }
        else
        {
            Debug.Log("Der Wert ist größer als 10");
        }
        
        //IF Statement String Values

        if (text == text2)
        {
            Debug.Log("Text1 entspricht Text2");
        }
        else
        {
            Debug.Log("Text1 enspricht nicht Text2!!!!!");
        }


        //IF Statements mit mehreren Conditionen
        // && Und - Beide Conditions müssen richtig sein dass es ausgeführt wird
        // || Oder - Eines der Conditionen müssen stimmen damit es ausgeführt wird
        if (text == text2 && condition)
        {
            Debug.Log("Beide Conditions sind richtig");
        }

        if (text == text2 ||condition)
        {
            Debug.Log("Eine der beiden Conditions ist richtig");
        }*/
        if (condition)
        {
        if (text ==  "Statement")
            {
                Debug.Log("Der Text ist das Statement");
            }
        else
            {
                Debug.Log("Der Text ist nicht Statement");
            }
        }
        else
        {
            Debug.Log("Bitte Condition anhakeln");
        }

    }
}
