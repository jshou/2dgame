using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class CanJumpDecider : MonoBehaviour {
  public Collider2D DudeCollider;

  private int Collisions = 0;
  private const string GROUND_TAG = "ground";

  public bool CanJump() {
    return Collisions > 0;
  }

  void OnCollisionEnter2D(Collision2D coll) {
    if (coll.gameObject.tag == GROUND_TAG) {
      Collisions++;
    }
  }

  void OnCollisionExit2D(Collision2D coll) {
    if (coll.gameObject.tag == GROUND_TAG) {
      Collisions--;
    }
  }
}
