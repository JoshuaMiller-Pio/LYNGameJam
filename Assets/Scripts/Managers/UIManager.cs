using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class UIManager : MonoBehaviour
{
    public GameObject player;
    public OrbTally playerOrbTally;
    public TMP_Text UIOrbTally;
    // Start is called before the first frame update
    void Start()
    {
     playerOrbTally = player.gameObject.GetComponent<OrbTally>();   
    }

    // Update is called once per frame
    void Update()
    {
        UIOrbTally.text = playerOrbTally.heldOrbs.ToString() + " / 6";
    }
}
