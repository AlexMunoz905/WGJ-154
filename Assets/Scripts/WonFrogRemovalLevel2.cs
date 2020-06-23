using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WonFrogRemovalLevel2 : MonoBehaviour
{
    private bool enemyBool = EnemyEncounterLevel2.wonLoseBool;

    public GameObject frog;
    public GameObject frog2;

    private void Update()
    {
        if (enemyBool == true)
        {
            frog.SetActive(false);
            Debug.Log("Frog Turned Off");
            Debug.Log(enemyBool);
        }
        else if (enemyBool == false)
        {
            frog.SetActive(true);
            Debug.Log("Frog Stayed On");
            Debug.Log(enemyBool);
        }
    }
}
