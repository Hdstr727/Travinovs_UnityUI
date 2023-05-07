using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class WeaponChanger : MonoBehaviour {

    public GameObject WeaponObject;
    public Image[] WeaponImages;
    public int currentIndex = 0;
    public Text currentWeaponText;
    public void SetPreviousWeapon()
    {
        currentIndex--;
        if (currentIndex < 0)
        {
            currentIndex = WeaponImages.Length - 1;
        }
        SetImages();

    }

    public void SetNextWeapon()
    {
        currentIndex++;
        if (currentIndex >= WeaponImages.Length)
        {
            currentIndex = 0;
        }
        SetImages();
    }
    public void SetImages()
    {
        Image currentWeaponImage = WeaponImages[currentIndex];
        WeaponObject.GetComponent<Image>().sprite = currentWeaponImage.sprite;

        if (currentWeaponImage.name == "katana")
        {
            WeaponObject.transform.localPosition = new Vector3(-106, 22, -4);
            WeaponObject.GetComponent<RectTransform>().sizeDelta = new Vector2(19, 188);
            WeaponObject.transform.rotation = Quaternion.Euler(-5f, -4f, -297f);
        }
        else if (currentWeaponImage.name == "nūja")
        {
            WeaponObject.transform.localPosition = new Vector3(-66, 39, -5);
            WeaponObject.GetComponent<RectTransform>().sizeDelta = new Vector2(23, 148);
            WeaponObject.transform.rotation = Quaternion.Euler(1f, 3f, -330f);
        }
        else
        {
            WeaponObject.transform.localPosition = new Vector3(-51, -21, 3);
            WeaponObject.GetComponent<RectTransform>().sizeDelta = new Vector2(50, 233);
            WeaponObject.transform.rotation = Quaternion.Euler(-5f, -4f, -270f);
        }
       
        currentWeaponText.text = currentWeaponImage.name;
    }
}
