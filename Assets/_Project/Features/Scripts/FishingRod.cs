using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "Items/FishingRod")]
public class FishingRod : Item
{
    public override void Use() {
 
    }

    public override Item getItem(){ return this; }
    public override FishingRod getFishingRod() { return this; }
    public override Fish getFish() { return null; }
    public override Furniture getFurniture() { return null; }
}
