using System.Collections;
using System.Collections.Generic;
using UnityEditor.Experimental.GraphView;
using UnityEngine;
using UnityEngine.Events;

public class PlayerInventory : MonoBehaviour

{
    public int NumdeLixos { get; set; }
    public int contadorlixos;

    public UnityEvent<PlayerInventory> OnlixoColetado;

    public bool canCollect = true;

    public void lixoColetado()
    {
        

        if ((canCollect && NumdeLixos < 10) || (NumdeLixos == 0))
        {

            NumdeLixos++;
            OnlixoColetado.Invoke(this);
            contadorlixos = +NumdeLixos;
            Debug.Log(contadorlixos);

            if (NumdeLixos >= 10)
            {
                canCollect = false;
                Debug.Log("O player não consegue mais coletar");
            }
        }
        else
        {


        }
    }
}
