using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEditor.Experimental.GraphView;
using UnityEngine;



public class getObject : MonoBehaviour
{
    private MensagemLimit messageController;

    private void Start()
    {
     messageController = FindObjectOfType<MensagemLimit>();
    }
    void OnTriggerEnter(Collider other)
    {
        PlayerInventory playerInventory = other.GetComponent<PlayerInventory>();

        if (playerInventory != null && playerInventory.NumdeLixos < 10)
        {
            playerInventory.lixoColetado();
            gameObject.SetActive(false);
            

            }
        else
        {

            Collider lixoCollider = GetComponent<Collider>();
            if (lixoCollider != null)
            {
                lixoCollider.enabled = false;
            }
           
            if (messageController != null )
            {
                messageController.ShowMessage("Você nao pode pegar seu arrombado!!!");
            }

        }
        }
    private void OnTriggerExit(Collider other)
    {
        if (messageController != null)
        {
            messageController.HideMessage();

        }
    }
}


    /*void OnTriggerEnter(Collider other)
    {

        // Ao colidir com um objeto, tenta agarrá-lo
        Debug.Log("passei aqui");
        if (other.gameObject.tag == "barco")




            Destroy(this.gameObject);








        }
    */



