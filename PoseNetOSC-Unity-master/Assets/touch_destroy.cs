using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class touch_destroy : MonoBehaviour
{
    public GameObject sphere;
    void OnTriggerEnter(Collider other)
    {
        if (other.tag == "hand")
        {
            print("touched");
            Destroy(sphere, .5f);
        }
    }

}