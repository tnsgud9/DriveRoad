using System.Collections;
using System.Collections.Generic;
using System.Drawing;
using CollabProxy.UI;
using UnityEngine;
using UnityEngine.Experimental.UIElements.StyleEnums;

public class Player : MonoBehaviour
{
    private int _arraycount=0;
    private bool _moveCheck=false;

    private GameObject _model;

    void Start()
    {
        _model = GameObject.Find("PlayerModel");
    }

    void Update()
    {
        Outline();
        Input();
    }




    void Input()
    {
        transform.position.Normalize();
        transform.position = Vector3.MoveTowards(transform.position, (Vector3)Pointer.WayPoint[_arraycount], 0.1f);

        if (transform.position == (Vector3)Pointer.WayPoint[_arraycount])
        {
            _arraycount++;
            Pointer.WayPoint.RemoveAt(_arraycount - 1);

        }
    }

    void Outline()
    {
        
        Vector3 pos = Camera.main.WorldToViewportPoint(_model.transform.position);
        if (pos.x > 1.3f) Debug.Log("Player Model has Outline");
        
    }
    
}
