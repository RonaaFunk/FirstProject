using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpinnerZ : MonoBehaviour
{
    public float speed = 100f;


    void Start()
    {

    }

    void Update()
    {
        transform.Rotate(Vector3.up, speed * Time.deltaTime);
    }

}
