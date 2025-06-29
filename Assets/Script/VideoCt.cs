using System.Collections;
using System.Collections.Generic;
using RenderHeads.Media.AVProVideo;
using UnityEditor.Experimental.GraphView;
using UnityEngine;

public class VideoCt : MonoBehaviour
{
    public GameObject videoPlay;
    public GameObject conversation;
    
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
                videoPlay.SetActive(false);
                conversation.gameObject.GetComponent<ConversationCt>().sortir();
                gameObject.SetActive(false);
                break;
        }
    }
}
