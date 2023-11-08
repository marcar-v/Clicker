using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.Rendering;

public class DistanceController : MonoBehaviour
{
    TextMeshProUGUI distanceText;
    [SerializeField] TextMeshProUGUI bestDistanceText;
    private float distance;

    private void Start()
    {
        distanceText = GetComponent<TextMeshProUGUI>();

        bestDistanceText.text = PlayerPrefs.GetFloat("BestDistance", 0.00f).ToString("F2");
    }

    void UpdateDistanceTextUI()
    {
        distance += Time.deltaTime * 0.8f;
        distanceText.text = distance.ToString("F2");
    }

    public void UpdateBestDistanceTextUI()
    {
        if(distance > PlayerPrefs.GetFloat("BestDistance", 0.00f))
        {
            PlayerPrefs.SetFloat("BestDistance", distance);
            bestDistanceText.text = distance.ToString("F2");
        }
    }

    void Update()
    {
        UpdateDistanceTextUI();
    }
}
