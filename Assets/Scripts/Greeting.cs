using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using UnityEngine;
using UnityEngine.UI;

public class Greeting : MonoBehaviour
{
    private string Name;
    private int Age;

    public GameObject InputFieldName;
    public GameObject InputFieldAge;
    public GameObject ShowText;

    private void Start()
    {
        
        InputFieldName.GetComponent<InputField>().onValidateInput += ValidateNameInput;
        InputFieldAge.GetComponent<InputField>().onValidateInput += ValidateAgeInput;
    }

    public void SaveText()
    {
        Name = InputFieldName.GetComponent<InputField>().text;
        Age = int.Parse(InputFieldAge.GetComponent<InputField>().text);

        string str = "Sveiki! Es esmu " + Name + " man ir " + Age + " gadi!";
        ShowText.GetComponent<Text>().text = str;
    }

    private char ValidateNameInput(string text, int charIndex, char addedChar)
    {
        
        if (char.IsLetter(addedChar) || addedChar == ' ')
        {
            return addedChar;
        }
        else
        {
            return '\0';
        }
    }

    private char ValidateAgeInput(string text, int charIndex, char addedChar)
    {
        
        if (char.IsDigit(addedChar))
        {
            return addedChar;
        }
        else
        {
            return '\0';
        }
    }
}