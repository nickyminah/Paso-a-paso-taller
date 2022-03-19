using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rock : MonoBehaviour {
	void OnCollinsionEnter(Collision collision) {
		// pregunto si en este objeto le pego o colisiono contra el objeto que tiene el tag de Carro
		if (collision.gameObject.tag=="Carro"){
			//En la consola de Unity aparece que perdí
			Debug.Log("Game Over");
			Destroy(collision.gameObject);
		}
	}
}
