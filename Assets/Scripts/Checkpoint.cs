using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Checkpoint : MonoBehaviour
{
    private GameManager m_GameManager = null;

    public Sprite m_GreenFlag = null;

    public Sprite m_RedFlag = null;
    // Start is called before the first frame update
    void Start()
    {
        m_GameManager = FindObjectOfType<GameManager>();
    }

    /// <summary>
    /// Some collider have enter on the death trigger
    /// </summary>
    /// <param name="other"></param>
    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Player")
        {
            m_GameManager.SetSpawnPoint(transform);
            GetComponent<SpriteRenderer>().sprite = m_GreenFlag;
            GetComponent<BoxCollider2D>().enabled = false;
            //Destroy(this.gameObject);
        }
    }
    
    // Update is called once per frame
    void Update()
    {
        
    }
}
