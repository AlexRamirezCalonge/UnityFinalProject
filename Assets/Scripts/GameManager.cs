using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    //PUBLIC
    /// <summary>
    /// SpawnPoint at the beggining of the level
    /// </summary>
    public Transform m_InitialSpawnPoint = null;
    /// <summary>
    /// Player
    /// </summary>
    public GameObject m_Player = null;
    //PRIVATE
    /// <summary>
    /// SpawnPoint reached by the player
    /// </summary>
    private Transform m_CurrentSapwnPoint = null;
    private int m_Punctuation = 0;
    public int m_lifes = 3;
    private UIManager m_UIMgr=null;

    void Awake()
    {
        m_CurrentSapwnPoint = m_InitialSpawnPoint;
    }

    // Start is called before the first frame update
    void Start()
    {
        m_UIMgr = GameObject.Find("CanvasPanel").GetComponent<UIManager>();

        if (!m_InitialSpawnPoint)
            Debug.LogWarning("InitialSpawnPoint doessn't been asignated");

        RespawnPlayer();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    /// <summary>
    /// Reset the player position at the last spawn point reached
    /// </summary>
    public void RespawnPlayer()
    {
        // Colocamos al player en el punto de spawn actual
        m_Player.transform.position = m_CurrentSapwnPoint.position;
    }

    /// <summary>
    /// Set new checkpoint
    /// </summary>
    public void SetSpawnPoint(Transform newLocation)
    {
        // We assign the new location as spawn point
        m_CurrentSapwnPoint.position = newLocation.position;
    }

    public void UpdatePunctuation(int points)
    {
        m_Punctuation += points;

        Debug.Log("Actual Points: "+ m_Punctuation);
    }
}
