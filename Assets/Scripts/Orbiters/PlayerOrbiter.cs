using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerOrbiter : OrbiterBase
{
    [Header("Player Specific Variables")]
    public int maxLife = 3;
    public int life;

    public float orbitJumpCooldown = 0.5f;

    public float orbitCooldownCounter;

    public GameObject forwardChecker;

    [HideInInspector]
    public OrbitCheckerScript forwardOrbiter;

   

    // Start is called before the first frame update
    void Awake()
    {
        Setup();

        life = maxLife;
        orbitCooldownCounter = 0;
        GameObject instantiated = Instantiate(forwardChecker, transform.position + transform.up * LevelScript.levelInstance.orbitDistance, transform.rotation,this.transform);
        forwardOrbiter = instantiated.GetComponent<OrbitCheckerScript>();
    }

    // Update is called once per frame
    void Update()
    {

        orbitCooldownCounter += Time.deltaTime;

        transform.RotateAround(Vector3.zero, Vector3.forward, Input.GetAxis("Horizontal") * orbitSpeed * Time.deltaTime);

        
        if (Input.GetAxis("Vertical") > 0 && orbitCooldownCounter > orbitJumpCooldown)
        {
            // allow jump if on last orbit no matter what since everything is so tight together there.
            if (forwardOrbiter.isObstructed && currentOrbit != 1)
            {




            }
            else
            {
                transform.position += transform.up * LevelScript.levelInstance.orbitDistance;
                orbitCooldownCounter = 0;
                currentOrbit--;


            }


        }

        if (currentOrbit == 0)
            LevelScript.levelInstance.WinStage();
        if (life <= 0)
        {
            LevelScript.levelInstance.LoseStage();
        }

    }
}
