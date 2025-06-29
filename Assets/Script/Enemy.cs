using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public int direction;
    public float speed = 2f;
    private bool istrigger = false;
    public Rigidbody rig;
    
    // Start is called before the first frame update
    void Start()
    {
        if(Random.Range(0f, 1f) > 0.5f){
            direction = 1;
        }
        else{
            direction = -1;
        }
    }

    // Update is called once per frame
    void Update()
    {
        if(transform.position.x >= -607 && direction == 1){
            direction = -1;
        }
        else if(transform.position.x <= -618 && direction == -1){
            direction = 1;
        }
        rig.MovePosition(transform.position + transform.right * direction * speed * Time.deltaTime);
    }

    void OnTriggerEnter(Collider col){

        if(col.gameObject.tag == "Player" && istrigger == false){
            gameObject.transform.parent.gameObject.GetComponent<EnemyCt>().killEnemy();
            istrigger = true;
            Destroy(gameObject);
        }
    }
}
