using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControllerX : MonoBehaviour
{
    public GameObject dogPrefab;
    private float timeInterval;


    // Update is called once per frame
    void Update()
    {
        // On spacebar press, spawn dog if timeInterval is > 2 seconds
        timeInterval += 1 * Time.deltaTime;
        if (Input.GetKeyDown(KeyCode.Space) && timeInterval > 2)
        {
           
            Instantiate(dogPrefab, transform.position, dogPrefab.transform.rotation);

            timeInterval = 0; // reset timeInterval to 0




        }





    }

}
