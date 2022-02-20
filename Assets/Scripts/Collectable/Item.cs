using UnityEngine;
using System.Collections;
using System; //This allows the IComparable Interface


public class Item : MonoBehaviour
{
    public new string name;
    public int index;
    public Sprite sprite;

    private void Start()
    {
        sprite = GetComponent<SpriteRenderer>().sprite;
    }

    public Item(string newName, int newIndex, Sprite newSprite)
    {
        name = newName;
        index = newIndex;
        sprite = newSprite;
    }

   
}
