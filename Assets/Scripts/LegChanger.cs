using System.CodeDom;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LegChanger : MonoBehaviour {

    public GameObject LeftLegObject;
    public GameObject RightLegObject;
    public Image[] LeftLegImages;
    public Image[] RightLegImages;
    public int currentIndex = 0;
    public Text currentLegsText;

    public void SetPreviousLegs()
    {
        currentIndex--;
        if (currentIndex < 0)
        {
            currentIndex = LeftLegImages.Length - 1;
        }
        SetImages();

    }

    public void SetNextLegs()
    {
        currentIndex++;
        if (currentIndex >= LeftLegImages.Length)
        {
            currentIndex = 0;
        }
        SetImages();
    }
    public void SetImages()
    {
        Image currentLeftLegImage = LeftLegImages[currentIndex];
        LeftLegObject.GetComponent<Image>().sprite = currentLeftLegImage.sprite;

        Image currentRightLegImage = RightLegImages[currentIndex];
        RightLegObject.GetComponent<Image>().sprite = currentRightLegImage.sprite;

        currentLegsText.text = currentLeftLegImage.name;
    }
}
