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

    //クッキーを押したときの処理を作る
    private void OnCookieClicked()
    {
        //クッキーの数を増やす
        CookieNumber++;
    }
    void Start()
    {
        //cokieButtonを押したときに呼ばれr処理を作る
        //
        CookieButton.onClick.AddListener( ( ) => OnCookieClicked( ) );
       
    }

    // Update is called once per frame
    void Update()
    {
        cookieText.text = $"Cookie Number - {CookieNumber}";
    }
}
