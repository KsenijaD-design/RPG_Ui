using TMPro;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    [SerializeField] private player player;
    [SerializeField] private enemy enemy;
    [SerializeField] private TMP_Text playerName, enemyName,playerHP,enemyHP;
   
    void Start()
    {
        UpdateUI();
    }

    private void UpdateUI()
    {
        playerName.text = player.CharName;
        enemyName.text = enemy.CharName;
        playerHP.text = "HP: " + player.health.ToString("F1");
        enemyHP.text = "HP: " + enemy.health.ToString("F1");
    }

    //poga
    public void PlayerAttack()
    {
        player.Attack(enemy);
        enemy.Attack(player);
        UpdateUI();
    }
    void Update()
    {
        
    }
}
