using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlanetoidOrbiter : OrbiterBase
{
    public bool usePlayerSpeed = true;

    [Range(-1.00f, 1.00f)]
    public float playerSpeedModifier = 1.00f;

    PlayerOrbiter player;
    // Start is called before the first frame update
    void Start()
    {
        Setup();

        if (usePlayerSpeed)
        {
            player = GameObject.FindObjectOfType<PlayerOrbiter>();
            orbitSpeed = player.orbitSpeed;
            orbitSpeed *= playerSpeedModifier;

        }
            
    }

    // Update is called once per frame
    void Update()
    {

            transform.RotateAround(Vector3.zero, Vector3.forward, orbitSpeed * Time.deltaTime);



    }
}
