using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UsingInstanciate : MonoBehaviour
{
    public Rigidbody rocketPrefab;
    public Transform barrelEnd;

    // Update is called once per frame
    void Update()
    {
        if(Input.GetButtonDown("Fire1"))
        {
            Rigidbody rocketInstance;
            rocketInstance = Instantiate(rocketPrefab, barrelEnd.position, barrelEnd.rotation) as Rigidbody;
            rocketInstance.AddForce(barrelEnd.forward * 5000);
        }
    }
}
