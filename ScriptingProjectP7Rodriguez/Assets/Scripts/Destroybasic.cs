using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Destroybasic : MonoBehaviour
{
   

    // Update is called once per frame
    void Update()
    {
      if(Input.GetKeyUp(KeyCode.UpArrow))
      {
            Destroy(gameObject);
      }
    }
}
