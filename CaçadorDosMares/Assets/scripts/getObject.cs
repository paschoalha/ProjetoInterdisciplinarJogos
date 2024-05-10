using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEditor.Experimental.GraphView;
using UnityEngine;



public class getObject : MonoBehaviour
{
   


    private MensagemLimit messageController;
    private PlayerInventory playerInventory;
    

    private void Start()
    {
        messageController = FindObjectOfType<MensagemLimit>();
    }

    void OnTriggerEnter(Collider other)
    {
        playerInventory = other.GetComponent<PlayerInventory>();

        if (playerInventory != null)
        {
            if (playerInventory.NumdeLixos < 10)
            {
                playerInventory.lixoColetado();
                gameObject.SetActive(false);
                Invoke(nameof(Respawn), 60f); ;
                gameObject.GetComponent<SphereCollider>().enabled = false;
            
            }   
            else
            {
                
                gameObject.GetComponent<Collider>().enabled = false;
               
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

    void OnTriggerStay(Collider other)
    {
        // Se o jogador já atingiu o limite, exibe a mensagem toda vez que ele passar sobre o objeto
        
            if (playerInventory.NumdeLixos == 10)
            {
                
                messageController.ShowMessage("Você já coletou 10 lixos!");
            }
          
        
        // Se o jogador não atingiu o limite e o inventário é válido, garanta que a mensagem esteja oculta
       
    }


    
    private void Respawn()
    {
        gameObject.SetActive(true);
        gameObject.GetComponent<SphereCollider>().enabled = true;
    }
}




