using UnityEngine;
using System.Collections;

public class CursorLock : MonoBehaviour
{
    CursorLockMode wantedMode;

    // Apply requested cursor state
    void SetCursorState()
    {
        Cursor.lockState = wantedMode;
        // Hide cursor when locking
        Cursor.visible = (CursorLockMode.None!= wantedMode);
    }

    void OnGUI()
    {
       // GUILayout.BeginVertical();
        // Release cursor on escape keypress
        if (Input.GetKeyDown(KeyCode.Escape))
            Cursor.lockState = wantedMode = CursorLockMode.None;

        switch (Cursor.lockState)
        {
            case CursorLockMode.None:
            //    GUILayout.Label("Cursor is normal");
                if (GUILayout.Button(""))
                   wantedMode = CursorLockMode.Locked;
                if (GUILayout.Button(""))
                   wantedMode = CursorLockMode.Confined;
             break;
           case CursorLockMode.Confined:
//   GUILayout.Label("Cursor is confined");
            if (GUILayout.Button(""))
                  wantedMode = CursorLockMode.Locked;
               if (GUILayout.Button(""))
                   wantedMode = CursorLockMode.None;
               break;
            case CursorLockMode.Locked:
               GUILayout.Label("");
               if (GUILayout.Button(""))
                   wantedMode = CursorLockMode.None;
               if (GUILayout.Button(""))
                   wantedMode = CursorLockMode.Confined;
               break;
      }

     //   GUILayout.EndVertical();

      //  SetCursorState();
    }
}