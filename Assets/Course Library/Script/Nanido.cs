using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Nanido : MonoBehaviour
{
    public static bool U;
    public static bool E;
    public static bool H;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void Easy()
    {
        E = true;
    }
    public void Usually()
    {
        U = true;
    }
    public void Hard()
    {
        H = true;
    }
    public void ScoreReset()
    {
        Player.ScoreP = 0;
    }
}
