using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using UnityEngine.XR.WSA.Input;
using TMPro;

public class EnemyEncounter : MonoBehaviour
{
    private enum RPC { Rock, Paper, Scissors}
    private string PlayerResult = "";
    private string WinLoseText = "";
    public static bool wonLoseBool;
    public static bool isFrog1;
    public static bool isFrog2;
    public Button rockBttn;
    public Button paperBttn;
    public Button scissorsBttn;
    public Text txt;

    void losePoints()
    {
        if (ScoreScript.totalScoreINT - 5 <= 0)
        {
            ScoreScript.totalScoreINT = 0;
        } else if (ScoreScript.totalScoreINT - 5 > 0)
        {
            ScoreScript.totalScoreINT = ScoreScript.totalScoreINT - 5;
        }
    }

    IEnumerator sendBackWON()
    {
        yield return new WaitForSeconds(3);
        SceneManager.LoadScene("Level1");
        ScoreScript.totalScoreINT = ScoreScript.totalScoreINT + 5;
        wonLoseBool = true;
    }

    IEnumerator sendBackLOSS()
    {
        yield return new WaitForSeconds(3);
        SceneManager.LoadScene("Level1");
        losePoints();
        wonLoseBool = false;
    }

    public void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.name == "Frog1")
        {
            isFrog1 = true;
            isFrog2 = false;
            SceneManager.LoadScene(1);
        } else if (collision.gameObject.name == "Frog2")
        {
            isFrog1 = false;
            isFrog2 = true;
            SceneManager.LoadScene(1);
        }
    }
    public string rpcResult = "";

    public void rockPressed()
    {
        rockBttn.gameObject.SetActive(false);
        paperBttn.gameObject.SetActive(false);
        scissorsBttn.gameObject.SetActive(false);
        
        RPC rpc = (RPC)(Random.Range(0, 3));
        switch (rpc)
        {
            case RPC.Rock:
                rpcResult = "Rock";
                break;
            case RPC.Paper:
                rpcResult = "Paper";
                break;
            case RPC.Scissors:
                rpcResult = "Scissors";
                break;
        }

        PlayerResult = "Rock";

        if (rpcResult == "Rock")
        {
            WinLoseText = "You Win!";
            rockBttn.gameObject.SetActive(true);
            StartCoroutine(sendBackWON());
        } else if (rpcResult == "Paper")
        {
            WinLoseText = "You Lose...";
            rockBttn.gameObject.SetActive(true);
            StartCoroutine(sendBackLOSS());
        } else if (rpcResult == "Scissors")
        {
            WinLoseText = "You Win!";
            rockBttn.gameObject.SetActive(true);
            StartCoroutine(sendBackWON());
        }
        txt.text = WinLoseText;
    }

    public void paperPressed()
    {
        rockBttn.gameObject.SetActive(false);
        paperBttn.gameObject.SetActive(false);
        scissorsBttn.gameObject.SetActive(false);

        RPC rpc = (RPC)(Random.Range(0, 3));
        switch (rpc)
        {
            case RPC.Rock:
                rpcResult = "Rock";
                break;
            case RPC.Paper:
                rpcResult = "Paper";
                break;
            case RPC.Scissors:
                rpcResult = "Scissors";
                break;
        }

        PlayerResult = "Paper";

        if (rpcResult == "Rock")
        {
            WinLoseText = "You Win!";
            paperBttn.gameObject.SetActive(true);
            StartCoroutine(sendBackWON());
        } else if (rpcResult == "Paper")
        {
            WinLoseText = "You Win!";
            paperBttn.gameObject.SetActive(true);
            StartCoroutine(sendBackWON());
        } else if (rpcResult == "Scissors")
        {
            WinLoseText = "You Lose...";
            paperBttn.gameObject.SetActive(true);
            StartCoroutine(sendBackLOSS());
        }
        txt.text = WinLoseText;
    }
    public void scissorsPressed()
    {
        rockBttn.gameObject.SetActive(false);
        paperBttn.gameObject.SetActive(false);
        scissorsBttn.gameObject.SetActive(false);

        RPC rpc = (RPC)(Random.Range(0, 3));
        switch (rpc)
        {
            case RPC.Rock:
                rpcResult = "Rock";
                break;
            case RPC.Paper:
                rpcResult = "Paper";
                break;
            case RPC.Scissors:
                rpcResult = "Scissors";
                break;
        }

        PlayerResult = "Scissors";

        if (rpcResult == "Rock")
        {
            WinLoseText = "You Lose...";
            scissorsBttn.gameObject.SetActive(true);
            StartCoroutine(sendBackLOSS());
        } else if (rpcResult == "Paper")
        {
            WinLoseText = "You Win!";
            scissorsBttn.gameObject.SetActive(true);
            StartCoroutine(sendBackWON());
        } else if (rpcResult == "Scissors")
        {
            WinLoseText = "You Win!";
            scissorsBttn.gameObject.SetActive(true);
            StartCoroutine(sendBackWON());
        }
        txt.text = WinLoseText;
    }
}
