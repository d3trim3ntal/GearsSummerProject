using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class BottomsAndShoes : MonoBehaviour
{
 public GameObject panel;

   [SerializeField] private Image fone, ftwo, fthree, ffour, ffive, fsix, fseven, feight, fnine, ften, feleven, ftwelve;

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

   public void ChangeFitOne()
   {
        fone.color = cone;
        ftwo.color = cone;
        fthree.color = cone;
        ffour.color = cone;
        ffive.color = cone;
        fsix.color = cone;
        fseven.color = cone;
        feight.color = cone;
        fnine.color = cone;
        ften.color = cone;
        feleven.color = cone;
        ftwelve.color = cone;
   }

   public void ChangeFitTwo()
   {
        fone.color = ctwo;
        ftwo.color = ctwo;
        fthree.color = ctwo;
        ffour.color = ctwo;
        ffive.color = ctwo;
        fsix.color = ctwo;
        fseven.color = ctwo;
        feight.color = ctwo;
        fnine.color = ctwo;
        ften.color = ctwo;
        feleven.color = ctwo;
        ftwelve.color = ctwo;
   }

   public void ChangeFitThree()
   {
        fone.color = cthree;
        ftwo.color = cthree;
        fthree.color = cthree;
        ffour.color = cthree;
        ffive.color = cthree;
        fsix.color = cthree;
        fseven.color = cthree;
        feight.color = cthree;
        fnine.color = cthree;
        ften.color = cthree;
        feleven.color = cthree;
        ftwelve.color = cthree;
   }

   public void ChangeFitFour()
   {
        fone.color = cfour;
        ftwo.color = cfour;
        fthree.color = cfour;
        ffour.color = cfour;
        ffive.color = cfour;
        fsix.color = cfour;
        fseven.color = cfour;
        feight.color = cfour;
        fnine.color = cfour;
        ften.color = cfour;
        feleven.color = cfour;
        ftwelve.color = cfour;
   }

   public void ChangeFitFive()
   {
        fone.color = cfive;
        ftwo.color = cfive;
        fthree.color = cfive;
        ffour.color = cfive;
        ffive.color = cfive;
        fsix.color = cfive;
        fseven.color = cfive;
        feight.color = cfive;
        fnine.color = cfive;
        ften.color = cfive;
        feleven.color = cfive;
        ftwelve.color = cfive;
   }

   public void ChangeFitSix()
   {
        fone.color = csix;
        ftwo.color = csix;
        fthree.color = csix;
        ffour.color = csix;
        ffive.color = csix;
        fsix.color = csix;
        fseven.color = csix;
        feight.color = csix;
        fnine.color = csix;
        ften.color = csix;
        feleven.color = csix;
        ftwelve.color = csix;
   }

   public void ChangeFitSeven()
   {
        fone.color = cseven;
        ftwo.color = cseven;
        fthree.color = cseven;
        ffour.color = cseven;
        ffive.color = cseven;
        fsix.color = cseven;
        fseven.color = cseven;
        feight.color = cseven;
        fnine.color = cseven;
        ften.color = cseven;
        feleven.color = cseven;
        ftwelve.color = cseven;
   }

   public void ChangeFitEight()
   {
        fone.color = ceight;
        ftwo.color = ceight;
        fthree.color = ceight;
        ffour.color = ceight;
        ffive.color = ceight;
        fsix.color = ceight;
        fseven.color = ceight;
        feight.color = ceight;
        fnine.color = ceight;
        ften.color = ceight;
        feleven.color = ceight;
        ftwelve.color = ceight;
   }

   void Update()
   {
        squareHeadDisplay.color = fone.color;
   }
}
