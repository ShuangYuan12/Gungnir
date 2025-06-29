using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gate2 : MonoBehaviour
{
    public GameObject conversation;
    public bool istrigger = false;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter(Collider col){
        if(col.gameObject.tag == "Player" && istrigger == false){
            Debug.Log("col");
            conversation.GetComponent<ConversationCt>().gate2();
            istrigger = true;
        }
    }
}
