using UnityEngine;
// Reference: https://youtu.be/gx1Drc5Qx5g?si=YS7qGVrlpjy8ggqz

public class Door : MonoBehaviour
{
    private Animator animator;
    private bool isOpen = false;
    private void Awake()
    {
        animator = GetComponent<Animator>();
    }
    public void Swing()
    {
        isOpen = !isOpen;
        animator.SetBool("IsOpen", isOpen);
    }
}
