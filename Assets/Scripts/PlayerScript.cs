using UnityEngine;

public class PlayerScript : MonoBehaviour
{
    public Rigidbody rb;
    public float forwardForce = 300f;
    public float sidewaysForce = 50f;
    public float jumpForce = 0.5f;   
    public float straightWalkForce = 100f; // Adjust the force for walking straight

    void Start()
    {
        rb = GetComponent<Rigidbody>();
        rb.AddForce(0, 22, 500);
    }

    void Update()
    {
        // Check for the jump input (space bar)
        if (Input.GetButtonDown("Jump"))
        {
            Jump();
        }
    }

    void Jump()
    {
        rb.AddForce(Vector3.up * jumpForce, ForceMode.Impulse);
    }

    void FixedUpdate()
    {
        rb.AddForce(0, 0, forwardForce * Time.deltaTime);

        if (Input.GetKey("l"))
        {
            rb.AddForce(sidewaysForce * Time.deltaTime, 0, 0);
        }

        if (Input.GetKey("a"))
        {
            rb.AddForce(-sidewaysForce * Time.deltaTime, 0, 0);
        }

        // Check for the button to walk straight (for example, "w" key)
        if (Input.GetKey("w"))
        {
            // Apply force for walking straight
            rb.AddForce(Vector3.forward * straightWalkForce * Time.deltaTime);
        }

        if (rb.position.y < 0f)
        {
            FindObjectOfType<GameManager>().EndGame();
        }
    }
}
