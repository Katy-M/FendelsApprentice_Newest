﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class PopulateGrid : MonoBehaviour
{

    public GameObject item;     // prefab of the icon in the scroll area

    int counter;

    List<UiItem> allIcons;      // all icons at the top of the screen

    public ElementDictionary elements;


    // Use this for initialization
    void Start()
    {
        // for(int i=0;i<sprites.Length;i++)
        // {
        // 	GameObject temp= (GameObject)Instantiate(item,transform);
        // 	temp.GetComponent<Image>().sprite = sprites[i];
        // }

        for (int i = 0; i < elements.allElements.Count; i++)
        {
            // check if element is unlocked
            if (elements.allElements[i].active)
            {
                // add element to UI list
                GameObject temp = (GameObject)Instantiate(item, transform);

                temp.GetComponent<UiItem>().elementName = elements.allElements[i].elementName;
                temp.GetComponent<UiItem>().elementID = elements.allElements[i].elementID;
                temp.GetComponent<Image>().sprite = elements.allElements[i].icon;
            }
        }

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void AddItem(int elementIndex)
    {
        GameObject temp = (GameObject)Instantiate(item, transform);

        temp.GetComponent<UiItem>().elementName = elements.allElements[elementIndex].elementName;
        temp.GetComponent<UiItem>().elementID = elements.allElements[elementIndex].elementID;
        temp.GetComponent<Image>().sprite = elements.allElements[elementIndex].icon;
    }


}
