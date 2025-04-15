using UnityEngine;

public class PauseMenu : MonoBehaviour
{
    public GameObject pauseMenuUI;
    public bool isPaused;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            isPaused = !isPaused; 
        }

        if (isPaused)
        {
            ActivateMenu();
            Time.timeScale = 0f;
        }

        else
        {
            DeactivateMenu();
            Time.timeScale = 1f;
        }
    }

    void ActivateMenu()
    {
        pauseMenuUI.SetActive(true);
    }

    void DeactivateMenu()
    {
        pauseMenuUI.SetActive(false);
    }
}
