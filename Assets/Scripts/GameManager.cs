using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;
using UnityEngine.UI;


public class GameManager : MonoBehaviour
{
  public static GameManager Instance { get; private set; }
  public List<GameObject> targets;
  public TextMeshProUGUI scoreText;
  public TextMeshProUGUI gameOverText;
  public Button restartButton;
  public GameObject titleScreen;
  public bool isGameActive;
  private int score;
  public float spawnRate = 1f;
  public AudioSource backgroundMusic;

  private void Awake()
  {
    // Implementación del Singleton
    if (Instance == null)
    {
      Instance = this;
    }
    else
    {
      Destroy(gameObject); // Si ya existe un GameManager, destruye el duplicado
      return;
    }
  }

  void Start()
  {
     if (backgroundMusic != null)
        {
            backgroundMusic.Play();
        }
  }
   public void ToggleMusic()
    {
        if (backgroundMusic != null)
        {
            backgroundMusic.mute = !backgroundMusic.mute;
        }
    }

  IEnumerator SpawnTarget()
  {
    while (isGameActive)
    {
      yield return new WaitForSeconds(spawnRate);
      int index = Random.Range(0, targets.Count);
      Instantiate(targets[index]);
    }
  }

  public void UpdateScore(int scoreToAdd)
  {
    score += scoreToAdd;
    scoreText.text = "Score: " + score;
  }

  public void GameOver()
  {
    isGameActive = false;
    gameOverText.gameObject.SetActive(true);
    restartButton.gameObject.SetActive(true);
  }

  public void RestartGame()
  {
    SceneManager.LoadScene(SceneManager.GetActiveScene().name);
  }

  public void StartGame(int difficulty)
  {
    isGameActive = true;
    score = 0;
    spawnRate /= difficulty;

    StartCoroutine(SpawnTarget());
    UpdateScore(0);

    titleScreen.gameObject.SetActive(false);
  }
}
