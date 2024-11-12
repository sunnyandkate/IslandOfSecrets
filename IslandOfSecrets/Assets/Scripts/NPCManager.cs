using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NPCManager : MonoBehaviour
{

    Missions missions;

    public GameObject Lizard;
    public GameObject LizardNoCostume;
    public GameObject Bunny;
    public GameObject BunnyOutside;
    public GameObject Tiger;
    public GameObject TigerAtBeach;
    public GameObject Mouse;
    public GameObject Koala;
    public GameObject Racoon;
    public GameObject Wizard;
    public GameObject WizardSecretsFound;
    public GameObject Diamond;

    
    // Start is called before the first frame update
    void Start()
    {
        missions = FindObjectOfType<Missions>();

        Lizard = GameObject.Find("NPCs/NPC_Lizard");
        LizardNoCostume = GameObject.Find("NPCs/LizardNoCostume");
        Bunny = GameObject.Find("NPCs/Bunny");
        BunnyOutside = GameObject.Find("NPCs/BunnyOutside");
        Tiger = GameObject.Find("NPCs/NPC_Tiger");
        TigerAtBeach = GameObject.Find("NPCs/TigerAtBeach");
        Mouse = GameObject.Find("NPCs/NPC_Mouse");
        Koala = GameObject.Find("NPCs/Koala");
        Racoon = GameObject.Find("NPCs/Racoon");
        Wizard = GameObject.Find("NPCs/Wizard");
        WizardSecretsFound = GameObject.Find("NPCs/WizardSecretsFound");
        Diamond = GameObject.Find("SandArea/HiddenDiamond/Diamond");
        
       if(LizardNoCostume != null){
            LizardNoCostume.SetActive(false);
       }
       if(BunnyOutside != null){
            BunnyOutside.SetActive(false);
       }
       if(TigerAtBeach != null){
            TigerAtBeach.SetActive(false);
       }
       if(WizardSecretsFound != null){
            WizardSecretsFound.SetActive(false);
       }
       if(Diamond != null){
            Diamond.SetActive(false);
       }
        
    }

    // Update is called once per frame
    void Update()
    {      
        if(Bunny != null){
            if(missions.foundCat){
                //if you found the cat, the bunny is not inside the house
                Bunny.SetActive(false);                
            }
        }
    }
}
