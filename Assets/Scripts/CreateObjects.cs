using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreateObjects : MonoBehaviour
{

    public GameObject cube1;
    public GameObject cube2;
    public GameObject cube3;
    public GameObject cube4;

    private List<GameObject> cubeList = new List<GameObject>();

    private int count = 0;
    private float objectWidth = 20.0f;

    // Use this for initialization
    void Start()
    {
        InitCubeList(); //cubeListの初期化
    }

    // Update is called once per frame
    void Update()
    {
        if (count > (objectWidth) / (Controller.gameSpeed * 0.1))
        {
            CreateCube(Random.Range(0, cubeList.Count));
            count = 0;
        }

        count++;
    }

    private void InitCubeList()
    {
        cubeList.Add(cube1);
        cubeList.Add(cube2);
        cubeList.Add(cube3);
        cubeList.Add(cube4);
    }

    private void CreateCube(int index)
    {
        Vector3 vector = new Vector3(0.0f, cubeList[index].transform.position.y / 2, 50.0f);
        GameObject cube = Instantiate(cubeList[index], vector, Quaternion.identity) as GameObject;
        objectWidth = cube.GetComponent<Renderer>().bounds.size.x;
    }

}
