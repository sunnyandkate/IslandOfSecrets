using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    NPC npc;

    //screens
    [Header("Screens")]
    public GameObject StartScreen;   
    public GameObject MainMenu;
    public GameObject MenuButton;
    public GameObject SecretsMenu;
    public GameObject SecretsButton;
    public GameObject HelpMenu;
    public GameObject HelpButton;
   
    
    //dialog
    [Header("Dialog")]
    public GameObject DialogBox;

    public Image dialogImage;
    public TextMeshProUGUI dialogText;  
    public bool dialogBoxIsOpenend = false;

    //helpscreen
    [Header("Hints")]
    public GameObject hint01Txt;
    public GameObject hint02Txt;
    public GameObject hint03Txt;

    // Start is called before the first frame update
    void Start()
    {
        npc = FindObjectOfType<NPC>();      
        MenuButton = GameObject.Find("Canvas/SelectBtnBox/MenuBtn");    
        SecretsButton = GameObject.Find("Canvas/SelectBtnBox/SecretsBtn");  
        HelpButton = GameObject.Find("Canvas/SelectBtnBox/HelpBtn");  
     
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void OpenMainMenu(){
        MainMenu.SetActive(true);
        MenuButton.SetActive(false);
        SecretsButton.SetActive(false);
        HelpButton.SetActive(false);
        
    }
    public void CloseMainMenu(){
        MainMenu.SetActive(false);
        MenuButton.SetActive(true);
        SecretsButton.SetActive(true);
        HelpButton.SetActive(true);
    }
    public void OpenSecretMenu(){
        SecretsMenu.SetActive(true);
        MenuButton.SetActive(false);
        SecretsButton.SetActive(false);
        HelpButton.SetActive(false);
    }
    public void CloseSecretMenu(){
        SecretsMenu.SetActive(false);
        MenuButton.SetActive(true);
        SecretsButton.SetActive(true);
        HelpButton.SetActive(true);
    }
    public void OpenHelpMenu(){
        HelpMenu.SetActive(true);
        MenuButton.SetActive(false);
        SecretsButton.SetActive(false);
        HelpButton.SetActive(false);
    }
    public void CloseHelpMenu(){
        HelpMenu.SetActive(false);
        MenuButton.SetActive(true);
        SecretsButton.SetActive(true);
        HelpButton.SetActive(true);
    }
    public void ExitGame(){
        SceneManager.LoadScene("StartScene");
    }
       
    public void ActivateDialogBox(){
        DialogBox.SetActive(true);
        dialogBoxIsOpenend = true;
       
    }
    public void DeactivateDialogBox(){
        DialogBox.SetActive(false);
        dialogBoxIsOpenend = false;
    }
   
    public void ShowHintOne(){
        hint01Txt.SetActive(true);
    }
    public void ShowHintTwo(){
        hint02Txt.SetActive(true);
    }
    public void ShowHintThree(){
        hint03Txt.SetActive(true);
    }
}
