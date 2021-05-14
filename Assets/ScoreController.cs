using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreController : MonoBehaviour
{
    public GameObject gamescoreText;
    private int score = 0;

   void gamescore()
    {
        gamescoreText.GetComponent<Text>().text = "Score:" +score;
    }


    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.tag == "SmallStarTag")
        {
            score += 5;
        }
        if (other.gameObject.tag == "LargeStarTag")
        {
            score += 10;
        }
        if (other.gameObject.tag == "SmallCloudTag")
        {
            score += 7;
        }
        if (other.gameObject.tag == "LargeCloudTag")
        {
            score += 14;
        }
        gamescore();
    }
}
