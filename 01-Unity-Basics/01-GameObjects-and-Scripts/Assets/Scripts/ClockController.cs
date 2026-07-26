using UnityEngine;
using TMPro;

public class ClockController : MonoBehaviour
{
    [SerializeField] private Clock analogClock;
    [SerializeField] private DigitalClock digitalClock;
    [SerializeField] private TMP_Text secondsButtonText;
    [SerializeField] private bool is24Hour = true;
    [SerializeField] private TMP_Text formatBtnText;


    private bool showSeconds = true;

    public void ToggleSeconds()
    {
        showSeconds = !showSeconds;

        analogClock.SetShowSeconds(showSeconds);
        digitalClock.SetShowSeconds(showSeconds);
        secondsButtonText.text = showSeconds ? "Hide Seconds" : "Show Seconds";
    }
    public void ToggleFormat()
    {
        is24Hour = !is24Hour;
        digitalClock.SetTimeFormat(is24Hour);
        formatBtnText.text = is24Hour ? "24H" : "12H";
    }
}