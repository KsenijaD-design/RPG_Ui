using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    [SerializeField] private player player;
    [SerializeField] private enemy enemy;
    [SerializeField] private enemy[] enemyPrefabs; 
    [SerializeField] private TMP_Text playerName, enemyName,playerHP,enemyHP;
    [SerializeField] private GameObject gameOverPanel;
    [SerializeField] private Image enemyImageUI;
   
    void Start()
    {
        SpawnNewEnemy();
        UpdateUI();
    }

    private void UpdateUI()
    {
        playerName.text = player.CharName;
        enemyName.text = enemy.CharName;
        playerHP.text = "HP: " + player.health.ToString("F1");
        enemyHP.text = "HP: " + enemy.health.ToString("F1");
        enemyImageUI.sprite = enemy.EnemyImage;
    }
    public void SpawnNewEnemy()
    {
        if (enemy != null)
        {
            Destroy(enemy.gameObject);
        }
        int randomIndex = Random.Range(0, enemyPrefabs.Length);
        enemy = Instantiate(enemyPrefabs[randomIndex]);
        UpdateUI();
    }
    //poga
    public void PlayerAttack()
    {
        player.Attack(enemy);
        enemy.Attack(player);
        UpdateUI();
    }

    public void GameOver()
    {
        gameOverPanel.SetActive(true);
        Time.timeScale = 0;
    }

    public void Again()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }

    
    void Update()
    {
        
    }
}
