using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Bank : MonoBehaviour
{
    public Character myCharacter;

    public float loanInterest = 1.3f;
    public int totalLoanAmount;
    public int yearLoanTaken;
    public float loanRepaymentCost;
    public bool loanTaken = false;

    public GameObject loanTakenPopUp;
    public GameObject loanInfoPopUp;

    public Text amountInSavingsText;
    public Text cashAmountText;
    public Dropdown loanAmount;

    public InputField enterAmount;

    //Takes loan based on the chosen option
    public void TakeLoan(){
        if (loanTaken == false){
            if (loanAmount.value == 0){
                totalLoanAmount = 50000;
            } else if (loanAmount.value == 1){
                totalLoanAmount = 100000;
            } else if (loanAmount.value == 2){
                totalLoanAmount = 250000;
            } 
            yearLoanTaken = myCharacter.year;
            myCharacter.money += totalLoanAmount;
            loanTaken = true;
            loanRepaymentCost = totalLoanAmount;
            myCharacter.UpdateTexts();
            loanInfoPopUp.SetActive(true);
        } else{
            loanTakenPopUp.SetActive(true);
        }
    }

    public void DepositAmount(){
        float amount = int.Parse(enterAmount.text);
        myCharacter.savingsAccount += amount;
        myCharacter.money -= amount;
        myCharacter.UpdateTexts();
    }

    public void DepositAllBank(){
        myCharacter.savingsAccount += myCharacter.money;
        myCharacter.money -= myCharacter.money;
        myCharacter.UpdateTexts();
    }

    public void WithdrawAllBank(){
        myCharacter.money += myCharacter.savingsAccount;
        myCharacter.savingsAccount -= myCharacter.savingsAccount;
        myCharacter.UpdateTexts();
    }

    public void WithdrawAmount(){
        float amount = int.Parse(enterAmount.text);
        myCharacter.money += amount;
        myCharacter.savingsAccount -= amount;
        myCharacter.UpdateTexts();
    }

    public void LoanInterestSystem(){
        loanRepaymentCost *= loanInterest;
        if (myCharacter.year == yearLoanTaken + 4){
            myCharacter.money -= loanRepaymentCost;
            loanTaken = false;
            totalLoanAmount = 0;
            loanRepaymentCost = 0;
        }
    }

    void Start(){
        loanTakenPopUp.SetActive(false);
        loanInfoPopUp.SetActive(false);
    }
}
