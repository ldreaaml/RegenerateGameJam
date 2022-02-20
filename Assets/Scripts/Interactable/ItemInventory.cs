using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemInventory : MonoBehaviour
{
    SlotPlantManager slotPlantManager;

    private void Start()
    {
        slotPlantManager = GameObject.FindObjectOfType<SlotPlantManager>();
    }
    public void GoToPlant()
    {
        slotPlantManager.PlantItem(this.gameObject);
    }
}
