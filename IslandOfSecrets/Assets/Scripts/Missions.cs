using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Missions : MonoBehaviour
{
   

    NPCManager npcManager;
    public bool foundCat;

    public FoundSecrets secretsValue;
    
    // Start is called before the first frame update
    void Start()
    {
        npcManager = FindObjectOfType<NPCManager>();

        foundCat = secretsValue.foundCatValue;
    }

    // Update is called once per frame
    void Update()
    {
         if(foundCat){
            //if the cat is found, bunny appears outside of the house
            //change position of bunny
            if(npcManager.BunnyOutside != null){
                npcManager.BunnyOutside.SetActive(true);                               
            }           
        } 
    }
    public void BunnyWalking(){
        if(gameObject.name == "Bunny"){
            //bunny is walking to cat
            gameObject.GetComponent<Animator>().enabled = true;                
        }
    }
    public void OnTriggerEnter2D(Collider2D other){
        if(other.gameObject.tag == "Player"){
            if(gameObject.name == "RunningCat"){
                //found cat
                foundCat = true;
                gameObject.GetComponent<Animator>().enabled = false;
                Invoke("BunnyWalking", 5f);
            }
        }
    }
  
     
}
