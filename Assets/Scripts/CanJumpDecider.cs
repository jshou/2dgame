using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class CanJumpDecider : MonoBehaviour {
  public Collider2D DudeCollider;

  private HashSet<Collision2D> Collisions;
  private const string GROUND_TAG = "ground";

  void Start() {
    Collisions = new HashSet<Collision2D>();
  }

  public bool CanJump() {
    return Collisions.Count == 0;
  }

  void OnCollisionEnter2D(Collision2D coll) {
    if (coll.gameObject.tag == GROUND_TAG) {
      Collisions.Add(coll);
    }
  }

  void OnCollisionExit2D(Collision2D coll) {
    if (coll.gameObject.tag == GROUND_TAG) {
      Collisions.Remove(coll);
    }
  }
}
