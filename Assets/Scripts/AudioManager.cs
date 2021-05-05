using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioManager : MonoBehaviour
{
    public AudioSource[] sfx;
    private int i=0;
    private bool audio=false;
    public static AudioManager instance;
    // Start is called before the first frame update
    void Start()
    {
        instance = this;

        DontDestroyOnLoad(this.gameObject);
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.M))
        {   
            if(!audio)
            {
                audio=true;
                PlaySFX(i);
                i++;
                i=i%2;
            }
            else
            {
                
                audio=false;
                StopMusic();
            }
        }
        
    }

    public void PlaySFX(int soundToPlay)
    {
        if(soundToPlay < sfx.Length)
        {
            if(audio)
            sfx[soundToPlay].Play();
            
        }
    }


    public void StopMusic()
    {
        for(int i=0;i<sfx.Length;i++)
        sfx[i].Stop();
        
    }
}
