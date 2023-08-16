using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class MouthChanger : MonoBehaviour
{
    public GameObject[] part;
    int index;
    
    // Start is called before the first frame update
    void Start()
    {
        index = 0;
    }

    // Update is called once per frame
    void Update()
    {
        if (index >= (part.Length - 1))
            index = 0 ;

        if (index < 0)
            index = index ;


        if(index == 0)
        {
            part[0].gameObject.SetActive(true);
        }
    }

    public void Next()
    {
        index += 1;

        for(int i = 0 ; i < part.Length; i++)
        {
            part[i].gameObject.SetActive(false);
            part[index].gameObject.SetActive(true);
        }
        
    }
}
