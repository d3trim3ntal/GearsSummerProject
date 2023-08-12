using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class ControlColor : MonoBehaviour
{
    public GameObject panel;

    [SerializeField] private Image head, leftArm, rightArm, body, legs;

    public Image squareHeadDisplay;

    [SerializeField] private Color colorOne, colorTwo, colorThree, colorFour;

    private void Start()
    {
        colorOne.a = 1;
        colorTwo.a = 2;
        colorThree.a = 3;
        colorFour.a = 4;
    }

    public void OpenPanel()
    {
        panel.SetActive(true);
    }

    public void ClosedPanel()
    {
        panel.SetActive(false);
    }

    public void ChangeSkinOne()
    {
        head.color = colorOne;
        leftArm.color = colorOne;
        rightArm.color = colorOne;
        body.color = colorOne;
        legs.color = colorOne;
    }

    public void ChangeSkinTwo()
    {
        head.color = colorTwo;
        leftArm.color = colorTwo;
        rightArm.color = colorTwo;
        body.color = colorTwo;
        legs.color = colorTwo;
    }

    public void ChangeSkinThree()
    {
        head.color = colorThree;
        leftArm.color = colorThree;
        rightArm.color = colorThree;
        body.color = colorThree;
        legs.color = colorThree;
    }

    public void ChangeSkinFour()
    {
        head.color = colorFour;
        leftArm.color = colorFour;
        rightArm.color = colorFour;
        body.color = colorFour;
        legs.color = colorFour;
    }

    void Update()
    {
        squareHeadDisplay.color = head.color;
    }

}
