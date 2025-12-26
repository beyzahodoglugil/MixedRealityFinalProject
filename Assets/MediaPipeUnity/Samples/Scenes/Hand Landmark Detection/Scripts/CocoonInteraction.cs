using UnityEngine;

public class CocoonInteraction : MonoBehaviour
{
    public GameObject relatedFlag; 
    private AudioSource nationalAnthem;
    private bool isTriggered = false;

    void Start()
    {
        nationalAnthem = GetComponent<AudioSource>();
        if (relatedFlag != null) relatedFlag.SetActive(false);
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.name.Contains("Hand") && !isTriggered)
        {
            ActivateFlag();
        }
    }

    void ActivateFlag()
    {
        isTriggered = true;

        if (relatedFlag != null) relatedFlag.SetActive(true);

        if (nationalAnthem != null) nationalAnthem.Play();

        GetComponent<Renderer>().material.color = Color.white;

        Debug.Log(gameObject.name + " aktif edildi!");
    }
}