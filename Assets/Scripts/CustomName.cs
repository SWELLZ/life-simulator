using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CustomName : MonoBehaviour
{
    //imports Character class to access name variable
    public Character myCharacter;

    public GameObject namePopUp;

    public InputField firstName;
    public InputField lastName;
    public string fullName;

    //Sets characters name equal to what user enters
    public void Done(){
        fullName = firstName.text + " " + lastName.text;
        myCharacter.name = fullName;
        myCharacter.UpdateTexts();
        namePopUp.SetActive(false);
    }

    //Sets a random name
    public void Skip(){
        myCharacter.nameText.text = "Name: Random Name";
        namePopUp.SetActive(false);
    }

    // Start is called before the first frame update
    void Start()
    {
        namePopUp.SetActive(false);
    }
}
