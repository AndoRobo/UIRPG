using UnityEngine;

public class GameManager : MonoBehaviour
{
    public Character selectedChar;
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
       Debug.Log("selected name" + selectedChar.charName); 
       selectedChar.Attack();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
