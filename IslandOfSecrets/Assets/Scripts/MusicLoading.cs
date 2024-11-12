using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MusicLoading : MonoBehaviour
{
    public static MusicLoading instance;
    
    private AudioSource audioSource;

    void Awake(){

        audioSource = GetComponent<AudioSource>();

        if(instance == null){
            instance = this;
        }else{
            if(instance != this){
                Destroy(gameObject);
            }
            
        }
        
        DontDestroyOnLoad(gameObject);
    }

    public void PlayMusic(){
        audioSource.Play();
    }
      public void StopMusic(){
        audioSource.Stop();
    }
  
}
