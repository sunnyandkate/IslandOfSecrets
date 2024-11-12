using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Secrets : MonoBehaviour
{
    Player player;
    GameManager gameManager;
    SecretsManager secretsManager;
    LevelManager levelManager;

    public Sprite secretsPic;
    public string secretsText;
    bool secretFound;

    // Start is called before the first frame update
    void Start()
    {
        gameManager = FindObjectOfType<GameManager>();
        player = FindObjectOfType<Player>();
        secretsManager = FindObjectOfType<SecretsManager>();
        levelManager = FindObjectOfType<LevelManager>();
    }

    // Update is called once per frame
    void Update()
    {
        if(secretFound){
            secretsManager.ActivateSecretBox();
            if(secretsManager.secretsBoxIsOpened){
                SecretsText();
            }
        }
    }
    public void ChangeSecretsImage(){
        secretsManager.SecretsImage.sprite = secretsPic;
    }
    public void SecretsText(){
        secretsManager.SecretsText.text = secretsText;
    }
     public void OnTriggerEnter2D(Collider2D other){
        //if player is talking to an npc
        if(other.gameObject.tag == "Player"){
            secretFound = true;
            ChangeSecretsImage();
            levelManager.SaveData();          
        }       
    }
     public void OnTriggerExit2D(Collider2D other){
        
        //if player is leaving npc area
        if(other.gameObject.tag == "Player"){
            secretFound = false;
            secretsManager.DeactivateSecretBox();
                      
        }      
    }   
}
