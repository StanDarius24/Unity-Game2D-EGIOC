using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class GameMenu : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject theMenu;

    public Text nameText;
    public Text hpText,mpText,lvlText,expText;
    public Slider expSlider;
    public Image charImage;
    public GameObject charStatHolder;
    private CaracterStats[] playerStats;
    
    public CaracterStats xd;
    
    public GameObject[] windows;
    void Start()
    {
        
    }

	
    
    // Update is called once per frame
    void Update()
    {
    	
		
            
        

        if(Input.GetButtonDown("Fire2"))
        {
            if(theMenu.activeInHierarchy)
            {
                theMenu.SetActive(false);
            }
            else
            {
                UpdateMainStats();
                theMenu.SetActive(true);
            }
        }
    }
    public void UpdateMainStats()
    {
        //charStatHolder(true);
        nameText.text = xd.charName;
        hpText.text = "HP: " + xd.currentHP + "/" + xd.maxHP;
        mpText.text = "MP: " + xd.currentMP + "/" + xd.maxMP;
        lvlText.text = "Lvl: " + xd.playerLevel;
        expText.text = "" + xd.currentMP + "/" + xd.expToNextLevel[xd.playerLevel];
        expSlider.maxValue = xd.expToNextLevel[xd.playerLevel];
        expSlider.value = xd.currentEXP;
        charImage.sprite = xd.charIamge;

        
        playerStats = GameManager.instance.playerStats;

        for(int i=0;i<playerStats.Length;i++)
        {

        if(playerStats[i].gameObject.activeInHierarchy)
        {
            charStatHolder.SetActive(true);
            nameText.text = playerStats[i].charName;
           
            hpText.text = "HP: " + playerStats[i].currentHP + "/" + playerStats[i].maxHP;
        }
        else
        {
            charStatHolder.SetActive(false);
        }
        }
    }

    public void ToggleWindow(int windowNumber)
    {   UpdateMainStats();
        for(int i = 0; i < windows.Length;i++)
        {
            if(i == windowNumber)
            {
                windows[i].SetActive(!windows[i].activeInHierarchy);
            } else
            {
                windows[i].SetActive(false);
            }
        }
    }
    public void print()
    {
        print("Click");
    }

      public void CloseMenu()
    {
        for(int i = 0; i < windows.Length; i++)
        {
            windows[i].SetActive(false);
        }

        theMenu.SetActive(false);



        
    }
   
}
