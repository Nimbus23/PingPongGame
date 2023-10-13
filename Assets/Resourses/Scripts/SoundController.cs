using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundController : MonoBehaviour
{
    public AudioSource wallSound;
    public AudioSource racketSound1;
    public AudioSource racketSound2;

    public float rndNumber;
    
    void Update()
    {
        rndNumber = Random.Range(0, 2);
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.name == "RacketPlayer1" || collision.gameObject.name == "RacketPlayer2")
        {
            switch (rndNumber) 
            { case 0: this.racketSound1.Play(); break;
              case 1: this.racketSound2.Play(); break;
              default: break;
            }
        }
        else
        {
            this.wallSound.Play();
        }
    }
}
