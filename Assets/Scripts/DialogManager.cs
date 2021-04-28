using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class DialogManager : MonoBehaviour
{

    public Text dialogText;
    public Text nameText;
    public GameObject dialogBox;
    public GameObject nameBox;

    public string[] dialogLines;
    public int currentLine;

    private bool justStarted;
    public static DialogManager instance;
    // Start is called before the first frame update
    void Start()
    {
        if(instance == null)
        instance = this;

        dialogText.text = dialogLines[currentLine];
    }

    // Update is called once per frame
    void Update()
    {
        if(dialogBox.activeInHierarchy)
        {
            if(Input.GetButtonUp("Fire1"))
            {
                if(!justStarted){
                currentLine++;

                if(currentLine >= dialogLines.Length)
                {
                    dialogBox.SetActive(false);
                }else
                {
                dialogText.text = dialogLines[currentLine];
                }}
                else
                {
                    justStarted = false;
                }
            }
        }
    }

    public void ShowDialog( string[] lines)
    {
        dialogLines = lines;
        currentLine = 0;
        dialogText.text = dialogLines[currentLine];
        dialogBox.SetActive(true);

        justStarted = true;
    }
}
 