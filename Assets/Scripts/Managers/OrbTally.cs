using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OrbTally : MonoBehaviour
{
    public int heldOrbs, maxOrbs = 6;
    // Start is called before the first frame update
    void Start()
    {
        heldOrbs = 0;
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
