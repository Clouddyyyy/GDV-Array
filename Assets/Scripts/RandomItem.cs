
using System.Collections.Generic;
using UnityEngine;

public class RandomItem : MonoBehaviour
{
    
    [SerializeField] private List<string> items = new List<string>();
    

    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Return))PrintRandomItem();
        if(Input.GetKeyDown(KeyCode.Escape))PrintAllItems();
    }
    private void PrintRandomItem() {
        Debug.Log(items[Random.Range(0,9)]);

    }
    private void PrintAllItems() {
        //Printen van alle items
    }

}

