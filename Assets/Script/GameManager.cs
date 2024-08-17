using UnityEngine;
using UnityEngine.UI;
public class GameManager : MonoBehaviour
{
  public GameObject player;
    //public Player player;
    public Text scoreText;
    public GameObject playButton;
    public GameObject gameOver;
    public GameObject PlayFirstButton;
    private int score;

    private void Awake()
    {
        Application.targetFrameRate = 60;
        player.SetActive(false);
        //player.enabled = false;
        scoreText.text = "";
        playButton.SetActive(false);
        gameOver.SetActive(false);
        PlayFirstButton.SetActive(true);
        Pause();
    }

    public void Play()
    {
        score = 0;

        scoreText.text = score.ToString();
        playButton.SetActive(false);    
        gameOver.SetActive(false);
        PlayFirstButton.SetActive(false);
        Time.timeScale = 1f;

        //player.enabled = true;
        player.SetActive(true);

        Pipes[] pipes = FindObjectsOfType<Pipes>();
        for(int i = 0; i < pipes.Length; i++)
        {
            Destroy(pipes[i].gameObject);
        }
    }

    public void Pause()
    {
        Time.timeScale = 0f;
         //player.enabled=false;
      player.SetActive(false);
    }

    public void GameOver()
    {
        gameOver.SetActive(true);
        playButton.SetActive(true);

        Pause();
    }
    public void IncreaseScore()
    {
        score++;
        scoreText.text = score.ToString();
    }
}
