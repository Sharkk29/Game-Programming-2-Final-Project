using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VillagerPop : MonoBehaviour
{
    public class DisappearOnTouch : MonoBehaviour

    {

        void OnCollisionEnter(Collision collision)

        {

            Destroy (this);
            print("Pop! Ahahahaha!");
        }

    }
}
