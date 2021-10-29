using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIManager : MonoBehaviour
{
    public GameObject[] lifes;
    public Text scoreText = null;
    private int m_locaScore = 0;
    private int m_localLives = 0;
    public GameManager gameMgr;
    // Start is called before the first frame update
    void Start()
    {
        m_localLives = gameMgr.m_lives;
        for (int i = 0; i < lifes.Length; i++)
        {
            lifes[i].SetActive(true);
        }
    }

    //
    void ActiveLivesUI(int totalLives)
    {
        for (int i = totalLives; i < lifes.Length; i++)
        {
            lifes[i].SetActive(false);
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (gameMgr.m_lives != m_localLives)
        {
            m_localLives = gameMgr.m_lives;
            if (m_localLives > 0)
            {
                ActiveLivesUI(m_localLives);
            }
        }

        if (GameManager._Punctuation != m_locaScore)
        {
            m_locaScore = GameManager._Punctuation;
            GameObject scoreGameObject = transform.Find("Score").gameObject;
            scoreGameObject.GetComponent<Text>().text = "Score : " + m_locaScore;
        }
    }
}
