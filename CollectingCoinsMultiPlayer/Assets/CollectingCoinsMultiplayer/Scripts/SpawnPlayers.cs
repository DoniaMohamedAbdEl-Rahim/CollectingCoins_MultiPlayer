using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Photon.Pun;
public class SpawnPlayers : MonoBehaviour
{
    [SerializeField]
    GameObject playerPrefab;

    // Set the zone boundries that we need to spown the players in
    [SerializeField]
    float minX;
    [SerializeField]
    float maxX;
    [SerializeField]
    float minZ;
    [SerializeField]
    float maxZ;
    void Start()
    {
        Vector3 randomPosition = new Vector3(Random.Range(minX, maxX), 0, Random.Range(minZ, maxZ));
        //So each build of the game you can see all players instead of using the instantiate that you will see only one player
        PhotonNetwork.Instantiate(playerPrefab.name, randomPosition, Quaternion.identity);
    }

    void Update()
    {
        
    }
}
