using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TreasureChest : MonoBehaviour
{
    SpriteRenderer spriteRenderer;
    public Sprite chestClosed;
    public Sprite chestOpened;
    

    public bool boxIsOpened;

    SecretsManager secretsManager;
    LevelManager levelManager;

    public GameObject Costume;

    public FoundSecrets foundSecretsValue;
    // Start is called before the first frame update
    void Start()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
        secretsManager = FindObjectOfType<SecretsManager>();
        levelManager = FindObjectOfType<LevelManager>();
    
       
        if(!secretsManager.foundSecretOne){
             spriteRenderer.sprite = chestClosed;
            Costume.SetActive(false);
        }

    }
    void Update(){

        //if secretone is found  -> treasure chest is opened and costume lying outside
         if(secretsManager.foundSecretOne){
            spriteRenderer.sprite = chestOpened;
            Costume.SetActive(true);
        }
    }
  

    public void OnCollisionEnter2D(Collision2D other){
        if(other.gameObject.tag == "Player"){
            //if the player hasn't found the costume yet, open the treasure box
            if(secretsManager.foundSecretOne == false){
                spriteRenderer.sprite = chestOpened;
               
            }
           
            Invoke("MoveCostume", 1f);
            
        }
    }
    public void MoveCostume(){
        Costume.SetActive(true);
        if(secretsManager.foundSecretOne){
            boxIsOpened = true;
             levelManager.SaveTreasureChest();
        } 
    }
}
