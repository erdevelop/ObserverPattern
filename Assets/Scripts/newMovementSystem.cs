using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class newMovementSystem : MonoBehaviour
{

    private void Start()
    {
        //newMovementPanel.OnForwardButtonClicked += MoveForward;
        //newMovementPanel.OnBackButtonClicked += MoveBack;
        //newMovementPanel.OnLeftButtonClicked += MoveLeft;
        //newMovementPanel.OnRightButtonClicked += MoveRight;

        newMovementPanel.OnButtonClicked += Move;

    
    }

    private void OnDestroy()
    {
        newMovementPanel.OnButtonClicked -= Move;
    }

    public void MoveForward() => transform.Translate(Vector3.forward);
    public void MoveBack() => transform.Translate(Vector3.back);
    public void MoveLeft() => transform.Translate(Vector3.left);
    public void MoveRight() => transform.Translate(Vector3.right);

    public void Move(Vector3 direction) => transform.Translate(direction);
}
