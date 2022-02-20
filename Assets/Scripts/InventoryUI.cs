using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class InventoryUI : MonoBehaviour
{
    PlayerInventory playerInventory;

    public GameObject pfSlotItem;
    public Transform itemsParentTransform;
    public GameObject inventoryUI;


    void Start()
    {
        playerInventory = GameObject.FindGameObjectWithTag("Player").GetComponent<PlayerInventory>();
        if(playerInventory == null)
        {
            Debug.Log("No playerInventory!");
        }
        playerInventory.onItemChangedCallback += UpdateUI;
    }


    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.I))
        {
            if (inventoryUI.activeSelf)
            {
                inventoryUI.SetActive(false);
            }
            else
            {
                inventoryUI.SetActive(true);
            }
            
        }
    }

    public void UpdateUI()
    {

        foreach (Transform child in itemsParentTransform.transform)
        {
            GameObject.Destroy(child.gameObject);
        } 


        for (int i = 0; i < playerInventory.names.Count; i++)
        {

            GameObject itemSlot = Instantiate(pfSlotItem, itemsParentTransform, false);

            itemSlot.name = playerInventory.names[i];
            Image sr = itemSlot.GetComponentInChildren<Image>();
            sr.sprite = playerInventory.sprites[i];

        }
        
    }
}
