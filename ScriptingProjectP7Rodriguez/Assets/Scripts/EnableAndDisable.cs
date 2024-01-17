using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnableAndDisable : MonoBehaviour
{
    // Start is called before the first frame update
    private Light myLight;

    void Start()
    {
        myLight = GetComponent<Light>();
    }

    private void Update()
    {
        if(Input.GetKeyUp(KeyCode.Space))
        {
            myLight.enabled = !myLight.enabled;
        }
    }

}
