using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ButtonWrong : MonoBehaviour
{
    // Start is called before the first frame update
    Image image;
    Button button;
    void Start()
    {
        image = GetComponent<Image>();
        button = GetComponent<Button>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void wrong()
    {
        image.color = Color.red;
        audioManager.Instance.PlayQuizFailed();
        button.interactable = false;
    }
}
