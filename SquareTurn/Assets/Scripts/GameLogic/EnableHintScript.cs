using cakeslice;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class EnableHintScript : MonoBehaviour {

    public static readonly string AVAILABLE_HINTS_PREF = "avialableHints";

    private OutlineEffect outlineEffect;
    private int availableHints = 4;

    [SerializeField]
    private Button button;
    [SerializeField]
    private TextMeshProUGUI hintCountText;
    [SerializeField]
    private Image buttonImage;
    [SerializeField]
    private Image lightBulbImage;

    private readonly Color32 normal = new Color32(255, 255, 255, 255);
    private readonly Color32 transparent = new Color32(255, 255, 255, 210);

    private int levelNumber;
    private bool hintEnabled = false;

    private void Start()
    {
        levelNumber = PlayerPrefs.GetInt("ChosenLevel");
        if (!PlayerPrefs.HasKey(AVAILABLE_HINTS_PREF)) {
            availableHints = 4;
            PlayerPrefs.SetInt(AVAILABLE_HINTS_PREF, 4);
        } else
        {
            availableHints = PlayerPrefs.GetInt(AVAILABLE_HINTS_PREF);
        }
        hintCountText.text = availableHints + "x";
        outlineEffect = Camera.main.GetComponent<OutlineEffect>();

        hintEnabled = HintLevelInfo.IsHintEnabled(levelNumber);
        if (hintEnabled)
        {
            DisableButton();
        }
    }

    public void EnableHint()
    {
        if (availableHints > 0)
        {
            HintLevelInfo.AddLevelToHintList(levelNumber);
            outlineEffect.enabled = true;
            availableHints--;
            PlayerPrefs.SetInt(AVAILABLE_HINTS_PREF, availableHints);
            hintCountText.text = availableHints + "x";
            if(availableHints == 0)
            {
                DisableButton();
            }
        }
    }

    private void DisableButton()
    {
        button.interactable = false;
        lightBulbImage.color = transparent;
        hintCountText.color = transparent;
    }
}
