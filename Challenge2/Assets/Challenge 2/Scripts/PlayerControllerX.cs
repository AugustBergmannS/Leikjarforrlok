using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControllerX : MonoBehaviour
{
    public GameObject dogPrefab;
    private float skotHradi = 1;
    private float naestaSkot = 0;

    // Update is called once per frame
    void Update()
    {
        // On spacebar press, if enough time has elapsed since last fire, send dog
        if (Input.GetKeyDown(KeyCode.Space) && Time.time > naestaSkot)
        {
            naestaSkot = Time.time + skotHradi;
            Instantiate(dogPrefab, transform.position, dogPrefab.transform.rotation);
        }
    }
}
