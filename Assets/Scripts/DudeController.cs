using UnityEngine;
using System.Collections;

public class DudeController : MonoBehaviour {
  public Rigidbody2D Dude;
  public Transform DudeTransform;
  public float JumpForce = 500f;

  private const float GROUND_HEIGHT = -2.65f;
  private const float WALK_SPEED = 10f;

  void Update () {
    if (WellGrounded()) {
      if(Input.GetButtonDown("Jump")) {
        Dude.AddForce(new Vector2(0f, JumpForce));
      } else if (Input.GetButton("Horizontal")) {
        Dude.AddForce(new Vector2(Input.GetAxis("Horizontal") * WALK_SPEED, 0f));
      } else if (Input.GetButtonUp("Horizontal")) {
        Dude.velocity = Vector2.zero;
      }
    }
  }

  private bool WellGrounded() {
    return Dude.velocity.y == 0;
  }
}
