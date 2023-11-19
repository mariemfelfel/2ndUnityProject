using UnityEngine;
using UnityEngine.SceneManagement;

public class TryAgain : MonoBehaviour
{
    public void TryAgainMethod()
    {
        // Load the main scene
        SceneManager.LoadScene("Game"); 
    }
}
