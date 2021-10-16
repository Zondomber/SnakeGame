using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TrigMove : MonoBehaviour
{
    public Transform player;
    public float XDU;
    public float YDU;

    void Update()
    {
        transform.position = new Vector2(player.position.x - XDU, player.position.y - YDU);
    }
}
