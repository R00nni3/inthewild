using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance;

    [Header("Vidas")]
    public int lives = 3;
    public float invicibilityTime = 1f; //Invisibilidad de 1 segundo después de perder una vida para no perder todas de un solo golpe. 
    private float lastHitTime = -10f;

    [Header("Referencias")]
    public Transform spawnPoint;
    public GameObject player;

    [Header("Paneles UI")]
    public GameObject startPanel;
    public GameObject gameOverPanel;
    public GameObject victoryPanel;

    private bool gameEnded = false;

    void Awake()
    {
        if (Instance == null) Instance = this;
        else Destroy(gameObject);
    }
    void Start()
    {
        if (startPanel != null)
        {
            startPanel.SetActive(true);
            Time.timeScale = 0f;
        }
    }

    public void StartGame()
    {
        if (startPanel != null) startPanel.SetActive(false);
        Time.timeScale = 1f;
    }

    public void LoseLife()
    {
        if (gameEnded) return;
        if (Time.time - lastHitTime < invicibilityTime) return;

        lastHitTime = Time.time;
        lives--;

        if (lives <= 0)
            GameOver();
        else
            RespawnPlayer();
    }

    void RespawnPlayer()
    {
        player.transform.position = spawnPoint.position;
        Rigidbody2D rb = player.GetComponent<Rigidbody2D>();
        if (rb != null) rb.linearVelocity = Vector2.zero;
    }

    void GameOver()
    {
        gameEnded = true;
        if (gameOverPanel != null) gameOverPanel.SetActive(true);
        Time.timeScale = 0f;
    }

    public void WinGame()
    {
        if (gameEnded) return;
        gameEnded = true;
        if (victoryPanel != null) victoryPanel.SetActive(true);
        Time.timeScale = 0f;
    }

    public void RestartLevel()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    public void QuitGame()
    {
#if UNITY_EDITOR
        UnityEditor.EditorApplication.isPlaying = false;
#else
        Application.Quit();
#endif
    }
}
