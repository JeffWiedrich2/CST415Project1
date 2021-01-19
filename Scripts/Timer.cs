using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Timer : MonoBehaviour
{
    public Text countdownText;
    public GameObject youWin;

    private float countdown = 30f;

    // Update is called once per frame
    void Update()
    {
        if (countdown <= 0)
        {
            WinGame();
        }

        countdown -= Time.deltaTime;

        countdown = Mathf.Clamp(countdown, 0f, Mathf.Infinity);

        countdownText.text = string.Format("{0:00.00}", countdown);
    }

    void WinGame()
    {
        youWin.SetActive(true);
    }

    public void RestartLevel()
    {
        SceneManager.LoadScene("Scene1");
    }
}
