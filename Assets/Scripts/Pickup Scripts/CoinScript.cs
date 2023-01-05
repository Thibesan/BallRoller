using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinScript : MonoBehaviour
{
    void OnTriggerEnter(Collider other)
    {
        //Add 1 to Points
        ScoreboardScript.coinAmount += 1;
        PickupCounter.objects--;
        Destroy(gameObject);
    }
}
