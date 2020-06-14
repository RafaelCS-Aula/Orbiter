using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyOrbitrer : OrbiterBase
{
    PlayerOrbiter player;

    [Range(-1.00f, 1.00f)]
    public float playerSpeedMultiplier = 1.00f;

    // Start is called before the first frame update
    void Start()
    {
        Setup();
        
        player = GameObject.FindObjectOfType<PlayerOrbiter>();
        print(player);
    }

    // Update is called once per frame
    void Update()
    {

        if (player != null)
            orbitSpeed = player.currSpeed;

        transform.RotateAround(Vector3.zero, Vector3.forward,
            orbitSpeed * playerSpeedMultiplier * Time.deltaTime);


    }
}
