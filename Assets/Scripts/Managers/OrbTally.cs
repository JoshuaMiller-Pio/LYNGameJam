using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OrbTally : MonoBehaviour
{
    public int heldOrbs, maxOrbs = 6, currentQuestion;
    public QuestionManager questionManager;
    public GameObject[] orbs = new GameObject[6];
    public GameObject player;
    // Start is called before the first frame update
    void Start()
    {
       
        heldOrbs = 0;
       
        currentQuestion = 0;
    }
    //hi
    private void OnCollisionEnter2D(Collision2D collision)
    {
        int i = 0;
        foreach (var question in questionManager.questions)
        {
            
            if (collision.gameObject.tag == "Question" && collision.gameObject == questionManager.questions[i].gameObject)
            {
                Time.timeScale = 0f;
                questionManager.qCanvases[i].SetActive(true);
                currentQuestion = i;
                questionManager.answeredQuestion[i] = 1;
                //sound for quiz bubble
                audioManager.Instance.PlayQuestion();
                Debug.Log("question");
            }
            i++;
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.tag == "Orb" && heldOrbs < maxOrbs)
        {
            int i = currentQuestion;
            if(collision.gameObject == orbs[i] && questionManager.answeredQuestion[i] == 1)
            {
                heldOrbs++;
                collision.gameObject.SetActive(false);
                audioManager.Instance.PlayPickUp();
                //add pick up here
            }

        }
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
