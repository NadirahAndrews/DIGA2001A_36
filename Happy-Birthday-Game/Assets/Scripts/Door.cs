using UnityEngine;
// Reference: https://youtu.be/gx1Drc5Qx5g?si=YS7qGVrlpjy8ggqz

public class Door : MonoBehaviour
{
    public float strength = 1f;
    public void Swing(float value)
    {
        strength -= value;
        if (strength <= 0)
        {
            Close();
        }
    }
    void Close()
    {
        Destroy(gameObject);
    }
}
