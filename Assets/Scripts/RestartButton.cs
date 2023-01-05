using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class RestartButton : MonoBehaviour
{

    [SerializeField]
    KeyCode keyRestart;

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKey(keyRestart))
        {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        ScoreboardScript.coinAmount = 0;
        PickupCounter.objects = 0;
        }
    }
}
