using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PropellerController : MonoBehaviour
{
    //to make the propeller spin
    public float rotationSpeed = 1000f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // Rotate the propeller around its local Z-axis (or whichever axis the propeller spins around)
        transform.Rotate(Vector3.forward * rotationSpeed * Time.deltaTime);
    }
}
