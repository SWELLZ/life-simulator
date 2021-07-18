using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class RandomEvent : MonoBehaviour
{
    public GameObject randomEventPanel;
    public Text titleText;
    public Text descriptionText;
    public Button choice1;
    public Text choice1Txt;
    public Button choice2;
    public Text choice2Txt;

    public void RandomScenario()
    {
        titleText.text = "First Kiss!";
        descriptionText.text = "A girl tries to kiss you. It will be your first kiss!";
        choice1Txt.text = "Kiss her";
        choice2Txt.text = "Run Away";
        randomEventPanel.SetActive(true);
    }

    void Start()
    {
        randomEventPanel.SetActive(false);
    }
}
