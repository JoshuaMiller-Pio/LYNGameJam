using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClusterManager : MonoBehaviour
{
    public GameObject player;
    public OrbTally playerOrbTally;
    public GameObject[] tumours = new GameObject[6];
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
            }
        }
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
