using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayCoinSound : MonoBehaviour {

    public AudioSource coinsound;

	// Use this for initialization
	void Start () 
{
        coinsound = GetComponent<AudioSource>();
	}
	

    public void OnCollisionEnter2D(Collision2D collision)
    {

     if(collision.gameObject.tag == "PickUp")
        {
            coinsound.Play();
        }
    }
}
