using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Zenject;

public class EnemyScript : MonoBehaviour
{
    [SerializeField] int playerValuePlus;
    [Inject] private PlayerScript playerScript;
    void Update()
    {
        plusValue(); 
    }

    void plusValue()
    {
        if (Input.GetKeyDown(KeyCode.W))
        {
            playerValuePlus += playerScript.playerValue;
        }
    }
}
