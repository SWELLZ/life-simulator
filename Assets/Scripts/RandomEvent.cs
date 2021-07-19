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

    public string[] randomEventTitles = {"First Kiss", "Free Money", "Job Offer"};
    public string[] randomEventDescs = { "A girl tries to kiss you. It will be your first kiss!",
    "You find a briefcase with $1,000 in it!",
    "A man offers you a job to Detail a rich persons car for $12,000 a year"
    };
    public string[] choice1Texts = {"Kiss her", "Take It", "Accept the Job"};
    public string[] choice2Texts = {"Run Away", "Leave It", "Decline the Job"};

    public void RandomScenario()
    {
        int index = Random.Range(0, randomEventTitles.Length - 1);
        titleText.text = randomEventTitles[index];
        descriptionText.text = randomEventDescs[index];
        choice1Txt.text = choice1Texts[index];
        choice2Txt.text = choice2Texts[index];
        randomEventPanel.SetActive(true);
    }

    void Start()
    {
        randomEventPanel.SetActive(false);
    }
}
