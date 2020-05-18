using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelScript : MonoBehaviour
{
    public List<GameObject> Stages;
    
    public float orbitDistance = 100;
    public const int orbits = 4;

    [SerializeField]private int currentStage = 0;
    [SerializeField] private GameObject currentStageObjects;

    [Tooltip("Pls make sure you drag a scene asset into here this is beyond scuffed")]
    [SerializeField] private Object victoryScene;
    [SerializeField] private Object defeatScene;

    public static LevelScript levelInstance;
    // Start is called before the first frame update
    void Awake()
    {
        if (levelInstance != null && levelInstance != this)
        {
            Destroy(this.gameObject);
        }
        else
            levelInstance = this;

        LoadStage(currentStage);

    }

    public void WinStage()
    {
        if (currentStage < Stages.Count)
            LoadStage(++currentStage);
        else
            // Doesnt work for some reason
            SceneManager.LoadScene(victoryScene.name);


    }
                                // Same problem as above
    public void LoseStage() => SceneManager.LoadScene(defeatScene.name);
        

    private void LoadStage(int stage)
    {
        Destroy(currentStageObjects);
        currentStageObjects = Instantiate(Stages[stage - 1]);
        Debug.Log("loading stage: " + stage);

    }

    private void OnDrawGizmos()
    {

        Gizmos.color = Color.magenta;

        for(int i = 0; i <= orbits; i++)
            Gizmos.DrawWireSphere(transform.position, orbitDistance * i);

    }
}
