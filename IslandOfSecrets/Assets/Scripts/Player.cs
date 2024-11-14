using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    Rigidbody2D rb;
    //movement
    public float moveSpeed;
    SpriteRenderer spriteRenderer;
   
    float xInput;
    float yInput;
    private Vector2 moveDirection;

    private GameManager gameManager;
    LevelManager levelManager;
    private Animator animator;
    private SceneChanger sceneChanger;
    
    private SecretsManager secretsManager;

    private Vector3 respawnPosition;
    public Vector3 startPosition;

    //secrets
    string foundSecret;

    //player position
    public PlayerPosition playerStartPosition;


    //torch
    public GameObject torchLight;


    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        spriteRenderer = GetComponent<SpriteRenderer>();
        gameManager = FindObjectOfType<GameManager>();
        levelManager = FindObjectOfType<LevelManager>();
        animator = GetComponent<Animator>();
        sceneChanger = FindObjectOfType<SceneChanger>();
        secretsManager = FindObjectOfType<SecretsManager>();
        respawnPosition = transform.position;
        transform.position = playerStartPosition.playerInitialValue;
    }

    // Update is called once per frame
    void Update()
    {
       
    }
     
    private void FixedUpdate(){
        //player movement   
        xInput = Input.GetAxis("Horizontal");
        yInput = Input.GetAxis("Vertical");
        transform.Translate(xInput * moveSpeed * Time.deltaTime, yInput * moveSpeed * Time.deltaTime, 0f);     
        MovePlayer();              
    }
   
    private void MovePlayer(){
        //idle animation
        animator.SetBool("Walk", false);
              
        if(xInput != 0 || yInput != 0){
            //walking animation
            animator.SetBool("Walk", true);
            animator.SetFloat("MoveX", xInput);
            animator.SetFloat("MoveY", yInput);
        } 
    }
    

    private void OnTriggerEnter2D(Collider2D other){
        //if the player is hitting a secret
        if(other.gameObject.tag == "Secret"){
            //found a secret
            //find out which one is the secret 
            //and send the foundsecret to the secretsmanager
            foundSecret = other.gameObject.name;
            secretsManager.UpdateFoundSecrets(foundSecret);
            levelManager.SaveData();
               
        }
        if(other.gameObject.tag == "Torch"){
            torchLight.SetActive(true);
        }
        if(other.gameObject.tag == "TorchOff"){
            torchLight.SetActive(false);
        }
       
    }
}
