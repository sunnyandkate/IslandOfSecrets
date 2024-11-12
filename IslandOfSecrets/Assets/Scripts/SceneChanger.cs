using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneChanger : MonoBehaviour
{
    public string sceneToLoad;
    Player player;
   
    GameManager gameManager;
    LevelManager levelManager;

    public GameObject FadeInCanvas;

    public Vector2 playerPosition;
    public PlayerPosition playerStartPosition;
    public FoundSecrets foundSecrets;
    
    void Awake()
    {
        player = FindObjectOfType<Player>();
        gameManager = FindObjectOfType<GameManager>();
        levelManager = FindObjectOfType<LevelManager>();  
    }

    public void LoadLevel(){       
        Invoke("SelectLevel", 1.5f);
        Invoke("FadeOut", 1.8f);      
    }
   
    public void SelectLevel(){    
        SceneManager.LoadScene(sceneToLoad);     
   }
    public void FadeOut(){
      FadeInCanvas.SetActive(false);      
   }
   void OnTriggerEnter2D(Collider2D other){

        if(other.tag == "Player"){
            
          //when we change the scene-> save collected items and set player on area entrance position
          playerStartPosition.playerInitialValue = playerPosition;
          SaveSecrets();
          levelManager.SaveData();
               
          FadeInCanvas.SetActive(true);
        
          LoadLevel();  
        
        }
     }
     public void SaveSecrets(){
      foundSecrets.secretOneValue = levelManager.intToBool(PlayerPrefs.GetInt("foundSecretOne", 0));
     }
}
