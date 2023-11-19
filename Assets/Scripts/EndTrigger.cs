using UnityEngine;

public class EndTrigger : MonoBehaviour
{
    // Start is called before the first frame update
  //
    public void quit ()
    {
        Debug.Log ("QUIT");
        Application.Quit();
    }
    //
    public GameManager gameManager;
    void OnTriggerEnter ()
    {
        gameManager.CompleteLevel();
    }
}
