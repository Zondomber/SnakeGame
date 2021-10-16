using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomSpawn : MonoBehaviour
{
    float RandX;
    float RandY;
    public Transform PosCoin;
    public Coin Coin;
    public float RandomChislo;
    public float spawnRate = 1f;
    public float nextSpawn = 0.0f;

    void Update()
    {
        

        if (Time.time > nextSpawn && Coin.ActiveCoin == true)
        {
            RandomChislo = Random.Range(1, 100);
            nextSpawn = Time.time + spawnRate;
            if(RandomChislo >= 1 && RandomChislo <= 49)
            {
                RandX = Random.Range(-6.7f, 8.72f);
                RandY = Random.Range(3.3f, -0.56f);
                PosCoin.position = new Vector2(RandX, RandY);
            }
            if (RandomChislo >= 50 && RandomChislo <= 100)
            {
                RandX = Random.Range(-2.9f, 8.72f);
                RandY = Random.Range(3.3f, -3.53f);
                PosCoin.position = new Vector2(RandX, RandY);
            }
            
           
        }
    }
}
