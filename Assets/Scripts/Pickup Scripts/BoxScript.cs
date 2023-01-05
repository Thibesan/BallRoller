using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoxScript : MonoBehaviour
{
  void OnTriggerEnter(Collider other)
  {
      //Add 2 to Points
      ScoreboardScript.coinAmount += 2;
      PickupCounter.objects--;
      Destroy(gameObject);
  }
}
