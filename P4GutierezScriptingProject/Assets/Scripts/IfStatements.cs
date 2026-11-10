using UnityEngine;
using System.Collections;

public class IfStatements : MonoBehaviour
{
    float coffeeTemperature = 85.0f;
    float hotLimitTemperature = 70.0f;
    float coldLimitTemperature = 40.0f;


    void update ()
    {
        if(Input.GetKeyDown(KeyCode.Space))
            TemperatureTest();

        coffeeTemperature -= Time.deltaTime * 5f;
    }

    void TemperatureTest()
    {
        // If the cofffe's temperature is greater than the hottest drinking temperature...
        if(coffeeTemperature > hotLimitTemperature)
        {
            //...do this.
            print("Coffee is too hot.");
        }
        //If it isnt, but the coffee tempurature is less then than the coldest drinking temperature...
        else if(coffeeTemperature < coldLimitTemperature)
        {
            //...do this.
            print("Coffee is too cold.");
        }
        // If it is neither of those, then...
        else
        {
            //...do this.
            print("Coffee is just right.");
        }
    }
}
