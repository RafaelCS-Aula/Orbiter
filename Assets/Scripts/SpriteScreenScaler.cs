using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpriteScreenScaler : MonoBehaviour
{
    private ScreenSizeChecker screenSize;
    private SpriteRenderer spriteRenderer;


    // Awake is called when the script instance is being loaded.
    void Awake()
    {
        screenSize = GetComponentInParent<ScreenSizeChecker>();
        spriteRenderer = GetComponent<SpriteRenderer>();
    }

    // Start is called before the first frame update
    void Start()
    {
        Debug.Log(Camera.main.orthographic);
        Debug.Log(screenSize.GetScreenToWorldWidth);
        Debug.Log(screenSize.GetScreenToWorldHeight);
        Vector3 screenSizeVec =
            new Vector3(screenSize.GetScreenToWorldWidth, screenSize.GetScreenToWorldHeight, 0);
        Vector3 spriteSize = new Vector3(spriteRenderer.bounds.size.x,
                spriteRenderer.bounds.size.y, 0);

        Vector3 newSpriteScale =
            new Vector3((screenSizeVec.x * transform.localScale.x) / spriteSize.x,
                (screenSizeVec.y * transform.localScale.y) / spriteSize.y, 0);

        Debug.Log($"new scale: x - {newSpriteScale.x}, y - {newSpriteScale.y}");

        transform.localScale = newSpriteScale;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
