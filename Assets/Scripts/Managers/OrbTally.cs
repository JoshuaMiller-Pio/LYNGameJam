using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OrbTally : MonoBehaviour
{
    public int heldOrbs, maxOrbs = 6;
   public QuestionManager questionManager;
    // Start is called before the first frame update
    void Start()
    {
        heldOrbs = 0;
        questionManager = GetComponent<QuestionManager>();
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        for (int i = 0; i < questionManager.questions.Length; i++)
        {
            if (collision.gameObject == questionManager.questions[i].gameObject)
            {
                Time.timeScale = 0f;
                questionManager.qCanvases[i].SetActive(true);
            }
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.tag == "Orb" && heldOrbs < maxOrbs)
        {
            heldOrbs++;
            collision.enabled = false;
        }
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
