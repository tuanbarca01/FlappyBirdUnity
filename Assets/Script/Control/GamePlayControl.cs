using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GamePlayControl : MonoBehaviour
{
    public static GamePlayControl instance;
    [SerializeField] private Button instructionButton;
    [SerializeField] private Text scoreText;

     void Awake()
    {
        _MakeInstance();
    }
    void _MakeInstance()
    {
        if (instance == null)
        {
            instance = this;
        }
    }
    public void _Setscore(int score)
    {
        scoreText.text = "" + score;
    }
}

