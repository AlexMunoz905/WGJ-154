using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EndOfLevel : MonoBehaviour
{
    public void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Flag")
        {
            if (SceneManager.GetActiveScene().buildIndex + 1 == 7)
            {
                SceneManager.LoadScene(0);
            } else
            {
                SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
                ScoreScript.totalScoreINT = ScoreScript.totalScoreINT + 10;
            }
        }
    }
}
