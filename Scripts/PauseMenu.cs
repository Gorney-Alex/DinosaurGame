using UnityEngine;
using UnityEngine.SceneManagement;

public class StopGameMoment : MonoBehaviour
{
    [SerializeField] private GameObject pauseMenuUI;

    private bool isPaused = false;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (isPaused)
            {
                ResumeGame();
            }
            else
            {
                PauseGame();
            }
        }
    }

    public void ResumeGame()
    {
        pauseMenuUI.SetActive(false); // Скрываем меню
        Time.timeScale = 1f;         // Возвращаем время
        isPaused = false;
    }

    public void PauseGame()
    {
        pauseMenuUI.SetActive(true); // Показываем меню
        Time.timeScale = 0f;         // Останавливаем время
        isPaused = true;
    }

    public void ExitGame()
    {
        Debug.Log("Exiting Game...");
        Application.Quit();          // Закрывает игру
    }
}
