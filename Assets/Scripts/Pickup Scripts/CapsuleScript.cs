using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CapsuleScript : MonoBehaviour
{
    void OnTriggerEnter(Collider other)
    {
        //Add 3 to Points
        ScoreboardScript.coinAmount += 3;
        Destroy(gameObject);
    }
}
