using System.Collections;
using System.Collections.Generic;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;
using static GameManager;

public class Rama : MonoBehaviour, ICollectable
{

    public Animator _animator;
    public GameObject coin;
     public void OnCollected()
    {
        GameManager.gameManager.CoinCollected(1);
        StartCoroutine(WaitAnimation());
    }


    private IEnumerator WaitAnimation()
    {
        _animator.SetTrigger("Trigger");
        coin.gameObject.SetActive(true);
        yield return new WaitForSeconds(1.5f);
        Destroy(gameObject);
    }
}