using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class SecretsManager : MonoBehaviour
{
    //secrets
    public GameObject SecretOne;
    public GameObject SecretTwo;
    public GameObject SecretThree;
    public GameObject SecretFour;
    public GameObject SecretFive;
    public GameObject SecretSix;

    public bool foundSecretOne;
    public bool foundSecretTwo;
    public bool foundSecretThree;
    public bool foundSecretFour;
    public bool foundSecretFive;
    public bool foundSecretSix;

    string foundSecret;

    public bool foundAllSecrets;

    //secretbox
    public GameObject SecretsBox;
    public Image SecretsImage;
    public TextMeshProUGUI SecretsText;

    public bool secretsBoxIsOpened;

    public FoundSecrets secretsValue;

    //NPCs
    NPCManager npcManager;
    NightDay nightDay;

   
 
    // Start is called before the first frame update
    void Start()
    {
      
        npcManager = FindObjectOfType<NPCManager>();
        nightDay = FindObjectOfType<NightDay>();
      
        CheckForFoundSecrets();
        CheckForAllSecrets();             
    }

    // Update is called once per frame
    void Update()
    {
       if(foundSecretOne){
          SecretOneFound();
       }
       if(foundSecretTwo){
          SecretTwoFound();
       }
       if(foundSecretThree){
          SecretThreeFound();
       }
       if(foundSecretFour){
          SecretFourFound();
       }
       if(foundSecretFive){
          SecretFiveFound();
       }
       if(foundSecretSix){
          SecretSixFound();
       }
        CheckForAllSecrets();

        if(foundAllSecrets){
            if(npcManager.Wizard != null){
                npcManager.Wizard.SetActive(false);
                npcManager.WizardSecretsFound.SetActive(true);   
            }
                   
        }
      
    }
    public void CheckForFoundSecrets(){
        foundSecretOne = secretsValue.secretOneValue;
        foundSecretTwo = secretsValue.secretTwoValue;
        foundSecretThree = secretsValue.secretThreeValue;
        foundSecretFour = secretsValue.secretFourValue;
        foundSecretFive = secretsValue.secretFiveValue;
        foundSecretSix = secretsValue.secretSixValue;

    }
    public void CheckForAllSecrets(){
        if(foundSecretOne && foundSecretTwo && foundSecretThree && foundSecretFour && foundSecretFive && foundSecretSix){
            foundAllSecrets = true;
            
        }
    }
   
    public void UpdateFoundSecrets(string foundSecret){

        //if a secret is discovered, show it on the secretsscreen
        switch(foundSecret){
            case "Costume": foundSecretOne = true; break;
            case "DungeonDoor": foundSecretTwo = true; break;
            case "SecretTunnel": foundSecretThree = true; break;
            case "BeachSecret": foundSecretFour = true; break;
            case "Shells": foundSecretFive = true; break;
            case "Clock": foundSecretSix = true; break;
          
        }
    }
    public void ActivateSecretBox(){
        SecretsBox.SetActive(true);
        secretsBoxIsOpened = true;
    }
    public void DeactivateSecretBox(){
        SecretsBox.SetActive(false);
        secretsBoxIsOpened = false;
    }

    public void SecretOneFound(){
       // foundSecretOne = true;
        SecretOne.SetActive(true);
        //if secret one is found, show lizard without costume and change text
        if(npcManager.LizardNoCostume != null){
            npcManager.LizardNoCostume.SetActive(true);
            if(nightDay.nightTime){
                npcManager.Lizard.SetActive(false);
            }
           
        }        
    }
    public void SecretTwoFound(){
       //show secret two in secretsmenu
        SecretTwo.SetActive(true);
     }
    public void SecretThreeFound(){
       //show secret three in secretsmenu
        SecretThree.SetActive(true);
     }
    public void SecretFourFound(){
     
        SecretFour.SetActive(true);
        if(npcManager.TigerAtBeach != null){
            npcManager.TigerAtBeach.SetActive(true);
            npcManager.Tiger.SetActive(false);
        }
     }
    public void SecretFiveFound(){
       
        SecretFive.SetActive(true);
        if(npcManager.Diamond != null){
            npcManager.Diamond.SetActive(true);
        }
     }
      public void SecretSixFound(){
      
        SecretSix.SetActive(true);
     }

}
