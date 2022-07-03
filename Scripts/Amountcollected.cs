using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Amountcollected : MonoBehaviour
{
    public static int Banana;
    Text NumberScore;
    void Start()
    {
        NumberScore = GetComponent<Text>();
    }


    void Update()
    {
        NumberScore.text = Banana.ToString();
    }
}
