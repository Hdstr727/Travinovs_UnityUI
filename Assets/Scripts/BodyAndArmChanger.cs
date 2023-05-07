using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BodyAndArmChanger : MonoBehaviour {
    public GameObject BodyObject;
    public GameObject LeftArmObject;
    public GameObject RightArmObject;
    public Image[] BodyImages;
    public Image[] LeftArmImages;
    public Image[] RightArmImages;
    public int currentIndex = 0;
    public void SetPreviousBodyAndArms()
    {
        currentIndex--;
        if (currentIndex < 0)
        {
            currentIndex = BodyImages.Length - 1;
        }
        SetImages();

    }

    public void SetNextBodyAndArms()
    {
        currentIndex++;
        if (currentIndex >= BodyImages.Length)
        {
            currentIndex = 0;
        }
        SetImages();
    }
    public void SetImages()
    {
        Image currentBodyImage = BodyImages[currentIndex];
        BodyObject.GetComponent<Image>().sprite = currentBodyImage.sprite;

        Image currentLeftArmImage = LeftArmImages[currentIndex];
        LeftArmObject.GetComponent<Image>().sprite = currentLeftArmImage.sprite;

        Image currentRightArmImage = RightArmImages[currentIndex];
        RightArmObject.GetComponent<Image>().sprite = currentRightArmImage.sprite;

       
    }


}
