using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class Ending : MonoBehaviour
{
    // Start is called before the first frame update
    public string areaToLoad1;
    public string areaToLoad2;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }


    public void pressFight()
    {
         SceneManager.LoadScene(areaToLoad1);
    }

     public void run()
    {
         SceneManager.LoadScene(areaToLoad2);
    }
}
