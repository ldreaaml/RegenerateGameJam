using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlantSlot1 : MonoBehaviour
{
    //When the mouse hovers over the GameObject, it turns to this color (red)
    Color m_MouseOverColor = new Color32(0, 204, 204, 120);

    //This stores the GameObject’s original color
    Color m_OriginalColor;

    SpriteRenderer s_Renderer;

    InventoryUI inventoryUI;

    [SerializeField]
    bool slotEmpty = true;

    SlotPlantManager spManager;

    private void Start()
    {
        //Fetch the mesh renderer component from the GameObject
        s_Renderer = GetComponent<SpriteRenderer>();
        //Fetch the original color of the GameObject
        m_OriginalColor = s_Renderer.color;

        inventoryUI = GameObject.FindObjectOfType<InventoryUI>();

        spManager = GameObject.FindObjectOfType<SlotPlantManager>();

        if (inventoryUI == null)
        {
            Debug.Log("NOT INVENTORY UI!");
        }
    }

    void OnMouseOver()
    {
        //If your mouse hovers over the GameObject with the script attached, output this message
       
        s_Renderer.color = m_MouseOverColor;

    }

    void OnMouseExit()
    {
        // Reset the color of the GameObject back to normal
        s_Renderer.color = m_OriginalColor;
    
    }

    void OnMouseDown()
    {
        Debug.Log("Mouse is click GameObject.");
        spManager.slotPos = this.transform;
        OpenInventory();
    }

    void OpenInventory()
    {
        inventoryUI.ShowInventory();
    }
}
