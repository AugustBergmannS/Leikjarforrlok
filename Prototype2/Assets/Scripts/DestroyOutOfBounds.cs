using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyOutOfBounds : MonoBehaviour
{
    private float topBound = 30f;
    private float lowerBound = -10f;

    void Update()
    {
        //Eyðir banananum sem fer út af svæðinu
        if (transform.position.z > topBound)
        {
            Destroy(gameObject);
        }
        //Eyðir dýrinu sem fer út af svæðinu og skilar "Leikurinn er Búinn!" í console-ið 
        else if (transform.position.z < lowerBound)
        {
            Debug.Log("Game Over!");
            Destroy(gameObject);
        }
    }
}
