using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PanelSwitcher : MonoBehaviour
{
    //imports all panels
    public GameObject playerPanel;
    public GameObject mainPanel;
    public GameObject bankPanel;
    public GameObject jobsPanel;
    public GameObject funPanel;

// Start is called before the first frame update
    void Start()
    {
        mainPanel.SetActive(true);
        playerPanel.SetActive(false);
        bankPanel.SetActive(false);
        jobsPanel.SetActive(false);
        funPanel.SetActive(false);
    }

    public void HideAll(){
        mainPanel.SetActive(false);
        playerPanel.SetActive(false);
        bankPanel.SetActive(false);
        jobsPanel.SetActive(false);
        funPanel.SetActive(false);
    }
}
