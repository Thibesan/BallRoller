using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnObject : MonoBehaviour
{

    //Respective prefab objects for pickups
    public GameObject coinPrefab;
    public GameObject boxPrefab;
    public GameObject capsulePrefab;
    
    //Variables for visualization of spawn bounds
    public Vector3 center;
    public Vector3 size;

    // Start is called before the first frame update
    void Start()
    {
        //Call Initial Spawn Function
        SpawnAmount();
    }

    //Function to spawn specified amount of pickups
    public void SpawnAmount()
    {
        
        //Desired amount of each pickup spawn
        int coins = 3;
        int boxes = 3;
        int capsules = 2;

        //Spawn Desired Number of Prefab, Increment counter respectively
        do
        {
            SpawnCoin();
            PickupCounter.objects += 1;
            coins--;
        } while (coins > 0);

        do
        {
            SpawnBox();
            PickupCounter.objects += 1;
            boxes--;
        } while (boxes > 0);

        do
        {
            SpawnCapsule();
            PickupCounter.objects += 1;
            capsules--;
        } while (capsules > 0);


    }

    //Function to spawn respective object in defined bounds
    public void SpawnCoin()
    {
        //Position based on midpoint of each axis and determined size above
        Vector3 posCoin = center + new Vector3(Random.Range(-size.x / 2, size.x / 2), Random.Range(-size.y / 2, size.y / 2), Random.Range(-size.z / 2, size.z / 2));

        //Instantiate, applied transform to maintain rotation of prefab
        Instantiate(coinPrefab, posCoin, coinPrefab.transform.rotation);
    }

    public void SpawnBox()
    {
        Vector3 posBox = center + new Vector3(Random.Range(-size.x / 2, size.x / 2), Random.Range(-size.y / 2, size.y / 2), Random.Range(-size.z / 2, size.z / 2));

        Instantiate(boxPrefab, posBox, boxPrefab.transform.rotation);
    }

    public void SpawnCapsule()
    {
        Vector3 posCapsule = center + new Vector3(Random.Range(-size.x / 2, size.x / 2), Random.Range(-size.y / 2, size.y / 2), Random.Range(-size.z / 2, size.z / 2));

        Instantiate(capsulePrefab, posCapsule, capsulePrefab.transform.rotation); 
    }
    //Visualize spawn bounds with red box based on center point and size specified above
    void OnDrawGizmosSelected()
    {
        //Red Box for Visual Aid
        Gizmos.color = new Color(1,0,0,0.5f);
        //Draw Cube based on specified input variables above
        Gizmos.DrawCube(center, size);
    }
}
