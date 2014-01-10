using UnityEngine;
using System.Collections;

public class DudeController : MonoBehaviour {
  public Rigidbody2D Dude;
  public Transform DudeTransform;
  public float JumpForce = 500f;

  private const float GROUND_HEIGHT = -2.65f;

  void Update () {
    if(Input.GetButtonDown("Jump") && DudeTransform.localPosition.y < GROUND_HEIGHT) {
      Dude.AddForce(new Vector2(0f, JumpForce));
    }
  }
}
