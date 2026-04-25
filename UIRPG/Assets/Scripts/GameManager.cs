
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
    
    
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
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
        currentEnemy.Attack(player);
        RefreshUI();
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
