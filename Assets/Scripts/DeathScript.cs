using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeathScript : MonoBehaviour
{
    /// <summary>
    /// 
    /// </summary>
    private GameManager m_GameManager = null;
    // Start is called before the first frame update
    void Start()
    {
        m_GameManager = FindObjectOfType<GameManager>();
        //m_GameManager=get
    }
    /// <summary>
    /// Some collider have enter on the death trigger
    /// </summary>
    /// <param name="other"></param>
    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Player")
        {
            m_GameManager.RespawnPlayer();

        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
