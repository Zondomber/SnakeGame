using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Coin : MonoBehaviour
{
    public bool ActiveCoin;
    public bool ActiveScore;
    public float TimerE;
    public int Score;
    public AudioSource SoundUP;
    public Text S_TextBack;
    public Text S_Text;

    void Start()
    {
        ActiveCoin = false;
    }

    public void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.tag == "Block")
        {
            StartCoroutine(Timer());
        }
        if (collision.tag == "SnakeHead" || collision.tag == "SnakeBlock")
        {
            SoundUP.Play();
            if (ActiveScore == false)
            {
                
                ActiveScore = true;
                StartCoroutine(ScoreE());
            }
            StartCoroutine(Timer());
        }
    }
    
    void Update()
    {
        S_TextBack.text = Score.ToString();
        S_Text.text = Score.ToString();
    }

    IEnumerator Timer()
    {
        ActiveCoin = true;
        yield return new WaitForSeconds(TimerE);
        ActiveCoin = false;
        ActiveScore = false;
    }

    IEnumerator ScoreE()
    {
        ActiveScore = true;
        yield return new WaitForSeconds(TimerE);
        Score = Score + 1;
        ActiveScore = false;
    }
}
