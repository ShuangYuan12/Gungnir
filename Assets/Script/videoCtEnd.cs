using System.Collections;
using System.Collections.Generic;
using RenderHeads.Media.AVProVideo;
using UnityEngine;

public class videoCtEnd : MonoBehaviour
{
    public GameObject videoPlay;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnVideoEvent(MediaPlayer mp, MediaPlayerEvent.EventType et, ErrorCode e)
    {
        switch (et)
        {
            case MediaPlayerEvent.EventType.ReadyToPlay:
                break;

            case MediaPlayerEvent.EventType.FirstFrameReady:
                break;
            
            case MediaPlayerEvent.EventType.FinishedPlaying:
                
                break;
        }
    }
}
