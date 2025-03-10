using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Cinemachine;
using StarterAssets;

public class Seller : MonoBehaviour
{
    public GameObject Shop_UI;
    private PlayerMover PlayerMover;
    private bool _canBuy = true;
    private float time = 1f;
    // private StarterAssetsInputs SAI;
    // public bool cursorActive = false;
    void Awake()
    {
     // SAI = FindAnyObjectByType<StarterAssetsInputs>();  
    }

    private void OnTriggerEnter(Collider other)
    {
                
        //Cursor.visible = true;
       // cursorActive = true;
        // SAI.cursorLocked=false;

        if(_canBuy)
        {
            PlayerMover = other.GetComponent<PlayerMover>();
            PlayerMover.canMove = false;
            Shop_UI.SetActive(true);
            _canBuy = false;
        }
    }

    private void OnTriggerExit(Collider other)
    {
        StartCoroutine(WaitForABit());
    }


    public void ExitStore ()
    {
        PlayerMover.canMove = true;
        Shop_UI.SetActive(false);
      //  SAI.cursorLocked = true;

    }    

    private IEnumerator WaitForABit()
    {
        yield return new WaitForSeconds(time);
        _canBuy = true;
    }    
}
