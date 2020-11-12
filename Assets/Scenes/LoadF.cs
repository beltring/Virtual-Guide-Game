using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Video;

public class LoadF : MonoBehaviour
{
    public VideoPlayer vPlayer;
    public bool enter;
    bool isPlay;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (enter)
        {
            if(Input.GetKeyUp(KeyCode.F))
            {
                isPlay = !isPlay;
            }
        }
        if (isPlay)
            vPlayer.Play();
        else
            vPlayer.Pause();


    }
    

    private void OnTriggerEnter(Collider other)
    {
        enter = true;
    }
    private void OnTriggerExit(Collider other)
    {
        enter = false;
    }
}
