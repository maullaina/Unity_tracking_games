using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class touch_rotate : MonoBehaviour
{
    public Transform cube;
    public Vector3 rotationSpeed;
    private bool touch = false;

    void OnTriggerEnter(Collider other)
    {
        if (other.tag == "hand")
        {
            print("touched ROTATE");
            touch=true;
        }          
    }
    void Update()
    {
        if(touch)
        {
            cube.Rotate(rotationSpeed * Time.deltaTime);
        }
    }
}