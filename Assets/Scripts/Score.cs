using Oculus.Interaction.Deprecated;
using Oculus.Platform;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering.PostProcessing;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    public float score = 0;
    public Text scoreText;
    public int pointsPerInvoke = 1;
    public float invokeRepeatTime = 0.1f;

    void Start()
    {
        InvokeRepeating("AddPoint", 0.1f, 0.1f);
    }

    void Update()
    {
        scoreText.text = "Score: " + score;
    }

    void AddPoint()
    {
        score += pointsPerInvoke;
    }
}
