using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BodyUP : MonoBehaviour
{
    public float TimerE;
    public bool Die;


    void Start()
    {
        StartCoroutine(Timer());
    }

    void Update()
    {
        GameObject go = GameObject.Find("Player");
        Move Data = go.GetComponent<Move>();
        Die = Data.Die;
        if (Die == true)
        {
            Destroy(gameObject);
        }
    }

    IEnumerator Timer()
    {
        yield return new WaitForSeconds(TimerE);
        gameObject.tag = "SnakeBlock";
    }
}
