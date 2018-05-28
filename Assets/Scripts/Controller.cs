using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Controller : MonoBehaviour
{

    public float updateTime = 10.0f; //速度が速くなるまでの時間
    public static int gameSpeed = 1; //指定した時間が経過した回数毎に更新
    public static float elapsedTime = 0.0f; //ゲーム開始からの経過時間

    private float countTime = 0.0f;

    // Use this for initialization
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        if (updateTime < countTime)
        {
            countTime = 0.0f;
            gameSpeed++;
        }

        elapsedTime += Time.deltaTime;
        countTime += Time.deltaTime;
    }
}
