using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Orbiting_Moon : MonoBehaviour
{
    public float rotationSpeed = 50;
    // Start is called before the first frame update

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(Vector3.up, rotationSpeed * Time.deltaTime);
        
    }
}
