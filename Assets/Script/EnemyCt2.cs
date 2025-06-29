using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyCt2 : MonoBehaviour
{
    public GameObject enemyPrefab;
    public int enemyN = 5;
    public int enemyDestroyN = 0;
    public GameObject gun;

    // Start is called before the first frame update
    void Start()
    {
        for (int i = 0; i < 5; i++)
        {
            Vector3 pos = new Vector3(Random.Range(-580, -597), -19, Random.Range(-373, -384));
            GameObject addEnemy = Instantiate(enemyPrefab, pos, transform.rotation);
            addEnemy.transform.SetParent(transform);
        }

        InvokeRepeating("creatEnemy", 2, 2);
    }

    // Update is called once per frame
    void Update()
    {

    }

    void creatEnemy()
    {
        Debug.Log(enemyN);

        if (enemyN > 0)
        {
            Vector3 pos = new Vector3(Random.Range(-580, -597), -19, Random.Range(-373, -384));
            GameObject addEnemy = Instantiate(enemyPrefab, pos, transform.rotation);
            addEnemy.transform.SetParent(transform);
            enemyN--;
        }
        else
        {
            CancelInvoke("creatEnemy");
        }
    }

    public void killEnemy()
    {
        enemyDestroyN += 1;
        if (enemyDestroyN == 10)
        {
            gun.AddComponent<PickGun2>();
        }
    }
}
