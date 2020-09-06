using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    float timer = 0.0f;
    float randtime;
    public GameObject spawnPoint;
    public GameObject enemy;
 
    // Start is called before the first frame update
    void Start(){
        randtime = Random.Range(0.5f, 2f);

    }

    // Update is called once per frame
    void Update()
    {
        if(timer > randtime)
        {
            GameObject ship = Spawn();
            Vector2 dir = (Vector2)(Quaternion.Euler(0, 0, Random.Range(0f, 360f)) * Vector2.right);
            ship.GetComponent<Rigidbody2D>().velocity = 0.8f * dir * Random.Range(200f, 400f) * Time.deltaTime;
            randtime = Random.Range(0.1f, 0.2f);
            timer = 0.0f;
        }
        timer += Time.deltaTime;

     
    }
    GameObject Spawn()
    {

        return Instantiate(enemy, spawnPoint.transform.position, Quaternion.Euler(0f, 0f, 0f));

    }
}