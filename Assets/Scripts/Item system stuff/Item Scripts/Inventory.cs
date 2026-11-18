using System.Diagnostics.Contracts;
using UnityEngine;

// Following Youtube tutorial https://youtu.be/pmBv0Cagx_o Created by: Game Dev Beginner. Accessed 14/11/2026
public class Inventory : MonoBehaviour
{
    public Item[] items = new Item[10];
}
 public enum Item
{
    Empty,
    Crate,
    //Sword
    Chest,
    //Key
    Barrel,
    //Potion

}


