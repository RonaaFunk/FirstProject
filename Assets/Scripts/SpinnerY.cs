using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpinnerY : MonoBehaviour
{
    public float speed = 100f;
    float counter = 0;
    float frames = 0;

    void Start()
    {
        frames = Time.deltaTime;

    }

    void Update()
    {
        transform.Rotate(Vector3.forward, speed * Time.deltaTime);
        
        counter += Time.deltaTime;

        Debug.Log("Time: " + counter);
        Debug.Log("FPS: " + frames / Time.deltaTime);
    }
}
