using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LivesManager : MonoBehaviour
{
    private ScreenSizeChecker screenSize;
    private RectTransform canvasRectTransf;
    private GameObject[] livesImages;
    [SerializeField] private GameObject lifePrefab;

    public GameObject[] LivesImages { get; }


    private void Awake()
    {
        screenSize = GetComponentInParent<ScreenSizeChecker>();
        canvasRectTransf = GetComponentInParent<RectTransform>();
        livesImages = new GameObject[3];

        for(int i = 0; i < livesImages.Length; i++)
        {
            livesImages[i] = Instantiate<GameObject>(lifePrefab);
            livesImages[i].name = $"Life{i + 1}";
            livesImages[i].transform.SetParent(transform);

            //livesImages[i].transform.position = 
            //    new Vector3( - (Screen.width / 3) * 2,
            //    (Screen.height / 3) * (- i + 1), 0);
            livesImages[i].transform.position = new Vector3(
                - (screenSize.GetScreenToWorldWidth / 6) * 2.25f,
                screenSize.GetScreenToWorldHeight / 3 * (- i + 1), 0);
        }
    }

    public void DisableLife(int index)
    {
        livesImages[index].SetActive(false);
    }
}
