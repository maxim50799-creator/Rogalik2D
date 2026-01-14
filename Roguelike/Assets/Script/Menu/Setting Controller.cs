using UnityEngine;

public class SettingController : MonoBehaviour
{
    [SerializeField] private GameObject _settingPanel;

    public void ChangeSettingState(bool state)
    {
        _settingPanel.SetActive(state);
    }
}
