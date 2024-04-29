using UnityEngine;

public class Adrenaline : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            other.GetComponent<PScoreSystem>().TakeAdrenaline();
        }
    }
}