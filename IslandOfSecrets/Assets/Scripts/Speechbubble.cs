using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Speechbubble : MonoBehaviour
{
    //speechbubble
    public TextMeshProUGUI speechBubbleTxt;
    public GameObject introOneBtn;
    public GameObject introTwoBtn;
    // Start is called before the first frame update
    void Start()
    {
        introTwoBtn.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
     public void ChangeSpeechBubble(){
        speechBubbleTxt.text = "Cat Detective: Wow that sounds like a great adventure. Let's go!";
        introOneBtn.SetActive(false);
        introTwoBtn.SetActive(true);
    }
}
