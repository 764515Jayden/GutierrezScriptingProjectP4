using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WhileLoops : MonoBehaviour
{
    //Creating the variables fpr my script
    int cupsInTheSink = 4;

    // Start is called before the first frame update
    void Start()
    {
        //my while loop to check how many cups are in the sink and if there are, it will wash them
        while (cupsInTheSink > 0)
        {
            Debug.Log("I washed a cup!");
            cupsInTheSink--;
        }

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
