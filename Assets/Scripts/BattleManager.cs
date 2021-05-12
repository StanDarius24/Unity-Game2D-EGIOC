using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BattleManager : MonoBehaviour
{
    // Start is called before the first frame update
    public static BattleManager instance;
    private bool battleActive = false;
    public GameObject battleScene;
    public BattleCar[] player;
    public BattleCar[] enemy;

        public bool battle= false;
    void Start()
    {
        instance = this;
        DontDestroyOnLoad(gameObject);    
        battleScene.SetActive(false);
        
    }

   public void settrue()
   {
       battle=true;
   }


    // Update is called once per frame
    void Update()
    {
        if(battle)
        if(!battleActive)
            BattleStart(new string[] {"Dragon"});
            else
            {battleScene.SetActive(false);
            battleActive=false;
            }
        
    } 

    public void BattleStart(string[] enemiesToSpawn)
    {
        if(!battleActive)
        {
            battleActive = true;

            battleScene.SetActive(true);
        }
    }
}
