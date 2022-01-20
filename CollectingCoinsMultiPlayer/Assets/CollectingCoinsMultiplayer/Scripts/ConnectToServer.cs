using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Photon.Pun;
using UnityEngine.SceneManagement;
public class ConnectToServer : MonoBehaviourPunCallbacks
{
    void Start()
    {
        PhotonNetwork.ConnectUsingSettings();   
    }

    void Update()
    {
        
    }
    //Called back in photo when a certin event happens
    //When we succesfully connected to our server , all things inside this function will happen
    public override void OnConnectedToMaster()
    {
        //This will give us power to create rooms and join
        PhotonNetwork.JoinLobby();
    }

    public override void OnJoinedLobby()
    {
        SceneManager.LoadScene("Lobby");
    }
}
