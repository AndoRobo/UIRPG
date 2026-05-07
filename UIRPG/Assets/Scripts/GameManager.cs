
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
        player.Attack(currentEnemy);
        
        //enemy dead?
        if (currentEnemy.IsDead())
        {
            //Destroy(currentEnemy.gameObject);
            
            SpawnNewEnemy();
            RefreshUI();
            return;
        }

        //enemy attacks player
        currentEnemy.Attack(player);
        
        // Player dead?

        if (player.IsDead())
        {
            GameOver();
            return;
        }

        RefreshUI();
    }

    private void SpawnNewEnemy()
    {
        currentEnemy = allEnemies[Random.Range(0, allEnemies.Length)];
        currentEnemy.ResetHealth();
        Debug.Log("New enemy spawned: " + currentEnemy.CharName);
    }

    private void GameOver()
    {
        Debug.Log("Game Over");
        attackButton.interactable = false;
        gameOverText.gameObject.SetActive(true);
    }

    public void RefreshUI()
    {
        playerName.text = player.CharName;
        playerHP.text = "HP: " + player.Health.ToString("F1");
        
        enemyName.text = currentEnemy.CharName;
        enemyHP.text = "HP: " + currentEnemy.Health.ToString("F1");
        //enemyPreview.sprite = currentEnemy.enemyImage;
    }
    
    

    // Update is called once per frame
    void Update()
    {
        
    }
}
