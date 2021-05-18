using System.Collections;
using System.Collections.Generic;
using UnityEngine;




public abstract class Pickupable : MonoBehaviour
{

    public AudioSource m_IdleAudio ;
    public AudioSource m_CollectAudio ;
    /// <summary>
    /// Classes that extends from this
    /// can specify their logic here.
    /// </summary>
    protected abstract IEnumerator Pickup();

    /// <summary>
    /// This function can be called from
    /// the player to pickup this object.
    /// </summary>
    public void PickupObject()
    {
        StartCoroutine(DoPickup());
        
    }

    IEnumerator DoPickup()
    {
        m_IdleAudio.Stop();
        m_CollectAudio.Play();

        while (m_CollectAudio.isPlaying)
            yield return new WaitForEndOfFrame();

        yield return Pickup();
        Destroy(gameObject);
    }
}
