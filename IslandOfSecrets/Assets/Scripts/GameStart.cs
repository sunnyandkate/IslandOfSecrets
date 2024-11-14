using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class GameStart : MonoBehaviour
{
    Player player;
    GameManager gameManager;
    LevelManager levelManager;

    public string newGame;
   
    public GameObject FadeInCanvas;
    public Vector2 playerPosition;

    public FoundSecrets foundSecretsValue;
    // Start is called before the first frame update
    void Start()
    {
        player = FindObjectOfType<Player>();
        gameManager = FindObjectOfType<GameManager>();
        levelManager = FindObjectOfType<LevelManager>();       
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void PlayGame(){
        //reset all the saved secrets
        ResetSecrets();
        FadeInCanvas.SetActive(true);
       
        Invoke("SelectGame", 1.5f);
        Invoke("FadeOut", 1.8f);      
    }
   
    public void SelectGame(){    
        SceneManager.LoadScene(newGame);     
   }
    public void FadeOut(){
      FadeInCanvas.SetActive(false);      
   }
    public void IntroSceneOne(){
        SceneManager.LoadScene("IntroSceneOne");  
    }
    public void IntroSceneTwo(){
        SceneManager.LoadScene("IntroSceneTwo");  
    }
  
    public void ExitGame(){
        FadeInCanvas.SetActive(true);
       
        Invoke("EndGame", 1.5f);
        Invoke("FadeOut", 1.8f);  
    }
    public void EndGame(){
         SceneManager.LoadScene("Credits");    
    }
    public void PlayAgain(){
        SceneManager.LoadScene("StartScene");
    }
    public void ResetSecrets(){

        foundSecretsValue.foundClockValue = false;
        foundSecretsValue.nightTimeValue = false;
        foundSecretsValue.dayTimeValue = false;
        foundSecretsValue.treasureChestValue = false;
        foundSecretsValue.foundCatValue = false;
        foundSecretsValue.secretOneValue = false;
        foundSecretsValue.secretTwoValue = false;
        foundSecretsValue.secretThreeValue = false;
        foundSecretsValue.secretFourValue = false;
        foundSecretsValue.secretFiveValue = false;
        foundSecretsValue.secretSixValue = false;
    }
}
