using UnityEngine;

public class Item : MonoBehaviour
{
    public string itemName = "Item Name";

    public void Collect()
    {
        Debug.Log(itemName + " collected!");

        Destroy(gameObject);
    }
}