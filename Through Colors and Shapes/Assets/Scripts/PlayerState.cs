using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class PlayerState
{
    public static bool isDead = false;
    public static Vector2 respawn = (0,0);

    public static bool checkPlayerDead(){
        return isDead;
    }

    public static Vector2 getRespawnPoint(){
        return respawn;
    }
    public static void setRespawnPoint(Vector2 newRespawn){
        respawn = newRespawn;
    }
}
