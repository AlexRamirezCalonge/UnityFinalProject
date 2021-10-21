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

    void Awake()
    {
        m_CurrentSapwnPoint = m_InitialSpawnPoint;
    }

    // Start is called before the first frame update
    void Start()
    {
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

}
