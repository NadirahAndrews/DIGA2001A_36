using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//Reference: Unity3D (2023) How to Collect Items (Unity Tutorial). 15 March. Available at: https://youtu.be/EfUCEwKmcjc (Accessed: 14 August 2025).
public class PlayerInventory : MonoBehaviour
{
    public int NumberOfCakeIngrediants { get; private set; }

    public void CakeIngrediantCollected()
    {
        NumberOfCakeIngrediants++;
    }



}
