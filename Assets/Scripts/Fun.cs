using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Fun : MonoBehaviour
{
    public Character myCharacter;
    public Toggle gymToggle;
    public int yearlyHappiness = 0;

    public void Park(){
        myCharacter.happiness += 5;
        myCharacter.UpdateSliders();
    }

    public void GymToggleOn(){
        if (gymToggle.GetComponent<Toggle>().isOn == true){
            yearlyHappiness += 25;
        } else {
            yearlyHappiness = 0;
        }
    }
}
