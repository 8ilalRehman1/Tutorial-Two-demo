using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class InputManager
{
    private static GameControls _gamecontrols;

    public static void Init(Player myPlayer)
    {
        _gamecontrols = new GameControls();

        _gamecontrols.Permanent.Enable();

        _gamecontrols.InGame.Movment.performed += jeff => 
        {
            myPlayer.SetMovementDirection(jeff.ReadValue<Vector3>());
        
        };

    }
    public static void SetGameControls()
    {
        _gamecontrols.InGame.Enable();
        _gamecontrols.UI.Disable();
    }

    public static void SetUIControls()
    {
        _gamecontrols.UI.Enable();
        _gamecontrols.InGame.Disable();


    }
}
