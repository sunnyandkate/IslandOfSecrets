using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelManager : MonoBehaviour
{
    Player player;
    SecretsManager secretsManager;
    TreasureChest treasureChest;
    Missions missions;
    NightDay nightDay;

    // Start is called before the first frame update
    void Start()
    {
        player = FindObjectOfType<Player>();
        secretsManager = FindObjectOfType<SecretsManager>();
        treasureChest = FindObjectOfType<TreasureChest>();
        missions = FindObjectOfType<Missions>();
        nightDay = FindObjectOfType<NightDay>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public int boolToInt(bool value){
        if(value){
            return 1;
        }else{
            return 0;
        }
        
    }
    public bool intToBool(int value){
        if(value != 0){
            return true;
        }else{
            return false;
        }
        
    }
    public void LoadData(){
        secretsManager.foundSecretOne = intToBool(PlayerPrefs.GetInt("FoundSecretOne", 0));
        secretsManager.foundSecretTwo = intToBool(PlayerPrefs.GetInt("FoundSecretTwo", 0));
        secretsManager.foundSecretThree = intToBool(PlayerPrefs.GetInt("FoundSecretThree", 0));
        secretsManager.foundSecretFour = intToBool(PlayerPrefs.GetInt("FoundSecretFour", 0));
        secretsManager.foundSecretFive = intToBool(PlayerPrefs.GetInt("FoundSecretFive", 0));
        secretsManager.foundSecretSix = intToBool(PlayerPrefs.GetInt("FoundSecretSix", 0));

        missions.foundCat = intToBool(PlayerPrefs.GetInt("FoundCat", 0));
        nightDay.foundClock = intToBool(PlayerPrefs.GetInt("FoundClock", 0));
        nightDay.nightTime = intToBool(PlayerPrefs.GetInt("NightTime", 0));
        nightDay.dayTime = intToBool(PlayerPrefs.GetInt("DayTime", 0));
   
        Debug.Log("data loaded");
    }
    public void LoadPlayerPosition(){
        player.transform.position = new Vector3(PlayerPrefs.GetFloat("playerX"),PlayerPrefs.GetFloat("playerY"), PlayerPrefs.GetFloat("playerZ"));
       
    }
     public void SaveTreasureChest(){
        PlayerPrefs.SetInt("BoxIsOpened", boolToInt(treasureChest.boxIsOpened));
    }
     public void LoadTreasureChest(){
        treasureChest.boxIsOpened = intToBool(PlayerPrefs.GetInt("BoxIsOpened", 0));
    }
    
    public void SaveData(){
        PlayerPrefs.SetString("currentScene", SceneManager.GetActiveScene().name);     
       
        PlayerPrefs.SetInt("FoundSecretOne", boolToInt(secretsManager.foundSecretOne));
        PlayerPrefs.SetInt("FoundSecretTwo", boolToInt(secretsManager.foundSecretTwo));
        PlayerPrefs.SetInt("FoundSecretThree", boolToInt(secretsManager.foundSecretThree));
        PlayerPrefs.SetInt("FoundSecretFour", boolToInt(secretsManager.foundSecretFour));
        PlayerPrefs.SetInt("FoundSecretFive", boolToInt(secretsManager.foundSecretFive));
        PlayerPrefs.SetInt("FoundSecretSix", boolToInt(secretsManager.foundSecretSix));
        PlayerPrefs.SetInt("FoundCat", boolToInt(missions.foundCat));
        PlayerPrefs.SetInt("FoundClock", boolToInt(nightDay.foundClock));
        PlayerPrefs.SetInt("NightTime", boolToInt(nightDay.nightTime));
        PlayerPrefs.SetInt("DayTime", boolToInt(nightDay.dayTime));
      
        
        PlayerPrefs.SetFloat("playerX", player.transform.position.x);
        PlayerPrefs.SetFloat("playerY", player.transform.position.y);
        PlayerPrefs.SetFloat("playerZ", player.transform.position.z);

       Debug.Log("data saved");
    }
}
