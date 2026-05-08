
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    

    public Player player;

    public Enemy currentEnemy;

    [SerializeField] private TMP_Text playerName, playerHP, enemyName, enemyHP;

    [SerializeField] private Image enemyPreview;
    [SerializeField] private Enemy[] allEnemies;
    [SerializeField] private Button attackButton;
    [SerializeField] private TMP_Text gameOverText;

    [SerializeField] private TMP_Text battleLogText;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    private void Start()
    {
        currentEnemy.ResetHealth();
        RefreshUI();
        
      // Debug.Log("Selected name " + selectedChar.charName); 
      // selectedChar.Attack();
    }

    /* private void SetCurrentEnemy()
    {
    }
*/
    public void Fight()
    {
        string battleMessage = "";

        // Player attack
        battleMessage += player.Attack(currentEnemy);

        // Enemy dead?
        if (currentEnemy.IsDead())
        {
            battleMessage += "\n\n"
                             + currentEnemy.CharName
                             + " was defeated!";

            UpdateBattleLog(battleMessage);

            SpawnNewEnemy();

            RefreshUI();

            return;
        }

        // Enemy attack
        battleMessage += "\n\n"
                         + currentEnemy.Attack(player);

        // Player dead?
        if (player.IsDead())
        {
            battleMessage += "\n\nGAME OVER";

            UpdateBattleLog(battleMessage);

            GameOver();

            return;
        }

        UpdateBattleLog(battleMessage);

        RefreshUI();
    }

    private void SpawnNewEnemy()
    {
        currentEnemy = allEnemies[Random.Range(0, allEnemies.Length)];
        currentEnemy.ResetHealth();
        UpdateBattleLog("A new enemy appeared: " + currentEnemy.CharName);
        Debug.Log("New enemy spawned: " + currentEnemy.CharName);
    }

    private void GameOver()
    {
        UpdateBattleLog("Game Over");
        Debug.Log("Game Over");
        attackButton.interactable = false;
        gameOverText.gameObject.SetActive(true);
    }

    private void UpdateBattleLog(string message)
    {
        battleLogText.text = message;
    }

    public void RefreshUI()
    {
        playerName.text = player.CharName;
        playerHP.text = "HP: " + player.Health.ToString("F1");
        
        enemyName.text = currentEnemy.CharName;
        enemyHP.text = "HP: " + currentEnemy.Health.ToString("F1");
        enemyPreview.sprite = currentEnemy.EnemyImage;
    }
    
    

    // Update is called once per frame
    void Update()
    {
        
    }
}
