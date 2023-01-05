using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Collections.Generic;
using UnityEngine.SceneManagement;


public class PickupCounter : MonoBehaviour
{

    public static int objects = 0;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(objects == 2)
        {
            Invoke("RestartDelay", 2.0f);
        }
        
    }

    void RestartDelay()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
                ScoreboardScript.coinAmount = 0;
                PickupCounter.objects = 0;
    }
}