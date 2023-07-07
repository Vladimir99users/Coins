using UnityEngine;
using TMPro;

public class GUITextInformation : GUI
{
    [SerializeField] private TextMeshProUGUI _textClickedPlayer;
    [SerializeField] private int _score = 0;

    private IRelouded _reloadInformationOnTapScore;

    private void Start() 
    {
        _score = 0;
        SetInformation();
    }

    protected override void SetInformation()
    {
        _reloadInformationOnTapScore = new TextChange(_textClickedPlayer,_score);

        GlobalEventManager.OnTap.AddListener(CountingNumberClicks);
    }

    private void CountingNumberClicks()
    {
        _score++;
        _reloadInformationOnTapScore.Reload(_score);
    }
}
