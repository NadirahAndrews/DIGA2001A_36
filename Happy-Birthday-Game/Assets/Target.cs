using UnityEngine;

public class Door : MonoBehaviour
{
    public float strength = 10f;
    public void Swing(float value)
    {
        strength -= value;
    }

}
