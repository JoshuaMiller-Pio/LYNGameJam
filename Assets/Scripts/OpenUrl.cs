using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpenUrl : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void LoveNuts()
    {
         Application.OpenURL("https://loveyournuts.org/");
    }
    public void WHO()
    {
        Application.OpenURL("https://www.who.int/news-room/fact-sheets/detail/cancer");

    }
}
