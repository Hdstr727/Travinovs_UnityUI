using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HeadChanger : MonoBehaviour {
    public GameObject headObject;
    public Image[] headImages;
    public int currentHeadIndex = 0;
    public Text currentHeadText;

    public void SetPreviousHead()
    {
        currentHeadIndex--;
        if (currentHeadIndex < 0)
        {
            currentHeadIndex = headImages.Length - 1;
        }
        SetHeadImage();
    }

    public void SetNextHead()
    {
        currentHeadIndex++;
        if (currentHeadIndex >= headImages.Length)
        {
            currentHeadIndex = 0;
        }
        SetHeadImage();
    }

    void SetHeadImage()
    {
        Image currentHeadImage = headImages[currentHeadIndex];
        headObject.GetComponent<Image>().sprite = currentHeadImage.sprite;

        if (currentHeadImage.name == "ķivere")
        {
            headObject.transform.localPosition = new Vector3(-4, 98, 0);
        }
        else
        {
            headObject.transform.localPosition = new Vector3(-14, 98, 0);
        }

        currentHeadText.text = currentHeadImage.name;
    }
}

