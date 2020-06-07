using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OrbitCheckerScript : MonoBehaviour
{
    public bool isObstructed;
    public GameObject obstructor;


    private void OnTriggerStay2D(Collider2D collision)
    {
        isObstructed = true;
        obstructor = collision.gameObject;
        //Debug.Log("bonk");
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        isObstructed = false;
    }

    
}
