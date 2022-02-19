using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pickup : MonoBehaviour
{
    Item item;
    PlayerInventory playerInventory;
    private void Start()
    {
        item = GetComponent<Item>();
       
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if(other.tag == "Player")
        {
            
            playerInventory = other.GetComponent<PlayerInventory>();
            if(playerInventory != null)
            {
                Debug.Log("Add to Inventory");
                playerInventory.AddItem(item.name, item.index, item.sprite);
            }

            Destroy(this.gameObject);
            
        }
    }
}
