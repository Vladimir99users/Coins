using UnityEngine;
using UnityEngine.UI;
public class ExitOnApplication : MonoBehaviour
{
    [SerializeField] private Button _buttonExitGame;

    private void OnEnable() 
    {
        _buttonExitGame.onClick.AddListener(ExitGame);
    }

    private void OnDisable() 
    {
        _buttonExitGame.onClick.RemoveListener(ExitGame);
    }
    private void ExitGame()
    {
        #if UNITY_EDITOR
            UnityEditor.EditorApplication.isPlaying = false;
        #else
            Application.Quit();
        #endif
    }
}
