using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyOrbitrer : OrbiterBase
{
    PlayerOrbiter player;
    // Start is called before the first frame update
    void Start()
    {
        Setup();
        player = GetComponentInParent<Transform>().gameObject.GetComponentInChildren<PlayerOrbiter>();
    }

    // Update is called once per frame  
    void Update()
    {
        if(player != null)
            orbitSpeed = player.currSpeed;

        transform.RotateAround(Vector3.zero, Vector3.forward, orbitSpeed * Time.deltaTime);


    }
}
