using System.Collections;
using System.Collections.Generic;
using DialogueEditor;
using UnityEngine;

public class ConversationCt : MonoBehaviour
{
    public NPCConversation c_start;
    public NPCConversation c_tomb;

    public NPCConversation c_tomb2;
    public NPCConversation c_gate1;
    public NPCConversation c_gate2;

    public NPCConversation c_gate3;
    public NPCConversation c_dusk1;
    public NPCConversation c_dusk2;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    public void sortir()
    {
        ConversationManager.Instance.StartConversation(c_start);
    }

    public void tomb() {
        ConversationManager.Instance.StartConversation(c_tomb);
    }

    public void tomb2() {
        ConversationManager.Instance.StartConversation(c_tomb2);
    }

    public void gate1(){
        ConversationManager.Instance.StartConversation(c_gate1);
    }

    public void gate2(){
        ConversationManager.Instance.StartConversation(c_gate2);
    }

    public void gate3(){
        ConversationManager.Instance.StartConversation(c_gate3);
    }

    public void dusk1() {
        ConversationManager.Instance.StartConversation(c_dusk1);
    }

    public void dusk2() {
        ConversationManager.Instance.StartConversation(c_dusk2);
    }
}
