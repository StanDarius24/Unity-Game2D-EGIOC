using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControler : MonoBehaviour
{	

	public Rigidbody2D theRB;
	public float moveSpeed;

	public bool miscare = false;
	public Animator myAnimation;

    public static PlayerControler instance;

    public string areaTransitionName;

    // Start is called before the first frame update


    public void stop()
    {
    	miscare=true;
    }


    void Start()
    {
        if(instance == null)
            {
                instance = this;
            }
            else
             {
                if(instance != this)
    
                {
                    Destroy(gameObject);
                }
 
             }

        DontDestroyOnLoad(gameObject);
    }

    // Update is called once per frame
    void Update()
    {
    	if(!miscare){
        theRB.velocity = new Vector2(Input.GetAxisRaw("Horizontal") , Input.GetAxisRaw("Vertical")) * moveSpeed;
   
        myAnimation.SetFloat("MoveX",theRB.velocity.x);
        myAnimation.SetFloat("MoveY",theRB.velocity.y);
    }
    else
    {
        theRB.velocity = new Vector2(0,0);
    }
    }
}
