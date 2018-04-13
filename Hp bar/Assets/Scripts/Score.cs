using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{

    public int score = 5;
    private Text textComponent;
    // Use this f initialization
    void Start()
    {
        textComponent = GetComponent<Text>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.X))
            AddScore();
        if (Input.GetKeyDown(KeyCode.Z))
            RemoveScore();
        textComponent.text = "score: " + score;
    }

    public void AddScore()
    {
        score += 1;
    }

    public void RemoveScore()
    {
        score -= 1;
    }

}