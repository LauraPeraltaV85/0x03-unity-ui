using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class PlayerController : MonoBehaviour
{
    public float speed;
    public float backFord;
    public float sides;
    public Rigidbody rb;
    private int score = 0;
    public int earnPoints = 100;
    public int health = 5;
    public Text scoreText;
    public Text winLoseText;
    public Image winLoseBG;
    public Text healthText;
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
            //Debug.Log("Game Over!");
            winLoseBG.gameObject.SetActive(true);
            winLoseText.text = "Game Over!";
            StartCoroutine(LoadScene(3));
        }

        if (Input.GetKey(KeyCode.Escape))
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 1);
        }
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Pickup"))
        {
            Destroy(other.gameObject);
            score += earnPoints;
            //Debug.Log("Score: " + score);
            SetScoreText();
        }
        if (other.gameObject.CompareTag("Trap"))
        {
            health -= 1;
            //Debug.Log("Health: " + health);
            SetHealthText();
        }
        if (other.gameObject.CompareTag("Goal"))
        {
            //Debug.Log("You win!");
            winLoseBG.gameObject.SetActive(true);
            winLoseBG.color = Color.green;
            winLoseText.color = Color.black;
            winLoseText.text = "You Win!";
            StartCoroutine(LoadScene(3));
        }
    }

    void SetScoreText()
    {
        scoreText.text = "Score: " + score.ToString();
    }
    
    void SetHealthText()
    {
        healthText.text = "Health: " + health.ToString();
    }

    IEnumerator LoadScene(float seconds)
    {
        yield return new WaitForSeconds(seconds);
        Scene currentScene = SceneManager.GetActiveScene();
        SceneManager.LoadScene(currentScene.name);
    }
}
