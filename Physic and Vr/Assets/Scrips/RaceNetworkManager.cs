using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Mirror;

public class RaceNetworkManager : NetworkManager 
{
    [SerializeField] private Transform[] spawnPoints;
    public override void OnServerAddPlayer(NetworkConnectionToClient conn)
    {
        //base.OnServerAddPlayer(conn);
        Vector3 spawnPoint = spawnPoints[numPlayers].position;
        var player = Instantiate(playerPrefab,spawnPoint, Quaternion.identity);
        NetworkServer.AddPlayerForConnection(conn,player);
    }
}
