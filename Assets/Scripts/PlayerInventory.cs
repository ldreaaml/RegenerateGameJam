using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using System.Linq;



public class PlayerInventory : MonoBehaviour
{

    public delegate void OnItemChanged();
    public OnItemChanged onItemChangedCallback;

    public List<Sprite> sprites;

    public List<string> names;
    

    public void AddItem(string name, int value, Sprite sprite)
    {
        if (!names.Contains(name))
        {
            sprites.Add(sprite);
            names.Add(name);
        }
        

        if (onItemChangedCallback != null)
            onItemChangedCallback.Invoke();

    }


  

    

}
