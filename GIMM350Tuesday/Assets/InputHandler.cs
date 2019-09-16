using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class InputHandler : MonoBehaviour
{
    public InputField inputText;
    public Text outputText;
    public Button textButton;

    // Start is called before the first frame update
    void Start()
    {
        outputText.text = null;
    }

    public void processText()
    {
        outputText.text = Utilities.ProcessText(inputText.text);
    }
}