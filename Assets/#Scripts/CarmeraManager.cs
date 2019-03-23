using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class CarmeraManager : MonoBehaviour
{
    public static float Speed = 0.4f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        transform.Translate(Vector3.left * Speed *Time.deltaTime);
        
    }
}
