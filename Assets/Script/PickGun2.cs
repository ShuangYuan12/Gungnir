using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class PickGun2 : MonoBehaviour
{
    public bool istrigger = false;
    public GameObject gameManager;
    public GameObject canvas;

    // Start is called before the first frame update
    void Start()
    {
        gameManager = GameObject.Find("GameManager");
        canvas = GameObject.Find("Canvas");
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter(Collider col){
        if(col.gameObject.tag == "Player" && istrigger == false){
            gameManager.GetComponent<GameManager>().gun += 1;
            canvas.transform.GetChild(4).gameObject.SetActive(true);
            Destroy(gameObject);
        }
        istrigger = true;
    }
}
