using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollectibleItem : MonoBehaviour
{
    public GameObject coin;
    [SerializeField] string itemName;
    void OnTriggerEnter(Collider other)
    {
        Managers.Inventory.AddItem(itemName);

        if (other.gameObject.tag == "Player2") {

            Managers.Player.IncreaseScore(1);
        }
        
        Destroy(this.gameObject);
        Vector3 randomPosition = new Vector3(Random.Range(-4, 4), 1, Random.Range(-4, 4));
        Instantiate(coin, randomPosition, Quaternion.identity);
    }
}   

