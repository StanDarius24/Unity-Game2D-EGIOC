using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EssentialLoader : MonoBehaviour
{
	public GameObject UIScreen;
	public GameObject Player;
	public GameObject game;
    // Start is called before the first frame update
    void Start()
    {
    	if(UIFade.instance == null)
    	{
    		UIFade.instance = Instantiate(UIScreen).GetComponent<UIFade>();
    	}

    	if(PlayerControler.instance == null)
    	{

    		PlayerControler clone = Instantiate(Player).GetComponent<PlayerControler>();
    		PlayerControler.instance = clone;
    	}

		if(GameManager.instance == null)
		{
			Instantiate(game);
		}
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
