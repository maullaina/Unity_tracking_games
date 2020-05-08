using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class touch_jump : MonoBehaviour
{
    #region Attributed
    public Transform pill;
    public Vector3 returnPosition;
    public Vector3 jumpPosition;
    public float jumpSpeed = 5;
    private bool jump = false;
    #endregion

    #region Monobehaviour API
    void Update()
    {
        if(jump)
        {
            pill.position = Vector3.Lerp(pill.position, jumpPosition, Time.deltaTime * jumpSpeed);
        }
        else
        {
            pill.position = Vector3.Lerp(pill.position, returnPosition, Time.deltaTime * jumpSpeed);
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.tag=="hand")
        {
            jumpPill();
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.tag == "hand")
        {
            returnPill();
        }
    }

    #endregion
    public void returnPill()
    {
        jump = false;
    }
    public void jumpPill()
    {
        jump = true;
    }

}
