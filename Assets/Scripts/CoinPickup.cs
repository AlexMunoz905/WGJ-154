using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinPickup : MonoBehaviour
{
    public AudioSource coinSound;

    private void Start()
    {
        coinSound = GetComponent<AudioSource>();
        coinSound.volume = 0F;
    }

    public void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Coin")
        {
            coinSound.volume = 1F;
            coinSound.Play();
            coinSound.volume = 0F;
            collision.gameObject.SetActive(false);
            ScoreScript.totalScoreINT = ScoreScript.totalScoreINT + 1;
        }
    }
}
