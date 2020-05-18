using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelScript : MonoBehaviour
{
    public List<GameObject> Stages;
    public static LevelScript levelInstance;
    public float orbitDistance = 100;
    public const int orbits = 5;

    [SerializeField]private int currentStage = 1;
    [SerializeField] private GameObject currentStageObjects;

    [Tooltip("Pls make sure you drag a scene asset into here this is beyond scuffed")]
    [SerializeField] private Object victoryScene;
    [SerializeField] private Object defeatScene;

    // Start is called before the first frame update
    void Awake()
    {
        if (levelInstance != null && levelInstance != this)
        {
            Destroy(this.gameObject);
        }
        else
            levelInstance = this;

        //LoadStage(currentStage);

    }

    public void WinStage()
    {
        if (currentStage < Stages.Count)
            LoadStage(currentStage++);
        else
            // Doesnt work for some reason
            SceneManager.LoadScene(victoryScene.name);


    }
                                // Same problem as above
    public void LoseStage() => SceneManager.LoadScene(defeatScene.name);
        

    private void LoadStage(int stage)
    {
        Destroy(currentStageObjects);
        Instantiate(Stages[stage - 1]);

    }

    private void OnDrawGizmos()
    {

        Gizmos.color = Color.magenta;

        for(int i = 0; i <= orbits; i++)
            Gizmos.DrawWireSphere(transform.position, orbitDistance * i);

    }
}
