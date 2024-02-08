using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gamemode : MonoBehaviour
{
    public enum Modes
    {
        NormalMode = 0,
        AimbotMode = 1,
    }

    public delegate void Mode();
    public static Mode PlayerMode;
    public static Mode AimbotMode;

    void Awake()
    {
        DefaultMode();
        PlayerMode += NormalGM;
        AimbotMode += AimbotGM;

    }

    private void ChangeGameMode(int GM)
    {
        Modes currentMode = (Modes)GM;

        switch(currentMode)
        {
            case Modes.NormalMode:
            Debug.Log($"Current Gamemode is : {currentMode}");
            break;

            case Modes.AimbotMode:
            Debug.Log($"Current Gamemode is : {currentMode}");
            break;
            default:
            break;
        }
    }

    void DefaultMode()
    {
        ChangeGameMode(0);
    }

    void NormalGM()
    {
        ChangeGameMode(0);
    }

    void AimbotGM()
    {
        ChangeGameMode(1);
    }
}
