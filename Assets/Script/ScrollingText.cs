using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class ScrollingText : MonoBehaviour
{
    [SerializeField][TextArea] private string[] iteminfo;
    [SerializeField] private float textspeed = 0.01f;
    public Button buttondisable;

    public AudioSource _audio;
    public AudioClip Clip;

    [Header("UI Elements")]
    [SerializeField] private TextMeshProUGUI iteminfotext;
    [SerializeField] public int currentDisplayText = 0;

    public void Start()
    {
        StartCoroutine(AnimateText());
    }

    public void NextParagraf()
    {
        currentDisplayText++;
        StartCoroutine(AnimateText());
    }

    IEnumerator AnimateText()
    {
        _audio.PlayOneShot(Clip);
        for (int i = 0; i < iteminfo[currentDisplayText].Length + 1; i++)
        {
            buttondisable.interactable = false;
            iteminfotext.text = iteminfo[currentDisplayText].Substring(0, i);
            yield return new WaitForSeconds(textspeed);
        }
        _audio.Stop();
        buttondisable.interactable = true;
    }
}
