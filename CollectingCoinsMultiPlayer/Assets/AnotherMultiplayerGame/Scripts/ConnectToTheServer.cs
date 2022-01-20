using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Photon.Pun;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using TMPro;
public class ConnectToTheServer : MonoBehaviourPunCallbacks
{
    [SerializeField]
    TMP_InputField userNameInput;
    [SerializeField]
    TMP_Text btnTxt;
    void Start()
    {

    }

    void Update()
    {

    }

    public void OnClickConnect()
    {
        if (userNameInput.text.Length >= 1)
        {
            PhotonNetwork.NickName = userNameInput.text;
            btnTxt.text = "Connecting...";
            PhotonNetwork.ConnectUsingSettings();
        }
    }

    public override void OnConnectedToMaster()
    {
        SceneManager.LoadScene("Lobby");
    }
}
