using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIManager : MonoBehaviour
{
    public GameObject[] lifes;
    public Text scoreText = null;
    private int score = 0;
    public GameManager gameMgr;
    // Start is called before the first frame update
    void Start()
    {
        for (int i = 0; i < gameMgr.m_lifes; i++)
        {
            lifes[i].SetActive(true);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void UpdateLives(int currentLives)
    {
        for (int i = lifes.Length-1; i < lifes.Length-currentLives-1; i--)
        {
            lifes[i].SetActive(false);
        }
    }
}
