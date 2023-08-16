using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class AccessoryColor : MonoBehaviour
{
   public GameObject panel;

   [SerializeField] private Image aone, atwo, athree, afour, afive, asix, aseven, aeight;

   public Image squareHeadDisplay;

   [SerializeField] private Color cone, ctwo, cthree, cfour, cfive, csix, cseven, ceight;

   private void Start()
   {
        cone.a = 1;
        ctwo.a = 2;
        cthree.a = 3;
        cfour.a = 4;
        cfive.a = 5;
        csix.a = 6;
        cseven.a = 7;
        ceight.a = 8;
   }

   public void OpenPanel()
   {
        panel.SetActive(true);
   }

   public void ClosedPanel()
   {
        panel.SetActive(false);
   }

   public void ChangeAOne()
   {
        aone.color = cone;
        atwo.color = cone;
        athree.color = cone;
        afour.color = cone;
        afive.color = cone;
        asix.color = cone;
        aseven.color = cone;
        aeight.color = cone;
   }

   public void ChangeATwo()
   {
        aone.color = ctwo;
        atwo.color = ctwo;
        athree.color = ctwo;
        afour.color = ctwo;
        afive.color = ctwo;
        asix.color = ctwo;
        aseven.color = ctwo;
        aeight.color = ctwo;
   }

   public void ChangeAThree()
   {
        aone.color = cthree;
        atwo.color = cthree;
        athree.color = cthree;
        afour.color = cthree;
        afive.color = cthree;
        asix.color = cthree;
        aseven.color = cthree;
        aeight.color = cthree;
   }

   public void ChangeAFour()
   {
        aone.color = cfour;
        atwo.color = cfour;
        athree.color = cfour;
        afour.color = cfour;
        afive.color = cfour;
        asix.color = cfour;
        aseven.color = cfour;
        aeight.color = cfour;
   }

   public void ChangeAFive()
   {
        aone.color = cfive;
        atwo.color = cfive;
        athree.color = cfive;
        afour.color = cfive;
        afive.color = cfive;
        asix.color = cfive;
        aseven.color = cfive;
        aeight.color = cfive;
   }

   public void ChangeASix()
   {
        aone.color = csix;
        atwo.color = csix;
        athree.color = csix;
        afour.color = csix;
        afive.color = csix;
        asix.color = csix;
        aseven.color = csix;
        aeight.color = csix;
   }

   public void ChangeASeven()
   {
        aone.color = cseven;
        atwo.color = cseven;
        athree.color = cseven;
        afour.color = cseven;
        afive.color = cseven;
        asix.color = cseven;
        aseven.color = cseven;
        aeight.color = cseven;
   }

   public void ChangeAEight()
   {
        aone.color = ceight;
        atwo.color = ceight;
        athree.color = ceight;
        afour.color = ceight;
        afive.color = ceight;
        asix.color = ceight;
        aseven.color = ceight;
        aeight.color = ceight;
   }

   void Update()
   {
        squareHeadDisplay.color = aone.color;
   }
}
