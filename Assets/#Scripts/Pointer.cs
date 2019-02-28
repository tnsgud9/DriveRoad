using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pointer : MonoBehaviour
{
    public GameObject MousePoint;
    private int _mask = 10;
    
    
    
    void Start()
    {
        
    }

    void Update()
    {
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        RaycastHit hit;
        if (Physics.Raycast(ray, out hit, 100f , 1<<11))
        {
            if (Input.GetMouseButton(0))
            {
                MousePoint.transform.position = hit.point;
            }
        }
    }
}
