using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMProUGUI;


public class Manager : MonoBehaviour
{
    public Text Result;
    public Image AiChoice;
    public string[] Choices;
    public Sprite Rock, Paper, Scissors;
    public void Play(string myChoice)
    { string randomChoice = Choices[Random.Range(0, Choices.Length)];
        switch (randomChoice)
        {
            case "Rock":
                switch (myChoice)
                {
                    case "Rock":
                        Result.text = "tie ";
                        break;
                    case "Paper":
                        Result.text = "lose ";
                        break;
                    case "Scissor":
                        Result.text = "win ";
                        break;
                }
                AiChoice.sprite = Rock;
                break;
            case "Paper":
                AiChoice.sprite = Paper;
                switch (myChoice)
                {
                    case "Rock":
                        Result.text = "win";
                        break;
                    case "Paper":
                        Result.text = "tie ";
                        break;
                    case "Scissor":
                        Result.text = "lose";
                        break;
                }
                break;
            case "Scissor":
                AiChoice.sprite = Scissors;
                switch (myChoice)
                {
                    case "Rock":
                        Result.text = "lose";
                        break;
                    case "Paper":
                        Result.text = "win";
                        break;
                    case "Scissor":
                        Result.text = "tie";
                        break;
                }
                break;
        }
    }
   
}




