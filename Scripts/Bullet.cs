using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    public float sceneradius = 15;
    public ParticleSystem explosion;
    //public ParticleSystem enemyBoom;
    private ParticleSystem explode;
    // Start is called before the first frame update
    void Start()
    {
        //enemyBoom.Stop();
    }

    // Update is called once per frame
    void Update()
    {
       if(transform.position.x < -sceneradius)
       {
            Destroy(gameObject);
       }
        if (transform.position.x > sceneradius)
        {
            Destroy(gameObject);
        }
        if (transform.position.y < -sceneradius)
        {
            Destroy(gameObject);
        }
        if (transform.position.x > sceneradius)
        {
            Destroy(gameObject);
        }
      
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {

        if (collision.tag == "Mothership")
        {
            explode = Instantiate(explosion);

            explode.Play();
            Destroy(gameObject);
        }
       
    }
}
