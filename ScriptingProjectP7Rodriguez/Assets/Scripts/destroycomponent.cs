using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class destroycomponent : MonoBehaviour
{
    
    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyUp(KeyCode.Space))
        {
            Destroy(GetComponent<MeshRenderer>());
        }
    }
}
