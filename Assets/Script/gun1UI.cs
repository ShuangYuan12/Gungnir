using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gun1UI : MonoBehaviour
{
    public GameObject dusk1;
    // Start is called before the first frame update
    void Start()
    {
        Invoke("hide", 1);
        Invoke("duskAppear", 1);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void hide(){
        gameObject.SetActive(false);
    }

    void duskAppear() {
        dusk1.SetActive(true);
    }
}
