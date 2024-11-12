using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StopMusic : MonoBehaviour
{
    MusicLoading musicLoading;

   
    // Start is called before the first frame update
    void Start()
    {
        musicLoading = FindObjectOfType<MusicLoading>();
        musicLoading.StopMusic();
    }
}
