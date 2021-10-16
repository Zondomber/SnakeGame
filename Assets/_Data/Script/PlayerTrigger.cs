using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerTrigger : MonoBehaviour
{
    public bool Triger;
    public Move Move;
    public int rotatplayer;


    public void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "SnakeBlock")
        {
            Triger = true;
        }
    }
    public void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.tag == "SnakeBlock" && Move.rotatplayer != rotatplayer)
        {
            Triger = false;
        }
    }
}
