using UnityEngine;
using TMPro;

public class ClockController : MonoBehaviour
{
    [SerializeField] private Clock analogClock;
    [SerializeField] private DigitalClock digitalClock;
    [SerializeField] private TMP_Text secondsButtonText;

    private bool showSeconds = true;

    public void ToggleSeconds()
    {
        showSeconds = !showSeconds;

        analogClock.SetShowSeconds(showSeconds);
        digitalClock.SetShowSeconds(showSeconds);
        secondsButtonText.text = showSeconds ? "Hide Seconds" : "Show Seconds";
    }
}