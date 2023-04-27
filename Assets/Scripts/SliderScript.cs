using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SliderScript : MonoBehaviour {

    public GameObject HeightSlider;
    public GameObject WidthSlider;
    public GameObject Character;

    public void ChangeHeight()
    {
        float CurrentHeight = HeightSlider.GetComponent<Slider>().value;
        Character.transform.localScale = new Vector2(1, 1f * CurrentHeight);
    }

    public void ChangeWidth()
    {
        float CurrentWidth = WidthSlider.GetComponent<Slider>().value;
        Character.transform.localScale = new Vector2(1f * CurrentWidth, 1);
    }
}
