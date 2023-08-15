using System;
using TMPro;
using UnityEngine;

public class InteractableObjectController : MonoBehaviour
{
    [SerializeField] private Transform _character;

    public Transform Character => _character;

    public void TeleportCharacter(Vector3 pos)
    {
        _character.position = pos;
    }
}