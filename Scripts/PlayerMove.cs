using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove: MonoBehaviour
{
    private float rotationSpeed;
    public GameObject bullet;
    public GameObject cannon;
    public AudioSource source;
    // Start is called before the first frame update
    void Start()
    {
        source.mute = true;
    }

    // Update is called once per frame
    void Update()
    {

        if (Input.GetKey(KeyCode.Space))
        {
            this.rotationSpeed = 10;

        }
        else
        {
            this.rotationSpeed = 40;
        }
        transform.RotateAround(Vector3.zero, Vector3.forward, Time.deltaTime * this.rotationSpeed);
        
        if (Input.GetMouseButtonDown(0))
        {

            Instantiate(bullet, cannon.transform).GetComponent<Rigidbody2D>().AddForce(cannon.transform.position * -10, ForceMode2D.Impulse);
            // play the sound
            source.mute = false;

            source.Play();

        }
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Enemy")
        {
            source.mute = true;

            Destroy(gameObject);
        }

    }
}
