using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pointer : MonoBehaviour
{
    public GameObject playerPoint; //touch pointer
    public GameObject touchPoint; //Player pointer
    public static ArrayList WayPoint = new ArrayList();
    public static int PosCount = 0;
   // public static int CountPoint=0;

    

    /*
        TouchPoint는 스크린을 눌렀을 때 그 해당 위치로 이동
        ChildPoint는 TouchPoint의 방향을 따라감 ray위치로 가진 않음   
    */
    
    void Update() 
    {
        
        
        //input
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        RaycastHit hit;
        if (Physics.Raycast(ray, out hit, 100f, 1 << 11))
        {
            //touchPoint.transform.position = hit.point;



            if (Input.GetMouseButtonDown(0))
            {
                touchPoint.transform.position = hit.point;
                playerPoint.transform.parent = touchPoint.transform;
                PosCount++;
                GameObject.Find("PPSprite").GetComponent<SpriteRenderer>().enabled = true;
            }

            if (Input.GetMouseButton(0))
            {
                //레이어 검사후 좌표값 추가
                if (hit.transform.name == "Terrain" && (Input.GetAxis("Mouse X") != 0 || Input.GetAxis("Mouse Y") != 0)) //마우스 가만히 있으면 안움직임
                {
                    touchPoint.transform.position = hit.point;
                    WayPoint.Add(playerPoint.transform.position);
                    PosCount++;

                }

            }

            if (Input.GetMouseButtonUp(0))
            {
                playerPoint.transform.parent = null; //부모 자식관계 해제

                GameObject.Find("PPSprite").GetComponent<SpriteRenderer>().enabled = false;
            }

        }
        
        
        
        
        // 화면 밖 못나가게
        Vector3 pos = Camera.main.WorldToViewportPoint(playerPoint.transform.position);
        if (pos.x < 0f) pos.x = 0f;
        if (pos.x > 1f) pos.x = 1f;
        if (pos.y < 0f) pos.y = 0f;
        if (pos.y > 1f) pos.y = 1f;

        playerPoint.transform.position = Camera.main.ViewportToWorldPoint(pos);
        
        // y 축 고정
        playerPoint.transform.position = new Vector3(playerPoint.transform.position.x,0f,playerPoint.transform.position.z);

    }
}

