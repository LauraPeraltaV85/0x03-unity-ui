using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerController : MonoBehaviour
{
    public float speed;
    public float backFord;
    public float sides;
    public Rigidbody rb;
    private int score = 0;
    public int earnPoints = 100;
    public int health = 5;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if (Input.GetKey("a") || Input.GetKey(KeyCode.LeftArrow))
        {
            rb.AddForce(-sides * Time.deltaTime, 0, 0);
        }
        else if (Input.GetKey("d") || Input.GetKey(KeyCode.RightArrow))
        {
            rb.AddForce(sides * Time.deltaTime, 0, 0);
        }
        else if (Input.GetKey("w") || Input.GetKey(KeyCode.UpArrow))
        {
            rb.AddForce(0, 0, backFord * Time.deltaTime);
        }
        else if (Input.GetKey("s") || Input.GetKey(KeyCode.DownArrow))
        {
            rb.AddForce(0, 0, -backFord * Time.deltaTime);
        }
    }

    void Update()
    {
        if (health == 0)
        {
            Debug.Log("Game Over!");
            Scene currentScene = SceneManager.GetActiveScene();
            SceneManager.LoadScene(currentScene.name);
        }
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Pickup"))
        {
            Destroy(other.gameObject);
            score += earnPoints;
            Debug.Log("Score: " + score);
        }
        if (other.gameObject.CompareTag("Trap"))
        {
            health -= 1;
            Debug.Log("Health: " + health);
        }
        if (other.gameObject.CompareTag("Goal"))
        {
            Debug.Log("You win!");
        }
    }
}
