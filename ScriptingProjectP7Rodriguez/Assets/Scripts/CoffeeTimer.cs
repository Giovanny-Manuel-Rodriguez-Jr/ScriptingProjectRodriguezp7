using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoffeeTimer : MonoBehaviour
{
    float coffeTemperature = 85.0f;
    float hotLimitTemperature = 70.0f;
    float coldLimitTemperature = 40.0f;



    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
            TemperatureTest();

        coffeTemperature -= Time.deltaTime * 5f;
    }

    void TemperatureTest()
    {
        // If the coffe's temperature is greather than the hottest drinking temperature...
        if (coffeTemperature > hotLimitTemperature)
        {

            // ... do this.
            print("Coffe is too hot. ");

        }
        // If it isn't,but the coffe temperature is less than the coldest drinking temperature...
        else if (coffeTemperature < coldLimitTemperature)
        {
            // ... do this.
            print("coffe is too cold. ");
        }
        // If it is neither of those then...
        else
        {
            // ... do this.
            print("Coffe is just right.");

        }
    }
}

        