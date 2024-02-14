using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InterpilationLinear : MonoBehaviour
{/*
    //The Mathf.Lerp function takes 3 float parameters: one representing the value to interpolate from; another representing the value to interpolate to and a final float representing how far to interpolate. In this case, the interpolation value is 0.5 which means 50%. shows how the interpolate and final float work
    float result = Mathf.Lerp(3f, 5f, 0.5f);


    //In this case the result is (4, 5, 6) because 4 is 75% of the way between 1 and 5; 5 is 75% of the way between 2 and 6 and 6 is 75% of the way between 3 and 7. This shows what the 1f and other numbers work and mean.
    Vector3 from = new Vector3(1f, 2f, 3f);
    Vector3 to = new Vector3(5f, 6f, 7f);

    // Here result = (4, 5, 6) these are the answers

    Vector3 result = Vector3.Lerp(from, to, 0.75f);

    //If the intensity of the light starts off at 0 then after the first update it will be set to 4. The next frame it will be set to 6, then to 7, then to 7.5 and so on. Thus over several frames, the lights intensity will tend towards 8 but the rate of its change will slow as it approaches its target. it makes it approach slow
     void Update()
    {
        light.intensity = Mathf.Lerp(light.intensity, 8f, 0.5f * Time.deltaTime);
    }*/
}
