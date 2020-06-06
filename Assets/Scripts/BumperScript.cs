using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(BoxCollider2D))]
public class BumperScript : MonoBehaviour
{

    public OrbiterBase myOrbiter;
    public bool isRight;

    // Start is called before the first frame update
    void Start()
    {

        BoxCollider2D bx = GetComponent<BoxCollider2D>();
        bx.isTrigger = true;

    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        print("bonk");
        myOrbiter.BumperHIt(collision.gameObject.GetComponent<OrbiterBase>(), isRight);

    }
}
