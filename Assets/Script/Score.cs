using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SocialPlatforms.Impl;

public class Score : MonoBehaviour
{
    [SerializeField] TMP_Text scoreTxt;

    int score;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void AddScore(int value)
    {
        score += value;
        Debug.Log(score);
        //scoreTxt.text = "Score: " + score;
        scoreTxt.text = "Score " + score;
    }
}
