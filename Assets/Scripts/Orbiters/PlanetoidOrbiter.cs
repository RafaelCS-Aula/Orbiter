using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlanetoidOrbiter : OrbiterBase
{
    // Start is called before the first frame update
    void Start()
    {
        Setup();
    }

    // Update is called once per frame
    void Update()
    {
        transform.RotateAround(Vector3.zero, Vector3.forward, orbitSpeed * Time.deltaTime);
    }
}
