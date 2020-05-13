using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotator : MonoBehaviour
{
    public float RotationSpeed = 20f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(Vector3.left * (RotationSpeed * Time.deltaTime));
        //transform.Rotate(45 * (RotationSpeed * Time.deltaTime));
    }
}
