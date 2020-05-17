using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player : MonoBehaviour
{
    public float speed;

    public float orbitJumpCooldown;

    private float orbitCooldownCounter;

    public GameObject forwardChecker;



    // Start is called before the first frame update
    void Start()
    {
        orbitCooldownCounter = 0;
        Instantiate(forwardChecker, transform.position - transform.right * LevelScript.levelInstance.orbitDistance, transform.rotation,this.transform);
        
    }

    // Update is called once per frame
    void Update()
    {

        orbitCooldownCounter += Time.deltaTime;

        transform.RotateAround(Vector3.zero, Vector3.forward, Input.GetAxis("Horizontal") * speed * Time.deltaTime);

        if (Input.GetAxis("Vertical") > 0 && orbitCooldownCounter >= orbitJumpCooldown)
        {
                    


        }


    }
}
