using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManger : MonoBehaviour
{
    public GameObject[] obstaclePrefab;
    private Vector3 spawnPos = new Vector3(100, 0, 0);
    private float repeatRate = 1f;
    private float passedTime = -2f;
    private Player playerController;
    float n;
    private void Start()
    {
        playerController = GameObject.Find("Player").GetComponent<Player>();
    }
    void Update()
    {
        if(Nanido.E)
        {
            n = 1;
        }
        else if(Nanido.U)
        {
            n = 1;

        }
        else if(Nanido.H)
        {
            n = 0.5f;
        }
        else
        {
            n = 1;
        }


        if (playerController.gameOver)
        {
            return;
        }
        passedTime += Time.deltaTime;
        if (passedTime > repeatRate*n)
        {
            spawnPos = new Vector3(100,0,Random.Range(-1,2)*3);
            Instantiate(obstaclePrefab[Random.Range(0,obstaclePrefab.Length)], spawnPos, obstaclePrefab[0].transform.rotation);
            passedTime = 0f;
        }
        
    }
}
