using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using UnityEngine;
using UnityEngine.UI;
public class Greeting : MonoBehaviour
{

    private string Name;
    private string Age;

    public GameObject InputFieldName;
    public GameObject InputFieldAge;
    public GameObject ShowText;


    public void SaveText()
    {
        InputField InputName = InputFieldName.GetComponent<InputField>();
        InputField InputAge = InputFieldAge.GetComponent<InputField>();
        
        Name = InputFieldName.GetComponent<Text>().text;
        Age = InputFieldAge.GetComponent<Text>().text;
        string str = "Sveiki! Es esmu " + Name + " man ir " + Age + " gadi!";
        ShowText.GetComponent<Text>().text = str;

        


    }
}