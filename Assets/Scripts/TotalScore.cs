using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TotalScore : MonoBehaviour
{
    public GameObject m_totalScoreGameObject = null;
    // Start is called before the first frame update
    void Start()
    {
        m_totalScoreGameObject.GetComponent<Text>().text = GameManager._Punctuation.ToString();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
