using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreboardScript : MonoBehaviour
{
    Text text;
    public static int coinAmount = 0;
    
    // Start is called before the first frame update
    void Start()
    {
        text = GetComponent<Text>();
    }

    // Update is called once per frame
    void Update()
    {
        text.text = coinAmount.ToString();
        
        //Extra Line for TroubleShooting Pickups (Capsule PickUp not working)
        //text.text = PickupCounter.objects.ToString();
    }
}
