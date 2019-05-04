using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Game : MonoBehaviour
{
    public int lives = 3;
    public int score = 0;
    public GameObject llama;
    public GameObject meteoro, bean, flower;
    public Text scoreText;
    public Text livesText;
    private GameObject cloneEnemy, cloneFlower, cloneBean;
    public GameObject gameOver;
    public float resetDelay = 1f;
    public Button resetB;

    public static Game instance = null;


    private void Start()
    {
        resetB.onClick.AddListener(TaskOnClick);
    }

    void TaskOnClick()
    {
        Reset();
    }


    void Awake()
    {
        if (instance == null)
            instance = this;
        else if (instance != this)
            Destroy(gameObject);
            

    }

    public void Enemy(GameObject enemy, Vector2 whereToSpawn, Quaternion identity)
    {
        cloneEnemy = Instantiate(enemy, whereToSpawn, Quaternion.identity) as GameObject;
        StartCoroutine(live(cloneEnemy));
    }

    public void Flower(GameObject flower, Vector2 whereToSpawn, Quaternion identity)
    {
        cloneFlower = Instantiate(flower, whereToSpawn, Quaternion.identity) as GameObject;
        StartCoroutine(live(cloneFlower));
    }

    public void Bean(GameObject bean, Vector2 whereToSpawn, Quaternion identity)
    {
        cloneBean = Instantiate(bean, whereToSpawn, Quaternion.identity) as GameObject;
        StartCoroutine(live(cloneBean));
    }

    public void LoseLife()
    {
        lives--;
        livesText.text = "Lives: " + lives;
        Destroy(cloneEnemy);
        CheckGameOver();
    }

    public void UpLife()
    {
        lives++;
        livesText.text = "Lives: " + lives;
        Destroy(cloneBean);
    }

    public void UpScore()
    {
        score += 10;
        scoreText.text = "Score: " + score;
        Destroy(cloneFlower);
    }

    void CheckGameOver()
    {

        if (lives < 1)
        {
            gameOver.SetActive(true);
            Time.timeScale = .25f;
            Destroy(llama);
        }

    }

    IEnumerator live(GameObject obj)
    {
        yield return new WaitForSeconds(4.0f);
        Destroy(obj);
    }

    void Reset()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene("SampleScene");
    }

}
