using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Temple : MonoBehaviour
{

    SecretsManager secretsManager;
     //temple
    public GameObject templeOpened;
    public GameObject templeClosed;
    // Start is called before the first frame update
    void Start()
    {

        secretsManager = FindObjectOfType<SecretsManager>();

        templeOpened.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
         if(secretsManager.foundAllSecrets){
            TempleOpened();
       }
    }
     public void TempleOpened(){
        templeClosed.SetActive(false);
        templeOpened.SetActive(true);
    }
}
