using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dragon : MonoBehaviour
{
    // Start is called before the first frame update
    bool canActivate;
     public static Dragon instance;
   
     public GameObject battleScene;
    void Start()
    {
        instance = this;
        DontDestroyOnLoad(gameObject);    
        battleScene.SetActive(false);

    }

    // Update is called once per frame
    void Update()
    {
        if(canActivate)
        battleScene.SetActive(true);
    }

    private void OnTriggerEnter2D(Collider2D other) 
    {
        if(other.tag == "Player")
        {
            canActivate = true;
            Debug.Log("True");
            PlayerControler.instance.stop();
            battleScene.SetActive(true);
            
        }
    }

    private void OnTriggerExit2D(Collider2D other)
    {
        if(other.tag == "Player")
        {
            canActivate = false;
            Debug.Log("False");
            battleScene.SetActive(false);
        }
    }
}
