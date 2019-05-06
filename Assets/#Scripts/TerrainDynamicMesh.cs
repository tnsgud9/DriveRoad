using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TerrainDynamicMesh : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        MeshFilter mf = GetComponent<MeshFilter>();
        Mesh mesh = mf.mesh;
        Vector3[] vertices = new Vector3[]
        {
            //front face
            new Vector3( -1 , 1 , 1 ), //left top front
            new Vector3(1,1,1),//right top front, 1
            new Vector3(-1,-1,1),//left bottom front
            new Vector3(1,-1,1)//right bottom front

        };

        //Triangles
        // 3개 포인트, 시계방향으로 어느방향으로 보여주는가 결정함.
        int[] triangles = new int[]
        {
            //front face//
            0,2,3,//first triangle
            3,1,0//second triangle

        };

        //UV// 텍스쳐를 입혀준다.
        Vector2[] uvs = new Vector2[]
        {
            //front face//
            // 0,0 is bottom left,    1,1 is top right
            new Vector3 (0,1,1),
            new Vector3 (0,0,0),
            new Vector3 (1,1,0),
            new Vector3 (1,0,1),
        };
        mesh.Clear();
        mesh.vertices = vertices;
        mesh.triangles = triangles;
        mesh.uv = uvs;
        mesh.RecalculateNormals();
        
    }

    // Update is called once per frame
    void Update()
    {
        

    }
}
