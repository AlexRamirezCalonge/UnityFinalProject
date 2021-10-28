using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pickable : MonoBehaviour
{
    private GameManager m_GameManager = null;

    public int Points;

    private AudioSource m_Audio;

    private BoxCollider2D m_Collider;


    // Start is called before the first frame update
    void Start()
    {
        m_GameManager = FindObjectOfType<GameManager>();
        m_Audio = GetComponent<AudioSource>();
        m_Collider = GetComponent<BoxCollider2D>();
    }
    /// <summary>
    /// Some collider have enter on the death trigger
    /// </summary>
    /// <param name="other"></param>
    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Player")
        {
            m_Collider.enabled = false;
            GameManager._Punctuation += Points;
            m_Audio.Play();
            GetComponent<SpriteRenderer>().enabled = false;
        }
    }
    // Update is called once per frame
    void Update()
    {
        if (!m_Audio.isPlaying && !m_Collider.enabled)
        {
            Destroy(this.gameObject);
        }
    }
}
