using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class HairColorController : MonoBehaviour
{
   public GameObject panel;

   [SerializeField] private Image hone, htwo, hthree, hfour, hfive, hsix, hseven, height, hnine, hten;

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

   public void ChangeHairOne()
   {
        hone.color = cone;
        htwo.color = cone;
        hthree.color = cone;
        hfour.color = cone;
        hfive.color = cone;
        hsix.color = cone;
        hseven.color = cone;
        height.color = cone;
        hnine.color = cone;
        hten.color = cone;
   }

   public void ChangeHairTwo()
   {
        hone.color = ctwo;
        htwo.color = ctwo;
        hthree.color = ctwo;
        hfour.color = ctwo;
        hfive.color = ctwo;
        hsix.color = ctwo;
        hseven.color = ctwo;
        height.color = ctwo;
        hnine.color = ctwo;
        hten.color = ctwo;
   }

   public void ChangeHairThree()
   {
        hone.color = cthree;
        htwo.color = cthree;
        hthree.color = cthree;
        hfour.color = cthree;
        hfive.color = cthree;
        hsix.color = cthree;
        hseven.color = cthree;
        height.color = cthree;
        hnine.color = cthree;
        hten.color = cthree;
   }

   public void ChangeHairFour()
   {
        hone.color = cfour;
        htwo.color = cfour;
        hthree.color = cfour;
        hfour.color = cfour;
        hfive.color = cfour;
        hsix.color = cfour;
        hseven.color = cfour;
        height.color = cfour;
        hnine.color = cfour;
        hten.color = cfour;
   }

   public void ChangeHairFive()
   {
        hone.color = cfive;
        htwo.color = cfive;
        hthree.color = cfive;
        hfour.color = cfive;
        hfive.color = cfive;
        hsix.color = cfive;
        hseven.color = cfive;
        height.color = cfive;
        hnine.color = cfive;
        hten.color = cfive;
   }

   public void ChangeHairSix()
   {
        hone.color = csix;
        htwo.color = csix;
        hthree.color = csix;
        hfour.color = csix;
        hfive.color = csix;
        hsix.color = csix;
        hseven.color = csix;
        height.color = csix;
        hnine.color = csix;
        hten.color = csix;
   }

   public void ChangeHairSeven()
   {
        hone.color = cseven;
        htwo.color = cseven;
        hthree.color = cseven;
        hfour.color = cseven;
        hfive.color = cseven;
        hsix.color = cseven;
        hseven.color = cseven;
        height.color = cseven;
        hnine.color = cseven;
        hten.color = cseven;
   }

   public void ChangeHairEight()
   {
        hone.color = ceight;
        htwo.color = ceight;
        hthree.color = ceight;
        hfour.color = ceight;
        hfive.color = ceight;
        hsix.color = ceight;
        hseven.color = ceight;
        height.color = ceight;
        hnine.color = ceight;
        hten.color = ceight;
   }

   void Update()
   {
        squareHeadDisplay.color = hone.color;
   }
}
