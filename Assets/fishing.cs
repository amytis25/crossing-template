using UnityEngine;

public class fishing : MonoBehaviour
{
    public GameObject fishingRod;
    public GameObject fishIcon;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.E))
            StartFishing();
    }

    void StartFishing()
    {
        //show fishing rod and icon
        if (fishingRod != null)
            fishingRod.SetActive(true);

        StartCoroutine(FishingSequence());
    }

    private System.Collections.IEnumerator FishingSequence()
    {
        yield return new WaitForSeconds(2f);

        if (fishingRod != null)
            fishingRod.SetActive(false);

        if (fishIcon != null)
        {
            fishIcon.SetActive(true);
        }
        yield return new WaitForSeconds(2f);
 if (fishIcon != null)
        {
            fishIcon.SetActive(false);
        }
    }
}
