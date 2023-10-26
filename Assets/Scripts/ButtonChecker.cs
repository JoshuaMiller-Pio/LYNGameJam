using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonChecker : MonoBehaviour
{
    // Start is called before the first frame update
    public void nextLevel()
    {
        GameManager.Instance.nextScene();
    }
    public void Retry()
    {
        GameManager.Instance.restartScene();
    }
    public void Mainmenu()
    {
        GameManager.Instance.MainmenuScene();
    }
    public void Quit()
    {
        Application.Quit(); 
    }
}
