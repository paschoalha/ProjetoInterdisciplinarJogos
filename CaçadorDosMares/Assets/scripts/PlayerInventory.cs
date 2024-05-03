using System.Collections;
using System.Collections.Generic;
using UnityEditor.Experimental.GraphView;
using UnityEngine;
using UnityEngine.Events;

public class PlayerInventory : MonoBehaviour

{
    public int NumdeLixos { get; private set; }

    public UnityEvent<PlayerInventory> OnlixoColetado;

    private bool canCollect = true;

    public void lixoColetado()
    {

        if (canCollect && NumdeLixos < 10)
        {
            NumdeLixos++;
            OnlixoColetado.Invoke(this);

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
