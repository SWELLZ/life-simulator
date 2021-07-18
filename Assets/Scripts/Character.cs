using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Character : MonoBehaviour
{
    public Fun myFun;
    public Bank myBank;
    public RandomEvent myRandom;

    //Initiating text UI's
    public Text ageText;
    public Text nameText;
    public Text moneyText;
    public Text eventText;
    public Text yearText;
    public Text salaryText;
    public Text jobTitleText;
    public Text moneyTextMS; //Money value on Main Screen
    public Text savingsAccountText; 

    //Player stats variables
    public Slider intelligenceBar;
    public Slider fitnessBar;
    public Slider looksBar;
    public Slider happinessBar;
    public Text looksVal;
    public Text fitnessVal;
    public Text happinessVal;
    public Text intelligenceVal;
    public int intelligence;
    public int fitness;
    public int looks;
    public int happiness;

    //Player information variables (Name, age, etc.)
    public int age = 0;
    public int year;
    public float money = 0f;
    public float savingsAccount = 0f;
    public int salary = 0;
    public new string name;
    public string jobTitle;

    //World Info
    public float taxRate = 0.4f;

    //Sets random year and stats when you press New Life
    public void NewLife(){
        jobTitle = "Unemployed";
        year = Random.Range(1990, 2010);
        UpdateTexts();

        //Initiates stats variables, bars, and texts 
        intelligence = Random.Range(1, 100);
        fitness = Random.Range(1, 100);
        looks = Random.Range(1, 100);
        happiness = Random.Range(1, 100);
        UpdateSliders();
    }

    public void UpdateSliders(){
        intelligenceBar.value = intelligence;
        intelligenceVal.text = intelligence.ToString();
        fitnessBar.value = fitness;
        fitnessVal.text = fitness.ToString();
        looksBar.value = looks;
        looksVal.text = looks.ToString();
        happinessBar.value = happiness;
        happinessVal.text = happiness.ToString();
    }

    //Adds one to age and year every time you age up
    public void AgeUp(){
        happiness += myFun.yearlyHappiness;
        myBank.LoanInterestSystem();
        age += 1;
        year += 1;
        money += salary - (salary * taxRate);
        savingsAccount *= 1.1f;
        eventText.text += "\nAge " + age + ": ";
        if (age == 13)
        {
            myRandom.RandomScenario();
        }
        UpdateSliders();
        UpdateTexts();
    }

    //Updates texts in character panel
    public void UpdateTexts(){
        nameText.text = "Name: " + name;
        ageText.text = "Age: " + age;
        moneyText.text = "Money: $" + money;
        yearText.text = "Year: " + year;
        salaryText.text = "Salary: $" + salary;
        jobTitleText.text = "Job Title: " + jobTitle;
        moneyTextMS.text = "$" + money;
        savingsAccountText.text = "$" + savingsAccount;
        myBank.amountInSavingsText.text = "$" + savingsAccount;
        myBank.cashAmountText.text = "$" + money;
    }
}
