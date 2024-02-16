using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Destroybasic : MonoBehaviour
{
   

    // Update is called once per frame
    void Update()
    {
      if(Input.GetKey(KeyCode.UpArrow))
      {
            Destroy(gameObject);
      }
    }
}
