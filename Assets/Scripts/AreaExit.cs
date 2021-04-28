using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class AreaExit : MonoBehaviour
{
    // Start is called before the first frame update

	public string areaToLoad;

    public float waitToLoad = 1f;

    public string areaTransitionName;

    public AreaEntrance area;

    private bool shouldLoadAfterFade;

    void Start()
    {
         area.transitionName = areaTransitionName;
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
    	if(other.tag == "Player")
    	{
    		//SceneManager.LoadScene(areaToLoad);

            shouldLoadAfterFade = true;

            UIFade.instance.FadeToBlack();

            PlayerControler.instance.areaTransitionName = areaTransitionName;
    	}
    }

    // Update is called once per frame
    void Update()
    {
        if(shouldLoadAfterFade)
        {
            waitToLoad -= Time.deltaTime;

            if(waitToLoad <= 0)
            {
                    shouldLoadAfterFade=false;
                    SceneManager.LoadScene(areaToLoad);
            }
        }
    }
}
