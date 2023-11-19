using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    bool gameHasEnded = false;
    bool shouldRestart = false; // Flag to indicate if a restart is requested
    public float restartDelay = 1f;

    public GameObject gameOverUI;       // Reference to the game over UI GameObject
    public GameObject tryAgainUI;       // Reference to the try again UI GameObject

    void Start()
    {
        // Make sure the UI elements are initially disabled
        if (gameOverUI != null)
        {
            gameOverUI.SetActive(false);
        }

        if (tryAgainUI != null)
        {
            tryAgainUI.SetActive(false);
        }
    }

    public void CompleteLevel()
    {
        // Activate the UI elements for completing the level
        if (tryAgainUI != null)
        {
            tryAgainUI.SetActive(true);
        }

        Debug.Log("LEVEL WON!");
    }

    public void EndGame()
    {
        if (!gameHasEnded)
        {
            gameHasEnded = true;
            Debug.Log("Game Over!");

            // Activate the game over UI elements
            if (gameOverUI != null)
            {
                gameOverUI.SetActive(true);
            }

            // Do not automatically restart, set the flag for manual restart
            shouldRestart = true;
        }
    }

    // Restart the current scene (called by button click)
    public void RestartGame()
    {
        if (shouldRestart)
        {
            // Reload the current scene after a delay
            Invoke("Restart", restartDelay);
        }
    }

    // Method to activate tryAgainUI (call this from a button click or other event)
    public void ActivateTryAgainUI()
    {
        if (tryAgainUI != null)
        {
            tryAgainUI.SetActive(true);
        }
    }

    // Reset the shouldRestart flag when the scene is loaded
    void OnEnable()
    {
        shouldRestart = false;
    }

    // Restart the current scene
    void Restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
