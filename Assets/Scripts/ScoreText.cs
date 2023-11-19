using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    public Transform player;
    public Text scoreText;  // Note: "Text" should start with an uppercase T

    // Update is called once per frame
    void Update()
    {
        // Use Mathf.FloorToInt to round down to the nearest integer
        int score = Mathf.FloorToInt(Mathf.Abs(player.position.z)) + 1;

        // Display the non-negative integer score
        scoreText.text = score.ToString();
    }
}
