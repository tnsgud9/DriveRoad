using System.Collections;
using System.Collections.Generic;
using System.Drawing;
using UnityEngine;
using UnityEngine.Experimental.UIElements.StyleEnums;

public class PlayerFollow : MonoBehaviour
{
    private int _arraycount=0;
    // Start is called before the first frame update
    void Start()
    {
        
    }


    // Update is called once per frame
    void Update()
    {

            transform.position.Normalize();
            transform.position = Vector3.MoveTowards(transform.position, (Vector3) Pointer.WayPoint[_arraycount], 0.1f);

            if (transform.position == (Vector3) Pointer.WayPoint[_arraycount])
            {
                _arraycount++;
            }

    }
}
