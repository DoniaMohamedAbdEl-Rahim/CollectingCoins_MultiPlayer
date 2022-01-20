using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using Photon.Pun;
using TMPro;

public class CreateAndJoinRooms : MonoBehaviourPunCallbacks
{
    [SerializeField]
    TMP_InputField createInput;
    [SerializeField]
    TMP_InputField joinInput;
    void Start()
    {
        
    }

    void Update()
    {
        
    }
    public void CreateRoom()
    {
        //this need string => room name
        PhotonNetwork.CreateRoom(createInput.text);
    }
    public void JoinRoom()
    {
        //this need string => the room name
        PhotonNetwork.JoinRoom(joinInput.text);
    }

    public override void OnJoinedRoom()
    {
        //load scene with photon to make multiplayer scene
        PhotonNetwork.LoadLevel("Gameplay");
    }
}
