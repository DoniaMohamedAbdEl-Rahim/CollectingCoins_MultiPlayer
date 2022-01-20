using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Photon.Pun;
using Photon.Realtime;
using TMPro;
public class LobbyManager : MonoBehaviourPunCallbacks
{
    [SerializeField]
    TMP_InputField roomInputFeild;
    [SerializeField]
    GameObject lobbyPanel;
    [SerializeField]
    GameObject roomPanel;
    [SerializeField]
    TMP_Text roomName;

    [SerializeField]
    RoomItem roomItemPrefab;
    List<RoomItem> roomItemList=new List<RoomItem>();
    public Transform contentObject;
    void Start()
    {
        PhotonNetwork.JoinLobby();
    }

    public void OnClickCreate()
    {
        if (roomInputFeild.text.Length >= 1)
        {
            //To limit room number of players
            // PhotonNetwork.CreateRoom(roomInputFeild.text , new RoomOptions () { MaxPlayers=3});
            PhotonNetwork.CreateRoom(roomInputFeild.text);
        }
    }
    public override void OnJoinedRoom()
    {
        lobbyPanel.SetActive(false);
        roomPanel.SetActive(true);
        roomName.text = "Room name : " + PhotonNetwork.CurrentRoom.Name;
    }

    public override void OnRoomListUpdate(List<RoomInfo> roomList)
    {
        UpdateRoomList(roomList);
    }

    void UpdateRoomList(List<RoomInfo> list)
    {
        foreach(RoomItem item in roomItemList)
        {
            Destroy(item.gameObject);
        }
        roomItemList.Clear();
        foreach(RoomInfo room in list)
        {
            RoomItem newRoom = Instantiate(roomItemPrefab, contentObject);
            newRoom.SetRoomName(room.Name);
            roomItemList.Add(newRoom);
        }
    }
    public void JoinRoom(string _roomName)
    {
        PhotonNetwork.JoinRoom(_roomName);
    }
}
