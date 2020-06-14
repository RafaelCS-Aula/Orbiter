using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LivesManager : MonoBehaviour
{
    private RectTransform canvasRectTransf;
    private GameObject[] livesImages;
    private Camera camera;
    [SerializeField] private GameObject lifePrefab;

    public GameObject[] LivesImages { get; }

    private void Awake()
    {
        canvasRectTransf = GetComponentInParent<RectTransform>();
        camera = FindObjectOfType<Camera>();
        livesImages = new GameObject[3];

        for(int i = 0; i < livesImages.Length; i++)
        {
            livesImages[i] = Instantiate<GameObject>(lifePrefab);
            livesImages[i].name = $"Life{i + 1}";
            livesImages[i].transform.parent = transform;

            livesImages[i].transform.position = 
                new Vector3( - (Screen.width / 3) * 2,
                (Screen.height / 3) * (- i + 1), 0);
            //livesImages[i].
        }
    }
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void DisableLife(int index)
    {
        livesImages[index].SetActive(false);
    }
}
