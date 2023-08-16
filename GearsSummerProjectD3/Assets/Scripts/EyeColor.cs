using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class EyeColor : MonoBehaviour
{
    public GameObject panel;

    [SerializeField] private Image eOne, eTwo, eThree, eFour;

    public Image squareHeadDisplay;

    [SerializeField] private Color colorOne, colorTwo, colorThree, colorFour, colorFive, colorSix, colorSeven, colorEight;

    private void Start()
    {
        colorOne.a = 1;
        colorTwo.a = 2;
        colorThree.a = 3;
        colorFour.a = 4;
        colorFive.a = 5;
        colorSix.a = 6;
        colorSeven.a = 7;
        colorEight.a = 8;
    }

    public void OpenPanel()
    {
        panel.SetActive(true);
    }

    public void ClosedPanel()
    {
        panel.SetActive(false);
    }

    public void ChangeEyesOne()
    {
        eOne.color = colorOne;
        eTwo.color = colorOne;
        eThree.color = colorOne;
        eFour.color = colorOne;
    }

    public void ChangeEyesTwo()
    {
        eOne.color = colorTwo;
        eTwo.color = colorTwo;
        eThree.color = colorTwo;
        eFour.color = colorTwo;
    }

    public void ChangeEyesThree()
    {
        eOne.color = colorThree;
        eTwo.color = colorThree;
        eThree.color = colorThree;
        eFour.color = colorThree;
    }

    public void ChangeEyesFour()
    {
        eOne.color = colorFour;
        eTwo.color = colorFour;
        eThree.color = colorFour;
        eFour.color = colorFour;
    }

    public void ChangeEyesFive()
    {
        eOne.color = colorFive;
        eTwo.color = colorFive;
        eThree.color = colorFive;
        eFour.color = colorFive;
    }

    public void ChangeEyesSix()
    {
        eOne.color = colorSix;
        eTwo.color = colorSix;
        eThree.color = colorSix;
        eFour.color = colorSix;
    }

    public void ChangeEyesSeven()
    {
        eOne.color = colorSeven;
        eTwo.color = colorSeven;
        eThree.color = colorSeven;
        eFour.color = colorSeven;
    }

    public void ChangeEyesEight()
    {
        eOne.color = colorEight;
        eTwo.color = colorEight;
        eThree.color = colorEight;
        eFour.color = colorEight;
    }

    void Update()
    {
        squareHeadDisplay.color = eOne.color;
    }
}
