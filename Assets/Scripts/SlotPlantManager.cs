using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SlotPlantManager : MonoBehaviour
{
    public Transform slotPos;
    void Start()
    {
        
    }

    public void PlantItem(GameObject obj)
    {
        string nameObj = "Plant" + obj.name;

        GameObject newPlant = GameObject.Find(nameObj);
        if(newPlant != null)
        {
            Debug.Log("Mover Planta a Slot");
            SpriteRenderer spr = newPlant.transform.GetComponent<SpriteRenderer>();
            newPlant.transform.parent = slotPos.transform;
            newPlant.transform.position = slotPos.transform.position;
            
            spr.enabled = true;
        }
    }

    public void checkSlots()
    {
        foreach (Transform child in transform)
        {
            if(child.name != "")
            {
                Debug.Log(child.name);
            }
            
        }
    }
}
