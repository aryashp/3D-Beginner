using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LemonPickupable : Pickupable
{
    protected override IEnumerator Pickup() 
    {
        yield return 1;    
    }
}
