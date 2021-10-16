using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Schet : MonoBehaviour
{
    public Text S_TextBack;
    public Text S_Text;
    public Coin Coin;
    public int Score;
    public AudioSource CoinUp;
    public AudioSource CoinEND;
    public GameObject EffectA;
    public GameObject ButtonS;
    void Start()
    {
        EffectA.SetActive(false);
        ButtonS.SetActive(false);
    }

    void Update()
    {
        S_TextBack.text = Score.ToString();
        S_Text.text = Score.ToString();

        if (Score != Coin.Score && Score < Coin.Score + 1)
        {
            CoinUp.Play();
            Score = Score + 1;
        }

        if(Score == Coin.Score)
        {
            EffectA.SetActive(true);
            ButtonS.SetActive(true);
        }    
    }

    public void Restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }

    public void Exit()
    {
        Application.Quit();
    }
}
