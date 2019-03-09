using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pointer : MonoBehaviour
{
    public GameObject playerPoint;  //touch pointer
    public GameObject touchPoint; //Player pointer
    public static ArrayList WayPoint = new ArrayList();
    
    
    void Start()
    {
        
    }

    /*
        TouchPoint는 스크린을 눌렀을 때 그 해당 위치로 이동
        ChildPoint는 TouchPoint의 방향을 따라감 ray위치로 가진 않음   
    */
    
    void Update()
    {
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        RaycastHit hit;
        if (Physics.Raycast(ray, out hit, 100f , 1<<11))
        {
            //touchPoint.transform.position = hit.point;

            if (Input.GetMouseButtonDown(0))
            {
                touchPoint.transform.position = hit.point;
                playerPoint.transform.parent = touchPoint.transform;
            }
            if (Input.GetMouseButton(0))
            {
                touchPoint.transform.position = hit.point;
                WayPoint.Add(playerPoint.transform.position);

            }

            if (Input.GetMouseButtonUp(0))
            {
                playerPoint.transform.parent = null;
            }
            




        }
    }
}
