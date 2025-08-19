
using UnityEngine;

public class NPC : MonoBehaviour, IInteractable 
{
    [SerializeField] private string npcName = "NPC";
    [TextArea][SerializeField] private string dialogueLine = "I heard you're the party planner! I've got something you'll need, here's some pollen for the cake!";

    public GameObject interactionKey; 


    public void Interact()
    {
       DialogueUI.Instance.ShowDialogue(dialogueLine);
    }

    //void OnTriggerEnter(Collider other)
    //{
    //    if (other.CompareTag("Player"))
    //    {
    //        Debug.Log("Player is here");
    //        interactionKey.SetActive(true);
    //    }
    //}




}
