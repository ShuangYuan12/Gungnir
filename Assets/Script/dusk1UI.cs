using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class dusk1UI : MonoBehaviour
{
    public GameObject conversation;
    
    // Start is called before the first frame update
    void Start()
    {
        Invoke("cAppear", 0.2f);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void cAppear() {
        conversation.GetComponent<ConversationCt>().dusk1();
    }

    public void disappear() {
        gameObject.SetActive(false);
    }
}
