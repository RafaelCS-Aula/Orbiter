using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScreenSizeChecker : MonoBehaviour
{
    // To reuse any code that checks the screen to world sizes, this script, or
    // the code in it, must be used as well
    public float GetScreenToWorldHeight
    {
        get
        {
            Vector2 topRightCorner = new Vector2(1, 1);
            Vector2 edgeVector =
                Camera.main.ViewportToWorldPoint(topRightCorner);

            float height = edgeVector.y * 2;
            return height;
        }
    }

    public float GetScreenToWorldWidth
    {
        get
        {
            Vector2 topRightCorner = new Vector2(1, 1);
            Vector2 edgeVector =
                Camera.main.ViewportToWorldPoint(topRightCorner);

            float width = edgeVector.x * 2;
            return width;
        }
    }
}
