using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class DespejoLixo : MonoBehaviour
{
    GameObject player;
    bool Zona = false;
    private MensagemLimit messageController;
    private TextMeshProUGUI lixoText;   
    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.FindGameObjectWithTag("barco");
            
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("barco"))
        {
            Zona = true;
        }
    }
    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("barco"))
        {
            Zona = false;
        }
    }

    // Update is called once per frame
    void Update()
    {
        if(Zona & Input.GetKeyDown(KeyCode.E))
        {
        if (player.GetComponent<PlayerInventory>().NumdeLixos >=10)
            {
                player.GetComponent<PlayerInventory>().NumdeLixos -= 10;
                lixoText.text = GetComponent<PlayerInventory>().NumdeLixos.ToString();

            }
        }
        if(player.GetComponent<PlayerInventory>().NumdeLixos < 10)
        {
           
        }
    }
}
