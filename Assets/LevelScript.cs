using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelScript : MonoBehaviour
{
    public List<GameObject> Stages;
    public static LevelScript levelInstance;
    public float orbitDistance = 700;
    public int orbits = 5;

    public int currentStageIndex = 0;
    public GameObject currentStage;

    // Start is called before the first frame update
    void Awake()
    {
        if (levelInstance != null && levelInstance != this)
        {
            Destroy(this.gameObject);
        }
        else
            levelInstance = this;

        //LoadStage(currentStageIndex);

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void LoadStage(int stage)
    {
        Destroy(currentStage);
        Instantiate(Stages[stage]);

    }

    private void OnDrawGizmos()
    {

        Gizmos.color = Color.magenta;

        for(int i = 0; i <= orbits; i++)
            Gizmos.DrawWireSphere(transform.position, orbitDistance * i);

    }
}
