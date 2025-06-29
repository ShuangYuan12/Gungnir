using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TombInHole3 : MonoBehaviour
{
    public GameObject conversation;
    public GameObject odin;

    public GameObject mediaA;
    public GameObject mediaB;
    public GameObject player1;
    public GameObject player2;
    public bool iscollision = false;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnCollisionEnter(Collision col){
        if(col.gameObject.tag == "Player" && iscollision == false){
            Debug.Log("col");
            conversation.GetComponent<ConversationCt>().tomb2();
            iscollision = true;
        }
    }

    public void Odin(){
        odin.SetActive(true);
    }

    public void endA() {
        odin.SetActive(false);
        mediaA.SetActive(true);
        player1.SetActive(true);
    }

    public void endB() {
        odin.SetActive(false);
        mediaB.SetActive(true);
        player2.SetActive(true);
    }
}
