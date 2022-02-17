using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreR : MonoBehaviour
{
    [SerializeField] Text Score;
    [SerializeField] Text Rank;
    [SerializeField] Text Sc;
    int[] a = { 0,0,0,0,0};
    public static List<int> Scorelist = new List<int>();
    int HiS;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        Sc.text = ("Score : " +Player.ScoreP);
        
    }
    public void Ranking()
    {
        Scorelist.AddRange(a);
        Scorelist.Add(Player.ScoreP);
        Scorelist.Sort((a, b) => b - a);
        Rank.text = ("スコアランキング");
        Score.text = "1 : " + Scorelist[0] + "\n2 : " + Scorelist[1] + "\n3 : " + Scorelist[2] + "\n4 : " + Scorelist[3] + "\n5 : " + Scorelist[4];
    }
}
