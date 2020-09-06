using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EnemyShip : MonoBehaviour
{
    public float bounds;
    public GameObject gameover;
    public GameObject audioGameOver;
    public ParticleSystem explosion;
    private ParticleSystem explode;
    //public AudioSource audioGameOver;
    // Update is called once per frame
    void Start() {
        explosion.Stop();
        gameover.SetActive(false);
        //audioGameOver.mute = true;
    }

    void Update()
    {
        if (this.transform.position.x > bounds || this.transform.position.x < -bounds || this.transform.position.y > bounds || this.transform.position.x < -bounds)
        {

            Destroy(gameObject);
            
        }
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {

        if (collision.tag == "Bullet")
        {

            Game.AddToScore(1);

            Destroy(gameObject);
            
        }
        if (collision.tag == "Player")
        {
            explosion.Play();
            audioGameOver.SetActive(true);
            //audioGameOver.mute = false;
            StartCoroutine(WaitForMenu());
            //Instantiate(gameover);
          //explode = Instantiate(explosion);

          //explode.Play();

        }
    }
    public IEnumerator WaitForMenu()
    {
        
        yield return new WaitForSeconds(1.5f); // waits 3 seconds
        if (gameover.activeSelf == false)
        {
            gameover.SetActive(true);
            Instantiate(gameover);
        }

    }
}
   