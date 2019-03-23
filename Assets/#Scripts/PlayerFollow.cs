using System.Collections;
using System.Collections.Generic;
using System.Drawing;
using CollabProxy.UI;
using UnityEngine;
using UnityEngine.Experimental.UIElements.StyleEnums;

public class PlayerFollow : MonoBehaviour
{
    private int _arraycount=0;
    private bool _moveCheck=false;

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
                Debug.Log(_arraycount);

                _arraycount++;
                Pointer.WayPoint.RemoveAt(_arraycount-1);

            }
    }
}
