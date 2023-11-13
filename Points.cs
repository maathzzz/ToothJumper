using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Points : MonoBehaviour
{
    public Text pointsLevel_txt;
    private int points;
    public static bool stopCounter;
    void Start()
    {
        stopCounter = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (stopCounter == false)
        {
            points += 100;
            pointsLevel_txt.text = points.ToString("0");
        }
        
    }
}
