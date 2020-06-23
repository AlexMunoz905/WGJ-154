using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;
using JetBrains.Annotations;

public class ResetLevel : MonoBehaviour
{
    public void Start()
    {
        int currentBuildIndex = SceneManager.GetActiveScene().buildIndex;
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Void")
        {
            int currentBuildIndex = SceneManager.GetActiveScene().buildIndex;
            SceneManager.LoadScene(currentBuildIndex);
            ScoreScript.totalScoreINT = 0;
        }
    }
}
