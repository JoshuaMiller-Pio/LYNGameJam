using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class QuestionManager : MonoBehaviour
{
    public GameObject[] questions = new GameObject[6];
    public GameObject[] qCanvases = new GameObject[6];
    public GameObject[] shields = new GameObject[6];
    public GameObject player;
    public OrbTally playerOrbTally;
    // Start is called before the first frame update
    void Start()
    {
        
        playerOrbTally = this.gameObject.GetComponent<OrbTally>();
    }

    public void TurnOffShield()
    {
        int i = playerOrbTally.currentQuestion;
        shields[i].gameObject.SetActive(false);
        Time.timeScale = 1;
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
