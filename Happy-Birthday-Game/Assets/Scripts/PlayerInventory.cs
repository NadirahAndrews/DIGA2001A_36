using UnityEngine;
//Refernce: Unity3D (2023) How to Collect Items (Unity Tutorial). 15 March. Available at: https://youtu.be/EfUCEwKmcjc (Accessed: 18 August 2025).
public class PlayerInventory: MonoBehaviour
{
    public int NumberofCakeIngrediants { get; private set; }

    public void CakeIngrediantCollected()
    {
        NumberofCakeIngrediants++;
    }
}
