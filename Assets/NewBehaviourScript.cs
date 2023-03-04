using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class NewBehaviourScript : MonoBehaviour
{
    // Start is called before the first frame update
    private int CookieNumber;
    [SerializeField] Button CookieButton;
    [SerializeField] TextMeshProUGUI cookieText;

    //�N�b�L�[���������Ƃ��̏��������
    private void OnCookieClicked()
    {
        //�N�b�L�[�̐��𑝂₷
        CookieNumber++;
    }
    void Start()
    {
        //cokieButton���������Ƃ��ɌĂ΂�r���������
        //
        CookieButton.onClick.AddListener( ( ) => OnCookieClicked( ) );
       
    }

    // Update is called once per frame
    void Update()
    {
        cookieText.text = $"Cookie Number - {CookieNumber}";
    }
}
