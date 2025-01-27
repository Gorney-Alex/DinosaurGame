// Gorney-Alex Dinosaur Game Runner


using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EndMenu : MonoBehaviour
{
    private StopGame stopGame;
    private bool triggerEndGame;
    [SerializeField] private GameObject endMenuUI;
    private StopGame getStopMoment;


    void Start()
    {
        GameObject getStopTrigger = GameObject.Find("Player");
        getStopMoment = getStopTrigger.GetComponent<StopGame>();
    }
    void Update()
    {
        triggerEndGame = getStopMoment.GetGameIsEnded();
        if (triggerEndGame)
        {
            endMenuUI.SetActive(true);
            Time.timeScale = 0f;
        }
    }

    public void ExitGame()
    {
        Debug.Log("Exiting Game...");
        Application.Quit();
    }

    public void RestartGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
