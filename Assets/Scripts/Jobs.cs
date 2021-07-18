using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class Jobs : MonoBehaviour
{
    public Character myCharacter;

    public GameObject[] PossibleJobPanel;
    public Button[] takeJobButtons;

    string[] possibleJobTitles = {"Programmer", "Cop", "Dentist", "Doctor", "Plumber", "Bus Driver", "Painter", "Writer"};
    public Text[] possibleJobTitleTexts;
    public Text[] possibleJobSalaryTexts;

    public List<string> jobTitle;
    public List<int> jobSalary;

    public int index;
    public Slider workPerformanceSlider;
    public Text workPerformanceText;
    public Text jobInfoText;

    void Start()
    {
        GenerateJobs();
    }
    
    public void TakeJob(){
        string name = EventSystem.current.currentSelectedGameObject.name;
        if (name == "TakeJobButton"){
            index = 0;
        } else if (name == "TakeJobButton(1)"){
            index = 1;
        } else if (name == "TakeJobButton(2)"){
            index = 2;
        } else if (name == "TakeJobButton(3)"){
            index = 3;
        } else if (name == "TakeJobButton(4)"){
            index = 4;
        }
        myCharacter.jobTitle = jobTitle[index];
        myCharacter.salary = jobSalary[index];
        workPerformanceSlider.value = 50;
        WorkPerformanceUpdater();
        myCharacter.UpdateTexts();
    }
    
    public void GenerateJobs(){
        int i = 0;
        string checker;
        int neededJobs = 5;
        int doneShuffling = 0;
        foreach (string f in possibleJobTitles){
            if (doneShuffling < neededJobs){
                checker = possibleJobTitles[Random.Range(0, possibleJobTitles.Length - 1)];
                if (!jobTitle.Contains(checker)){
                    jobTitle.Add(checker);
                    doneShuffling++;
                } else {
                    continue;
                }
                if (checker == "Doctor"){
                jobSalary.Add(400000);
                } else if (checker == "Programmer"){
                    jobSalary.Add(100000);
                } else if (checker == "Plumber"){
                    jobSalary.Add(20000);
                } else if (checker == "Cop"){
                    jobSalary.Add(35000);
                } else if (checker == "Dentist"){
                    jobSalary.Add(300000);
                } else if (checker == "Bus Driver"){
                    jobSalary.Add(15000);
                } else if (checker == "Painter"){
                    jobSalary.Add(40000);
                } else if (checker == "Writer"){
                    jobSalary.Add(50000);
                }
            possibleJobTitleTexts[i].text = checker;
            possibleJobSalaryTexts[i].text = "Salary: $" + jobSalary[i];
            i++;
            } else {
                break;
            }
        }
    }

    public void WorkHarder(){
        workPerformanceSlider.value += 5;
        WorkPerformanceUpdater();
    }

    public void QuitJob(){
        myCharacter.jobTitle = "Unemployed";
        myCharacter.salary = 0;
        myCharacter.UpdateTexts();
    }

    public void WorkPerformanceUpdater(){
        workPerformanceText.text = workPerformanceSlider.value.ToString();
        jobInfoText.text = "Job: " + myCharacter.jobTitle + "\nSalary: $" + myCharacter.salary;
    }
}