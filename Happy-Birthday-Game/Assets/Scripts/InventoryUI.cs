using UnityEngine;
using TMPro;
public class InventoryUI : MonoBehaviour
{
    private TextMeshProUGUI cakeIngrediantText;


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        cakeIngrediantText = GetComponent<TextMeshProUGUI>();  
    }
    public void UpdateCakeIngrediantText(PlayerInventory playerInventory)
    {
        cakeIngrediantText.text = playerInventory.NumberOfCakeIngrediants.ToString(); 
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
