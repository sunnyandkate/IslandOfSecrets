using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NightDay : MonoBehaviour
{
    public GameObject lizard;

    NPCManager npcManager;

    public int timeofday;
    public bool dayTime;
    public bool nightTime;


    public GameObject ChangeTimeBox;
    public bool foundClock;

    public FoundSecrets secretsValue;
    // Start is called before the first frame update
    void Start()
    {
        timeofday = System.DateTime.Now.Hour;
        npcManager = FindObjectOfType<NPCManager>();

        foundClock = secretsValue.foundClockValue;
       
        dayTime = secretsValue.dayTimeValue;
        nightTime = secretsValue.nightTimeValue;
        
    }

    // Update is called once per frame
    void Update()
    {
        
         //if the clock is found, don't check the time, set it by yourself
        if(!foundClock){
         CheckTimeOfDay();
        }
        CheckNPCPositions();
    }
  
    public void CheckTimeOfDay(){
               
        if(timeofday > 0 && timeofday < 12){
            dayTime = true;
        }else {
            nightTime = true;
        }
              
    }
    public void ChangeToDayTime(){
        foundClock = true;
        dayTime = true;
        nightTime = false;        
    }
    public void ChangeToNightTime(){
        foundClock = true;
        nightTime = true;
        dayTime = false;
    }
    public void CheckNPCPositions(){

        if(npcManager.Lizard != null){
            if(dayTime){
                npcManager.Lizard.SetActive(true);
                npcManager.LizardNoCostume.SetActive(false);
            }else if(nightTime){
                npcManager.Lizard.SetActive(false);
                
            }
        }
        
    }
    public void OnTriggerEnter2D(Collider2D other){
        if(other.gameObject.tag == "Player"){
            if(gameObject.name == "Clock"){
                //you found the clock, now you can change the time
                ChangeTimeBox.SetActive(true);
            }
        }
    }
    public void OnTriggerExit2D(Collider2D other){
        if(other.gameObject.tag == "Player"){
            if(gameObject.name == "Clock"){
                
                ChangeTimeBox.SetActive(false);
            }
        }
    }
}
