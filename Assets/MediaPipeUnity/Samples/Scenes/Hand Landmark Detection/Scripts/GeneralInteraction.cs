using UnityEngine;

public class GeneralInteraction : MonoBehaviour
{
    public GameObject relatedFlag;
    private AudioSource nationalAnthem;
    private bool isTriggered = false;

    void Start()
    {
        nationalAnthem = GetComponent<AudioSource>();

        
        if (nationalAnthem != null)
        {
            nationalAnthem.Stop();
        }

        if (relatedFlag != null) relatedFlag.SetActive(false);
    }

    private void OnTriggerEnter(Collider other)
    {
        
        if (Time.timeSinceLevelLoad > 1.0f && !isTriggered)
        {
            if (other.gameObject.name.Contains("Hand") || other.CompareTag("Player"))
            {
                ActivateSymbol();
            }
        }
    }

    void ActivateSymbol()
    {
        isTriggered = true;
        if (relatedFlag != null) relatedFlag.SetActive(true);
        if (nationalAnthem != null) nationalAnthem.Play();

        Debug.Log(gameObject.name + " baþarýyla tetiklendi.");
    }
}