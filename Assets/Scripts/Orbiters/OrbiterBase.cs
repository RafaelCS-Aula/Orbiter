using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OrbiterBase : MonoBehaviour
{

    [Header("Stage Start Stats")]
    [Tooltip("Orbit 0 is the center.")]
    [Range(0, LevelScript.orbits)]
    public int startOrbit;

    
    [Tooltip("Angle in Degrees. Where it is in orbit.")]
    [Range(0, 360)]
    public int startPosition;

    [Header("PlayTime vars")]
    public int currentOrbit;
    public float orbitSpeed;

    private void Awake()
    {
       
        Setup();
    }
    protected void Setup()
    {
        currentOrbit = startOrbit;

        transform.position = Vector3.zero;
        transform.RotateAround(Vector3.zero,Vector3.forward, startPosition);
        transform.position -= transform.up * LevelScript.levelInstance.orbitDistance * startOrbit;

    }

 

}
