using UnityEngine;

public class MenuController : MonoBehaviour
{
    [SerializeField] private SettingController _settingController;

    public void OpenSetting()
    {
        _settingController.ChangeSettingState(true);
    }

    public void Quit()
    {
        Debug.Log("Выхоим из игры");
        Application.Quit();
    }
}
