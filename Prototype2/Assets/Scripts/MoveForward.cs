using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveForward : MonoBehaviour
{
    public float speed = 40.0f; //hraðinn


    void Update()
    {
        //Bananar fara fljúandi á hraðanum sem er fyrir ofan
        transform.Translate(Vector3.forward * Time.deltaTime * speed);   
    }
}
