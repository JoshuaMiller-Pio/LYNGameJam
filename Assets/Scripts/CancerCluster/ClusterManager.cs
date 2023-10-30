using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ClusterManager : MonoBehaviour
{
    public GameObject player;
    public OrbTally playerOrbTally;
    public GameObject[] tumours = new GameObject[6];
    public Canvas win;
    // Start is called before the first frame update
    void Start()
    {
        playerOrbTally = player.GetComponent<OrbTally>();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.tag == "Player")
        {
            for (int i = 0; i < playerOrbTally.heldOrbs; i++)
            {
                tumours[i].SetActive(false);
                if(i >= 5)
                {
                    Debug.Log("boo");
                    win.gameObject.SetActive(true);
                    Time.timeScale = 0;
                }
            }
        }
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
