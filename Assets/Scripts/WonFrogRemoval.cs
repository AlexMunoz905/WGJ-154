using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WonFrogRemoval : MonoBehaviour
{
    private bool enemyBool = EnemyEncounter.wonLoseBool;
    public GameObject frog;
    public GameObject frog2;

    private void Update()
    {
        if (enemyBool == true && EnemyEncounter.isFrog1 == true)
        {
            frog.SetActive(false);
            Debug.Log("Frog Turned Off");
        }
        else if (enemyBool == false && EnemyEncounter.isFrog1 == false)
        {
            frog.SetActive(true);
            Debug.Log("Frog Stayed On");
        } else if (enemyBool == true && EnemyEncounter.isFrog2 == true)
        {
            frog2.SetActive(false);
            frog.SetActive(false);
            Debug.Log("Frog Turned Off");
        } else if (enemyBool == false && EnemyEncounter.isFrog2 == false)
        {
            frog2.SetActive(true);
            Debug.Log("Frog Stayed On");
        }
    }
}
